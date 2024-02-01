using System.Diagnostics;
using System.Data;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using IronFlow.Resources;
using IronFlow.Model;
using System.Runtime.CompilerServices;

namespace IronFlow
{
    public partial class IronPanel : Form
    {
        private System.Windows.Forms.TabControl mainTabControl;
        private SqlConnection cnn;
        private Utilities _utilities;
        private TrackingModel _trackingModel;
        private TransferModel _transferModel;
        public bool isRadioAllChanged = false;
        protected bool isErrorOcurred = false;
        private bool isTimerChecked = false;
        private bool isOnlyEndTimeOcurred = false;
        protected bool isBeta = false;
        protected string IronPanelTitle = "Iron Flow";
        private bool isITSChecked = false;
        private bool isAnyCellSelected = false;
        protected bool isTokenActive = false;
        public ApplicationBase application = new ApplicationBase();

        private TabControl tc;
        private List<TabPage> pages;


        public IronPanel()
        {
            _utilities = new Utilities();
            _trackingModel = new TrackingModel();
            _transferModel = new TransferModel();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //// no smaller than design time size
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);

            //// no larger than screen size
            //this.MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            mainTabControl.Dock = DockStyle.None;
            mainTabControl.AutoSize = true;

            transfer.ClientSize = this.MinimumSize;
            tracking.ClientSize = this.MinimumSize;

            //childs
            wfHistoryGridView.Dock = DockStyle.None;
            wfHistoryGridView.AutoSize = true;

            T_trackinViewResult.Dock = DockStyle.None;
            T_trackinViewResult.AutoSize = true;

            T_transferGridView.Dock = DockStyle.None;
            //T_transferGridView.AutoSize = true;

            querySource.Dock = DockStyle.None;
            querySource.AutoSize = true;

            queryResultGridView.Dock = DockStyle.None;
            //queryResultGridView.AutoSize = true;

            panel1.Dock = DockStyle.None;
            panel1.AutoSize = true;

            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            mainTabControl.Dock = DockStyle.Fill;

            //wfHistoryGridView.Dock = DockStyle.Fill;

            connectionStringTxt.Enabled = false;
            T_wfitemType_txt.Text = "Application";
            FillTransferDropdowns();

            //commenting for beta version the checkbox for associates and all radio button.
            T_associates_check.Enabled = false;
            T_all_radio.Enabled = false;
            btn_transfer.Enabled = false;
            txtTimerEndTime.Text = "2023-11-11 17:58:15.837";
            //creating a copy

            tc = mainTabControl;
            pages = new List<TabPage>();

            foreach (TabPage p in tc.TabPages)
            {
                pages.Add(p);
            }

            DisableAllTabs();

        }

        private void dev_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string localHangfire = "https://sladevapi.svam.com/internalAPi/hangfire/recurring";

            dev.LinkVisited = true;
            System.Diagnostics.Process.Start(new ProcessStartInfo() { FileName = localHangfire, UseShellExecute = true });

        }

        private void devPerformance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string localHangfire = "https://sladevperformanceapi.svam.com/internalAPI/hangfire/recurring";

            dev.LinkVisited = true;
            System.Diagnostics.Process.Start(new ProcessStartInfo() { FileName = localHangfire, UseShellExecute = true });
        }

        private void qaHang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string localHangfire = "https://slaleapqaapi.svam.com/internalAPi/hangfire/recurring";

            dev.LinkVisited = true;
            System.Diagnostics.Process.Start(new ProcessStartInfo() { FileName = localHangfire, UseShellExecute = true });
        }

        private void localHangfire_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string localHangfire = "https://localhost:44378/hangfire";

            dev.LinkVisited = true;
            System.Diagnostics.Process.Start(new ProcessStartInfo() { FileName = localHangfire, UseShellExecute = true });
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            string connectionString = connectionStringTxt.Text;
            try
            {
                if (!string.IsNullOrWhiteSpace(connectionString))
                {
                    var builder = new SqlConnectionStringBuilder(connectionString);

                    builder.Encrypt = true;
                    builder.TrustServerCertificate = true;
                    builder.PersistSecurityInfo = true;

                    cnn = new SqlConnection(builder.ToString());
                    cnn.Open();
                    MessageBox.Show("Successfully");
                    Configstatus.Text = "Connected.";
                    //if an error was ocurred in transfer tab, we are enabling again the values after get the connection
                    EnableTransferItems();
                    T_startBtn.Enabled = true;

                    //start common tab
                    common_users_grid.DataSource = _utilities.GetUsers(cnn);
                }
                else
                {
                    MessageBox.Show("Fill the connection string", "Warning");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid connection or your VPN is disconnected", "Error");
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void flushBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tokenTxt.Text) && tokenTxt.Text.Equals(GlobalConstants.masterToken))
            {
                isTokenActive = true;
                EnableAllTabs();
                tokenTxt.Enabled = false;
            }
        }

        private void T_clearBtn_Click(object sender, EventArgs e)
        {
            T_applicationIdTxt.Text = string.Empty;
            Tracking_appIdTxt.Text = string.Empty;
            T_isMainCheck.Checked = false;
            T_showAssociatesCheck.Checked = false;
            T_trackinViewResult.DataSource = null;

        }

        private void T_submitBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Tracking_appIdTxt.Text) || !string.IsNullOrWhiteSpace(T_applicationIdTxt.Text))
            {
                int appId;
                _ = int.TryParse(Tracking_appIdTxt.Text, out appId);

                //checkboxes
                bool? isMain = (T_isMainCheck.Checked == false) ? null : true;
                bool? showAssociates = (T_showAssociatesCheck.Checked == false) ? null : true;
                _trackingModel = new TrackingModel();
                _trackingModel.IsMain = isMain;
                _trackingModel.ShowAssociates = showAssociates;
                _trackingModel.ApplicationId = T_applicationIdTxt.Text;
                _trackingModel.AppId = appId;
                //preparing the sp object

                //clearing old data in the view
                DataTable dt = (DataTable)T_trackinViewResult.DataSource;
                if (dt != null)
                    dt.Clear();

                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    //var dataAdapter = new SqlDataAdapter(trackingQuery, cnn);
                    ExecuteTracking(_trackingModel);
                }
                else
                {
                    MessageBox.Show("Connection Error", "Error");
                    MessageBox.Show("You must to start the connection before", "Warning");
                }
            }
            else
            {
                MessageBox.Show("Fill the values", "Warning");
            }
        }

        private void T_appIdTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_utilities.isNumber(sender, e))
            {
                MessageBox.Show("Integer Value Only", "Warning");
            }
        }

        private void ExecuteTracking(TrackingModel trackingModel)
        {

            var result = GetAssociatesByParemeters(trackingModel);
            T_trackinViewResult.ReadOnly = true;
            T_trackinViewResult.DataSource = result?.Tables[0];

        }

        private void ExecuteTransferPreview()
        {
            //clearing old data in the view
            DataTable dt = (DataTable)T_transferGridView.DataSource;
            if (dt != null)
            {
                dt.Clear();
                T_transferGridView.DataSource = null;
            }
            if (!isErrorOcurred)
            {
                var appId = _transferModel.AppId;
                bool? _showAssociates = (_transferModel.IsAssociates == false) ? null : _transferModel.IsAssociates;
                bool? _isMain = (_transferModel.Isindividual == false) ? null : _transferModel.Isindividual;

                var associates = GetAssociatesByParemeters(new TrackingModel()
                {
                    AppId = appId,
                    ShowAssociates = _showAssociates,
                    IsMain = _isMain
                });

                T_transferGridView.ReadOnly = true;
                T_transferGridView.DataSource = associates?.Tables[0];

            }
        }

        private void config_disconnectBtn_Click(object sender, EventArgs e)
        {
            if (cnn != null && cnn.State == ConnectionState.Open)
            {
                this.Text = IronPanelTitle;
                cnn.Close();
                Configstatus.Text = "Disconnected.";
                MessageBox.Show("Disconnected Successfully");
            }
        }

        private void t_appId_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_utilities.isNumber(sender, e))
            {
                MessageBox.Show("Integer Value Only", "Warning");
            }
        }

        private void FillTransferDropdowns()
        {
            //int id = (int)myComboBox.SelectedValue;

            T_roleId.DataSource = new ComboItem[]
            {
                new ComboItem{ ID = 2, Text = "System" },
                new ComboItem{ ID = 3, Text = "Clerical" },
                new ComboItem{ ID = 4, Text = "Examiner" },
                new ComboItem{ ID = 20, Text = "Supervisor Examiner" },
                new ComboItem{ ID = 5, Text = "Licensing Board" },
                new ComboItem{ ID = 8, Text = "Deputy Commissioner" },
                new ComboItem{ ID = 16, Text = "Refund Team" },
            };

            T_roleId.DisplayMember = "Text";
            T_roleId.ValueMember = "ID";



            T_appstatus.DataSource = new ComboItem[]
            {
                new ComboItem{ ID = 2, Text = "Intake Complete" },
                new ComboItem{ ID = 3, Text = "Under Review" },
                new ComboItem{ ID = 4, Text = "Approved" },
                new ComboItem{ ID = 5, Text = "Conditionally Approved" },
                new ComboItem{ ID = 6, Text = "Disapproved" },
                new ComboItem{ ID = 7, Text = "Withdrawn" },
                new ComboItem{ ID = 8, Text = "Reconsideration" },
                new ComboItem{ ID = 9, Text = "Conditionally Approved -Operating under 20 day" },
                new ComboItem{ ID = 10, Text = "Operating Under SAPA" },
                new ComboItem{ ID = 11, Text = "Pending License Approval" },
                new ComboItem{ ID = 15, Text = "Inactive" },

            };

            T_appstatus.DisplayMember = "Text";
            T_appstatus.ValueMember = "ID";

        }

        private void T_endTime_check_CheckedChanged(object sender, EventArgs e)
        {
            var isOnlyEndTime = (CheckBox)sender;


            if (isOnlyEndTime.Checked)
            {
                ClearTransferModel(true);
                T_roleId.Enabled = false;
                T_appstatus.Enabled = false;
                T_isTimerCheck.Enabled = false;
                T_taskId_txt.Enabled = false;
                T_taskStatus_txt.Enabled = false;
                isOnlyEndTimeOcurred = true;
            }
            else
            {
                T_roleId.Enabled = true;
                T_appstatus.Enabled = true;
                T_isTimerCheck.Enabled = true;
                T_taskId_txt.Enabled = true;
                T_taskStatus_txt.Enabled = true;
                isOnlyEndTimeOcurred = false;
            }

        }

        private void T_startBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(transfer_appId_txt.Text))
            {
                //check if at least one of the items were selected
                if (isAnyOptionSelected())
                {
                    DisableTransferItems();
                    PrepareTransferingData();
                    var modelResult = MapToJson();
                    //if json is filled up, we will proceed to save the data into the database and transfer the application
                    if (!string.IsNullOrWhiteSpace(modelResult))
                    {
                        //validate if taskId, task status and role are coming are required
                        bool isDone = false;
                        //if only end time is not checked validate for values, otherwise validate isTimer or endTime data

                        if (isRequiredValuesCompleted() && !isOnlyEndTimeOcurred)
                        {
                            isDone = StartTransfer(modelResult);
                        }
                        else if (isOnlyEndTimeOcurred && (!string.IsNullOrWhiteSpace(T_EndTime_txt.Text) || T_isTimerCheck.Checked))
                        {
                            isDone = StartTransfer(modelResult);
                        }
                        else if (isOnlyEndTimeOcurred)
                        {
                            MessageBox.Show("You must to fill {EndTime} / {IsTimer}", "Warning");
                        }
                        else
                        {
                            MessageBox.Show("You must to fill {TaskId}, {Task Status} and {Role}", "Warning");
                        }

                        if (isDone)
                        {
                            MessageBox.Show("The transfer has been successfully", "Success");
                            ExecuteTransferPreview();

                            //MessageBox.Show(modelResult, "Old Data");
                            T_startBtn.Enabled = false;
                            transfer_previewBtn.Enabled = false;
                        }
                        //ClearTransferModel();
                    }
                }
                else
                {
                    MessageBox.Show("You must to select an option", "Warning");
                }
            }
            else
            {
                MessageBox.Show("AppId Required", "Warning");
            }
        }

        private void T_all_radio_CheckedChanged(object sender, EventArgs e)
        {
            var allRadioCheck = (RadioButton)sender;
            if (allRadioCheck.Checked)
            {
                T_individual_check.Enabled = false;
                T_associates_check.Enabled = false;

                T_individual_check.Checked = false;
                T_associates_check.Checked = false;
            }
        }

        private void T_individual_check_CheckedChanged(object sender, EventArgs e)
        {
            var individualCheck = (CheckBox)sender;
            if (individualCheck.Checked && isBeta)
            {
                T_all_radio.Enabled = true;
                T_associates_check.Enabled = true;
            }
        }

        private void T_associates_check_CheckedChanged(object sender, EventArgs e)
        {
            var associatesCheck = (CheckBox)sender;
            if (associatesCheck.Checked && isBeta)
            {
                T_all_radio.Enabled = true;
                T_individual_check.Enabled = true;
            }
        }


        private void T_all_radio_MouseCaptureChanged(object sender, EventArgs e)
        {
            var allRadioCheck = (RadioButton)sender;

            if (allRadioCheck.Checked && isRadioAllChanged == false && isBeta)
            {
                T_individual_check.Enabled = true;
                T_associates_check.Enabled = true;
                T_all_radio.Checked = false;
                isRadioAllChanged = true;
            }
            else
            {
                T_all_radio.Checked = true;
                isRadioAllChanged = false;
            }
        }

        #region Transfering
        private bool isAnyOptionSelected()
        {
            return T_all_radio.Checked || T_individual_check.Checked || T_associates_check.Checked;
        }
        private void PrepareTransferingData()
        {
            try
            {
                _transferModel = new TransferModel();
                int appId, taskId;
                _ = int.TryParse(transfer_appId_txt.Text.Trim(), out appId);
                _ = int.TryParse(T_taskId_txt.Text.Trim(), out taskId);
                bool isOnlyEndTimeSelected = T_endTime_check.Checked;

                _transferModel.AppId = appId;
                _transferModel.Isindividual = T_individual_check.Checked;
                _transferModel.IsAssociates = T_associates_check.Checked;
                _transferModel.isAll = T_all_radio.Checked;
                _transferModel.TaskId = taskId;
                _transferModel.TaskStatus = T_taskStatus_txt.Text.Trim();
                _transferModel.AppStatusId = (isOnlyEndTimeSelected) ? 0 : (int)T_appstatus.SelectedValue;
                _transferModel.WorkflowItemType = T_wfitemType_txt.Text.Trim();
                _transferModel.RoleId = (isOnlyEndTimeSelected) ? 0 : (int)T_roleId.SelectedValue;
                _transferModel.IsTimer = (isTimerChecked == false) ? null : T_isTimerCheck.Checked;
                _transferModel.EndTime = T_EndTime_txt.Text.Trim();
                _transferModel.isOnlyEndTime = isOnlyEndTimeSelected;
                isErrorOcurred = false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
                MessageBox.Show(e.StackTrace, "Error Stack");
                EnableTransferItems();
                isErrorOcurred = true;
            }

        }
        private void DisableTransferItems()
        {
            transfer_appId_txt.Enabled = false;
            T_roleId.Enabled = false;
            T_appstatus.Enabled = false;
            T_isTimerCheck.Enabled = false;
            T_taskId_txt.Enabled = false;
            T_taskStatus_txt.Enabled = false;
            T_all_radio.Enabled = false;
            T_EndTime_txt.Enabled = false;
            T_endTime_check.Enabled = false;
            T_individual_check.Enabled = false;
            T_associates_check.Enabled = false;
            T_wfitemType_txt.Enabled = false;
        }

        private void EnableTransferItems()
        {
            transfer_appId_txt.Enabled = true;
            T_roleId.Enabled = true;
            T_appstatus.Enabled = true;
            T_isTimerCheck.Enabled = true;
            T_taskId_txt.Enabled = true;
            T_taskStatus_txt.Enabled = true;
            //T_all_radio.Enabled = true; BETA version on going
            T_EndTime_txt.Enabled = true;
            T_endTime_check.Enabled = true;
            T_individual_check.Enabled = true;
            //T_associates_check.Enabled = true; BETA version on going
            T_wfitemType_txt.Enabled = true;
        }
        private string MapToJson()
        {
            string json = string.Empty;
            if (_transferModel != null)
            {
                json = JsonConvert.SerializeObject(_transferModel);
            }

            return json;
        }
        private DataSet? GetAssociatesByParemeters(TrackingModel trackingModel)
        {
            if (cnn != null && cnn.State == ConnectionState.Open)
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetMainAndAssociates_IronFlow", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@appId", trackingModel.AppId);
                    cmd.Parameters.AddWithValue("@applicationId", trackingModel.ApplicationId);
                    cmd.Parameters.AddWithValue("@isMain", trackingModel.IsMain);
                    cmd.Parameters.AddWithValue("@showAssociates", trackingModel.ShowAssociates);

                    cmd.ExecuteNonQuery();
                    var dataAdapter = new SqlDataAdapter(cmd);

                    var ds = new DataSet();
                    dataAdapter.Fill(ds);


                    return ds;
                }
            }
            else
            {
                MessageBox.Show("An error has been ocurred", "Error");
                MessageBox.Show("You must to start the connection again", "Warning");
                T_startBtn.Enabled = false;
            }
            return null;
        }

        private bool StartTransfer(object dataTransfer)
        {
            if (cnn != null && cnn.State == ConnectionState.Open)
            {
                using (SqlCommand cmd = new SqlCommand("ups_TransferApplications_IronFlow", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@dataTransfer", dataTransfer);

                    cmd.ExecuteNonQuery();

                    return true;
                }
            }
            else
            {
                MessageBox.Show("An error has been ocurred", "Error");
                MessageBox.Show("You must to start the connection again", "Warning");
                T_startBtn.Enabled = false;
                transfer_previewBtn.Enabled = false;
            }

            return false;
        }
        #endregion

        private void T_taskId_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_utilities.isNumber(sender, e))
            {
                MessageBox.Show("Integer Value Only", "Warning");
            }
        }

        private void transfer_previewBtn_Click(object sender, EventArgs e)
        {
            PrepareTransferingData();
            ExecuteTransferPreview();

        }

        private void transfer_starOverBtn_Click(object sender, EventArgs e)
        {
            ClearTransferModel();
            EnableTransferItems();
            T_startBtn.Enabled = true;
            transfer_previewBtn.Enabled = true;
        }

        private void ClearTransferModel(bool isEndtimeChecked = false)
        {
            _transferModel = new TransferModel();
            FillTransferDropdowns();
            transfer_appId_txt.Text = (isEndtimeChecked) ? transfer_appId_txt.Text : string.Empty;
            T_isTimerCheck.Checked = false;
            T_taskId_txt.Text = string.Empty;
            T_taskStatus_txt.Text = string.Empty;
            T_all_radio.Checked = false;
            T_EndTime_txt.Text = string.Empty;
            T_endTime_check.Checked = (isEndtimeChecked) ? true : false;
            T_individual_check.Checked = false;
            T_associates_check.Checked = false;
            T_wfitemType_txt.Text = "Application";
            T_transferGridView.DataSource = null;
        }

        private void T_isTimerCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (T_isTimerCheck.Checked)
            {
                isTimerChecked = true;
            }
            else
            {
                isTimerChecked = false;
            }
        }
        //validate if taskId, task status and role are coming are required
        private bool isRequiredValuesCompleted()
        {
            return (T_taskId_txt.Text != string.Empty && T_taskStatus_txt.Text != string.Empty && (int)T_roleId.SelectedValue != 0);
        }

        private void Transfer_unlockTaskBtn_Click(object sender, EventArgs e)
        {
            if (T_endTime_check.Checked)
            {
                T_EndTime_txt.Enabled = true;
                T_endTime_check.Enabled = true;
                transfer_appId_txt.Enabled = true;
            }
            else
            {
                EnableTransferItems();
            }

            transfer_previewBtn.Enabled = true;
            T_startBtn.Enabled = true;

        }

        private void history_appId_txt_KeyPress(object sender, KeyEventArgs e)
        {
            int appId;
            _ = int.TryParse(history_appId_txt.Text.Trim(), out appId);

            if (e.KeyCode == Keys.Enter && appId > 0)
            {
                var dataSource = GetWorkflowHistoryByAppId(appId);
                wfHistoryGridView.ReadOnly = true;
                wfHistoryGridView.DataSource = dataSource;
            }
        }

        private DataTable? GetWorkflowHistoryByAppId(int appId)
        {
            if (cnn != null && cnn.State == ConnectionState.Open)
            {
                string wfHistory = $"SELECT H.* FROM WfItemMaster WF\r\nINNER JOIN WfTaskFlowHistory H \r\nON H.WfItemMasterId = (\r\n   SELECT TOP 1 WfItemMasterId FROM WfItemTaskMapping WT WHERE WF.Id = WT.WfItemMasterId\r\n)\r\nWHERE WF.WfItemId = {appId};";
                SqlCommand cmd = new SqlCommand(wfHistory, cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            else
            {
                MessageBox.Show("An error has been ocurred", "Error");
                MessageBox.Show("You must to start the connection again", "Warning");
                T_startBtn.Enabled = false;
                transfer_previewBtn.Enabled = false;
            }

            return null;
        }

        private void Tracking_appIdTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                T_submitBtn_Click(sender, e);
            }
        }

        private void T_applicationIdTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                T_submitBtn_Click(sender, e);
            }
        }

        private void mainTabControl_Resize(object sender, EventArgs e)
        {
            //int w = mainTabControl.Width;

            //w = (w - 120) / 4;

            //tracking.Width = w;
            //T_trackinViewResult.Width = w;
        }

        private void config_dev_check_CheckedChanged(object sender, EventArgs e)
        {
            string devConnectionString = "Data Source= 10.3.0.4;Initial Catalog=NYSLA_Leap_DevIntegration;User ID=leapDev;Password=MyPass@123;";
            if (config_dev_check.Checked)
            {
                connectionStringTxt.Text = (isITSChecked == true) ? GlobalConstants.ITSDev : devConnectionString;
                connectionStringTxt.Enabled = false;
                this.Text = IronPanelTitle + " - (Dev)";
            }
        }

        private void config_local_check_CheckedChanged(object sender, EventArgs e)
        {
            string localConnectionString = "Data Source= 10.3.0.4;Initial Catalog=NYSLA_Leap_New;User ID=leapDev;Password=MyPass@123;";
            if (config_local_check.Checked)
            {
                connectionStringTxt.Text = localConnectionString;
                connectionStringTxt.Enabled = false;
                this.Text = IronPanelTitle + " - (Dev Performance / Local)";
            }
        }

        private void config_qa_check_CheckedChanged(object sender, EventArgs e)
        {
            string qaConnectionString = "Data Source=10.3.0.5;Initial Catalog=NYSLA_Leap_QA;User ID=sladbadmin;Password=P#@sswin22;";
            if (config_qa_check.Checked)
            {
                connectionStringTxt.Text = (isITSChecked == true) ? GlobalConstants.ITSQA : qaConnectionString;
                connectionStringTxt.Enabled = false;
                this.Text = IronPanelTitle + " - (QA)";
            }
        }

        private void radioFB_CheckedChanged(object sender, EventArgs e)
        {
            string fbConnectionString = "Data Source=10.3.0.4;Initial Catalog=NYSLA_Leap_FB;User ID=leapDev;Password=MyPass@123;";
            if (radioFB.Checked)
            {
                connectionStringTxt.Text = fbConnectionString;
                connectionStringTxt.Enabled = false;
                this.Text = IronPanelTitle + " - (SLA FB)";
            }

        }

        private void config_custom_check_CheckedChanged(object sender, EventArgs e)
        {
            string customConnectionString = "Data Source=<>;Initial Catalog=<>;User ID=<>;Password=<>;";
            if (config_custom_check.Checked)
            {
                connectionStringTxt.Text = customConnectionString;
                connectionStringTxt.Enabled = true;
                this.Text = IronPanelTitle + " - (Custom)";
            }
        }

        private void common_appId_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int appId;
                _ = int.TryParse(common_appId_txt.Text, out appId);

                common_examinersandlb_view.DataSource = _utilities.GetUsersAssignedByAppId(appId, cnn);
            }
        }

        private void common_startOverBtn_Click(object sender, EventArgs e)
        {
            common_examinersandlb_view.DataSource = null;
            common_appId_txt.Text = string.Empty;
            common_examinerId_txt.Text = string.Empty;
            common_licBoardId_txt.Text = string.Empty;
        }

        private void common_appId_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_utilities.isNumber(sender, e))
            {
                MessageBox.Show("Integer Value Only", "Warning");
            }
        }

        private void common_examinerId_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_utilities.isNumber(sender, e))
            {
                MessageBox.Show("Integer Value Only", "Warning");
            }
        }

        private void common_licBoardId_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_utilities.isNumber(sender, e))
            {
                MessageBox.Show("Integer Value Only", "Warning");
            }
        }

        private void common_userSearch_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var user = common_userSearch_txt.Text.Trim();

                if (!string.IsNullOrWhiteSpace(user) && common_users_grid.DataSource != null)
                {
                    //Name is the row name from the source
                    ((DataTable)common_users_grid.DataSource).DefaultView.RowFilter = string.Format("" + "Name" + " like '%{0}%'", user.Replace("'", "''"));
                    //common_userSearch_txt.Text = (common_users_grid.Rows.Count - 1).ToString();
                }
                else
                {
                    common_users_grid.DataSource = _utilities.GetUsers(cnn);
                }
            }
        }

        private void common_assignBtn_Click(object sender, EventArgs e)
        {
            int appId;
            _ = int.TryParse(common_appId_txt.Text, out appId);

            int examinerId;
            _ = int.TryParse(common_examinerId_txt.Text, out examinerId);

            int licBoardId;
            _ = int.TryParse(common_licBoardId_txt.Text, out licBoardId);

            _utilities.UpdateExaminerAndLicBoard(appId, examinerId, licBoardId, cnn);

        }

        private void querySource_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                var querySourceData = querySource.SelectedText;
                var fullQueryData = querySource.Text;
                string querySelected = string.Empty;

                if (!string.IsNullOrWhiteSpace(querySourceData))
                {
                    querySelected = querySourceData;
                }
                else if (!string.IsNullOrWhiteSpace(fullQueryData))
                {
                    querySelected = fullQueryData;
                }

                queryResultGridView.DataSource = _utilities.ExecuteQuery(querySelected, cnn);
            }
        }

        private void checkITS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkITS.Checked == true)
            {
                isITSChecked = true;
            }
            else if (checkITS.Checked == false)
            {
                isITSChecked = false;
            }
        }

        private void btn_transfer_Click(object sender, EventArgs e)
        {
            if (isAnyCellSelected)
            {
                transfer_appId_txt.Text = application.AppId;
                T_appstatus.Text = application.AppStatusId;
                T_taskId_txt.Text = application.TaskId;
                T_taskStatus_txt.Text = application.TaskStatus;
                T_roleId.Text = application.RoleId;
                T_EndTime_txt.Text = application.EndTime;

                T_roleId.SelectedItem = _utilities.SetItemValue(T_roleId.DataSource, application, GlobalConstants.RoleTypeId);
                T_appstatus.SelectedItem = _utilities.SetItemValue(T_appstatus.DataSource, application, GlobalConstants.AppStatusTypeId);

                MessageBox.Show("done...");
            }
            else
            {
                MessageBox.Show("must to select any cell first");
            }
        }


        private void T_trackinViewResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //code for select single record
                //var rowIndex = e.RowIndex;
                //var currentRow = T_trackinViewResult.Rows[rowIndex];
                //var currentCellValue = T_trackinViewResult.Rows[rowIndex].Cells[e.ColumnIndex].Value.ToString();
                var selectionTest = T_trackinViewResult.SelectedCells;

                //pending to review when 1 item is being sending
                foreach (DataGridViewTextBoxCell currentRow in selectionTest)
                {

                    if (currentRow.ColumnIndex == -1 || currentRow.ColumnIndex == 0 || currentRow.ColumnIndex == 3
                        || currentRow.ColumnIndex == 6 || currentRow.ColumnIndex == 9 || currentRow.ColumnIndex == 10
                        || currentRow.ColumnIndex == 11) return;

                    if (currentRow != null)
                    {
                        string headerName = currentRow?.DataGridView?.Columns[currentRow.ColumnIndex].Name ?? string.Empty;
                        var rowIndex = currentRow?.RowIndex ?? 0;
                        var currentCellValue = T_trackinViewResult.Rows[rowIndex].Cells[currentRow.ColumnIndex].Value.ToString();



                        SetHeaderAndData(headerName, currentCellValue);

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("an error has ocurred", ex.Message);
            }

        }

        private void SetHeaderAndData(string headerName, string? value)
        {
            if (value != null)
            {

                switch (headerName)
                {
                    case "AppId": application.AppId = value; break;
                    case "AppStatusId": application.AppStatusId = value; break;
                    case "TaskId": application.TaskId = value; break;
                    case "RoleId": application.RoleId = value; break;
                    case "EndTime": application.EndTime = value; break;
                    case "TaskStatus": application.TaskStatus = value; break;
                }

                isAnyCellSelected = true;
                btn_transfer.Enabled = true;
            }

        }

        private void fbLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string fbHangfire = "https://slafbapi.svam.com/internalapi/hangfire/jobs/succeeded";

            dev.LinkVisited = true;
            System.Diagnostics.Process.Start(new ProcessStartInfo() { FileName = fbHangfire, UseShellExecute = true });
        }


        private void DisableAllTabs()
        {

            foreach (TabPage p in pages)
            {

                if (p.Name != "tracking" && p.Name != "flush" && p.Name != "configuration" && p.Name != "tabTimer")
                {
                    tc.TabPages.Remove(p);
                }
            }

        }
        private void EnableAllTabs()
        {
            foreach (TabPage p in pages)
            {
                if (p.Name != "tracking" && p.Name != "flush" && p.Name != "configuration" && p.Name != "tabTimer")
                {
                    tc.TabPages.Add(p);
                }
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            tokenTxt.Text = string.Empty;
            tokenTxt.Enabled = true;
            DisableAllTabs();

        }

        private void btnTimerStart_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTimerAppId.Text))
            {
                int appId;
                _ = int.TryParse(txtTimerAppId.Text, out appId);


                _transferModel = new TransferModel();
                _transferModel.AppId = appId;
                _transferModel.EndTime = txtTimerEndTime.Text.Trim();
                //_transferModel.IsTimer = (isTimerChecked == false) ? null : T_isTimerCheck.Checked;
                var modelResult = MapToJson();
                if (!string.IsNullOrWhiteSpace(txtTimerEndTime.Text))
                {
                    bool isDone = StartTransfer(modelResult);
                }

                _trackingModel = new TrackingModel();
                _trackingModel.IsMain = true;
                _trackingModel.ShowAssociates = false;
                _trackingModel.AppId = appId;

                DataTable dt = (DataTable)gridTimerView.DataSource;
                if (dt != null)
                    dt.Clear();
                if (cnn != null && cnn.State == ConnectionState.Open)
                {

                    var result = GetAssociatesByParemeters(_trackingModel);
                    gridTimerView.ReadOnly = true;
                    gridTimerView.DataSource = result?.Tables[0];
                }
                else
                {
                    MessageBox.Show("Connection Error", "Error");
                    MessageBox.Show("You must to start the connection before", "Warning");
                }

            }
        }

        private void btnTimerClear_Click(object sender, EventArgs e)
        {
            txtTimerAppId.Text = string.Empty;
            gridTimerView.DataSource = null;
        }
    }
}

