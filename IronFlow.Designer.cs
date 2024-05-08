namespace IronFlow
{
    partial class IronPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IronPanel));
            mainTabControl = new TabControl();
            tracking = new TabPage();
            btn_transfer = new Button();
            label6 = new Label();
            T_clearBtn = new Button();
            T_submitBtn = new Button();
            T_trackinViewResult = new DataGridView();
            T_showAssociatesCheck = new CheckBox();
            T_isMainCheck = new CheckBox();
            Tracking_appIdTxt = new TextBox();
            T_applicationIdTxt = new TextBox();
            label5 = new Label();
            label4 = new Label();
            transfer = new TabPage();
            Transfer_unlockTaskBtn = new Button();
            label19 = new Label();
            transfer_starOverBtn = new Button();
            T_transferGridView = new DataGridView();
            T_all_radio = new RadioButton();
            label9 = new Label();
            panel1 = new Panel();
            transfer_previewBtn = new Button();
            T_wfitemType_txt = new TextBox();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            T_endTime_check = new CheckBox();
            T_startBtn = new Button();
            T_EndTime_txt = new TextBox();
            label15 = new Label();
            T_roleId = new ComboBox();
            T_appstatus = new ComboBox();
            label14 = new Label();
            T_isTimerCheck = new CheckBox();
            label13 = new Label();
            label12 = new Label();
            T_taskStatus_txt = new TextBox();
            label11 = new Label();
            label10 = new Label();
            T_taskId_txt = new TextBox();
            label8 = new Label();
            label7 = new Label();
            T_associates_check = new CheckBox();
            T_individual_check = new CheckBox();
            transfer_appId_txt = new TextBox();
            T_appIdLbl = new Label();
            wfHistoryTab = new TabPage();
            label21 = new Label();
            label20 = new Label();
            wfHistoryGridView = new DataGridView();
            history_appId_txt = new TextBox();
            history_appId_lbl = new Label();
            commonTab = new TabPage();
            label27 = new Label();
            common_userSearch_txt = new TextBox();
            common_startOverBtn = new Button();
            label26 = new Label();
            panel2 = new Panel();
            common_users_grid = new DataGridView();
            common_assignBtn = new Button();
            common_licBoardId_txt = new TextBox();
            common_examinerId_txt = new TextBox();
            common_examinersandlb_view = new DataGridView();
            common_appId_txt = new TextBox();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            splitter1 = new Splitter();
            queryTab = new TabPage();
            queryResultGridView = new DataGridView();
            querySource = new RichTextBox();
            flush = new TabPage();
            btnLogOut = new Button();
            fbLabel = new LinkLabel();
            localHangfire = new LinkLabel();
            qaHang = new LinkLabel();
            devPerformance = new LinkLabel();
            label3 = new Label();
            dev = new LinkLabel();
            startBtn = new Button();
            tokenTxt = new TextBox();
            label2 = new Label();
            configuration = new TabPage();
            qaZcaler = new RadioButton();
            radioFB = new RadioButton();
            checkITS = new CheckBox();
            config_custom_check = new RadioButton();
            config_local_check = new RadioButton();
            config_qa_check = new RadioButton();
            config_dev_check = new RadioButton();
            shortLbl = new Label();
            config_disconnectBtn = new Button();
            Configstatus = new Label();
            connectBtn = new Button();
            connectionStringTxt = new TextBox();
            label1 = new Label();
            tabTimer = new TabPage();
            timerWfTypeTxt = new TextBox();
            label28 = new Label();
            btnTimerClear = new Button();
            gridTimerView = new DataGridView();
            label31 = new Label();
            btnTimerStart = new Button();
            txtTimerEndTime = new TextBox();
            label32 = new Label();
            txtTimerAppId = new TextBox();
            label30 = new Label();
            mainTabControl.SuspendLayout();
            tracking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)T_trackinViewResult).BeginInit();
            transfer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)T_transferGridView).BeginInit();
            panel1.SuspendLayout();
            wfHistoryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)wfHistoryGridView).BeginInit();
            commonTab.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)common_users_grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)common_examinersandlb_view).BeginInit();
            queryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)queryResultGridView).BeginInit();
            flush.SuspendLayout();
            configuration.SuspendLayout();
            tabTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridTimerView).BeginInit();
            SuspendLayout();
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(tracking);
            mainTabControl.Controls.Add(transfer);
            mainTabControl.Controls.Add(wfHistoryTab);
            mainTabControl.Controls.Add(commonTab);
            mainTabControl.Controls.Add(queryTab);
            mainTabControl.Controls.Add(flush);
            mainTabControl.Controls.Add(configuration);
            mainTabControl.Controls.Add(tabTimer);
            mainTabControl.Dock = DockStyle.Fill;
            mainTabControl.Location = new Point(0, 0);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.ShowToolTips = true;
            mainTabControl.Size = new Size(822, 452);
            mainTabControl.TabIndex = 0;
            mainTabControl.Resize += mainTabControl_Resize;
            // 
            // tracking
            // 
            tracking.AutoScroll = true;
            tracking.Controls.Add(btn_transfer);
            tracking.Controls.Add(label6);
            tracking.Controls.Add(T_clearBtn);
            tracking.Controls.Add(T_submitBtn);
            tracking.Controls.Add(T_trackinViewResult);
            tracking.Controls.Add(T_showAssociatesCheck);
            tracking.Controls.Add(T_isMainCheck);
            tracking.Controls.Add(Tracking_appIdTxt);
            tracking.Controls.Add(T_applicationIdTxt);
            tracking.Controls.Add(label5);
            tracking.Controls.Add(label4);
            tracking.Location = new Point(4, 24);
            tracking.Name = "tracking";
            tracking.Size = new Size(814, 424);
            tracking.TabIndex = 0;
            tracking.Text = "Tracking";
            tracking.ToolTipText = "Allows to track the application";
            tracking.UseVisualStyleBackColor = true;
            // 
            // btn_transfer
            // 
            btn_transfer.Location = new Point(677, 365);
            btn_transfer.Name = "btn_transfer";
            btn_transfer.Size = new Size(75, 23);
            btn_transfer.TabIndex = 10;
            btn_transfer.Text = "Transfer";
            btn_transfer.UseVisualStyleBackColor = true;
            btn_transfer.Click += btn_transfer_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(321, 23);
            label6.Name = "label6";
            label6.Size = new Size(23, 15);
            label6.TabIndex = 9;
            label6.Text = "OR";
            // 
            // T_clearBtn
            // 
            T_clearBtn.Location = new Point(114, 355);
            T_clearBtn.Name = "T_clearBtn";
            T_clearBtn.Size = new Size(75, 23);
            T_clearBtn.TabIndex = 8;
            T_clearBtn.Text = "Clear";
            T_clearBtn.UseVisualStyleBackColor = true;
            T_clearBtn.Click += T_clearBtn_Click;
            // 
            // T_submitBtn
            // 
            T_submitBtn.Location = new Point(24, 355);
            T_submitBtn.Name = "T_submitBtn";
            T_submitBtn.Size = new Size(75, 23);
            T_submitBtn.TabIndex = 7;
            T_submitBtn.Text = "Submit";
            T_submitBtn.UseVisualStyleBackColor = true;
            T_submitBtn.Click += T_submitBtn_Click;
            // 
            // T_trackinViewResult
            // 
            T_trackinViewResult.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            T_trackinViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            T_trackinViewResult.Location = new Point(18, 55);
            T_trackinViewResult.Name = "T_trackinViewResult";
            T_trackinViewResult.RowHeadersWidth = 62;
            T_trackinViewResult.RowTemplate.Height = 25;
            T_trackinViewResult.Size = new Size(734, 294);
            T_trackinViewResult.TabIndex = 6;
            T_trackinViewResult.CellClick += T_trackinViewResult_CellClick;
            // 
            // T_showAssociatesCheck
            // 
            T_showAssociatesCheck.AutoSize = true;
            T_showAssociatesCheck.Location = new Point(621, 24);
            T_showAssociatesCheck.Name = "T_showAssociatesCheck";
            T_showAssociatesCheck.Size = new Size(113, 19);
            T_showAssociatesCheck.TabIndex = 5;
            T_showAssociatesCheck.Text = "Show Associates";
            T_showAssociatesCheck.TextAlign = ContentAlignment.MiddleRight;
            T_showAssociatesCheck.UseVisualStyleBackColor = true;
            // 
            // T_isMainCheck
            // 
            T_isMainCheck.AutoSize = true;
            T_isMainCheck.Location = new Point(513, 24);
            T_isMainCheck.Name = "T_isMainCheck";
            T_isMainCheck.Size = new Size(69, 19);
            T_isMainCheck.TabIndex = 4;
            T_isMainCheck.Text = "Is Main?";
            T_isMainCheck.UseVisualStyleBackColor = true;
            // 
            // Tracking_appIdTxt
            // 
            Tracking_appIdTxt.Location = new Point(398, 20);
            Tracking_appIdTxt.Name = "Tracking_appIdTxt";
            Tracking_appIdTxt.Size = new Size(100, 23);
            Tracking_appIdTxt.TabIndex = 3;
            Tracking_appIdTxt.KeyDown += Tracking_appIdTxt_KeyDown;
            Tracking_appIdTxt.KeyPress += T_appIdTxt_KeyPress;
            // 
            // T_applicationIdTxt
            // 
            T_applicationIdTxt.Location = new Point(104, 21);
            T_applicationIdTxt.Name = "T_applicationIdTxt";
            T_applicationIdTxt.Size = new Size(196, 23);
            T_applicationIdTxt.TabIndex = 2;
            T_applicationIdTxt.KeyDown += T_applicationIdTxt_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(350, 23);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 1;
            label5.Text = "AppId :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 23);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 0;
            label4.Text = "ApplicationId :";
            // 
            // transfer
            // 
            transfer.AutoScroll = true;
            transfer.Controls.Add(Transfer_unlockTaskBtn);
            transfer.Controls.Add(label19);
            transfer.Controls.Add(transfer_starOverBtn);
            transfer.Controls.Add(T_transferGridView);
            transfer.Controls.Add(T_all_radio);
            transfer.Controls.Add(label9);
            transfer.Controls.Add(panel1);
            transfer.Controls.Add(label8);
            transfer.Controls.Add(label7);
            transfer.Controls.Add(T_associates_check);
            transfer.Controls.Add(T_individual_check);
            transfer.Controls.Add(transfer_appId_txt);
            transfer.Controls.Add(T_appIdLbl);
            transfer.Location = new Point(4, 24);
            transfer.Name = "transfer";
            transfer.Size = new Size(814, 424);
            transfer.TabIndex = 1;
            transfer.Text = "Transfer";
            transfer.ToolTipText = "Transfer to specific taskId or run the timer";
            transfer.UseVisualStyleBackColor = true;
            // 
            // Transfer_unlockTaskBtn
            // 
            Transfer_unlockTaskBtn.Location = new Point(658, 52);
            Transfer_unlockTaskBtn.Margin = new Padding(2);
            Transfer_unlockTaskBtn.Name = "Transfer_unlockTaskBtn";
            Transfer_unlockTaskBtn.Size = new Size(93, 20);
            Transfer_unlockTaskBtn.TabIndex = 14;
            Transfer_unlockTaskBtn.Text = "Unlock Task";
            Transfer_unlockTaskBtn.UseVisualStyleBackColor = true;
            Transfer_unlockTaskBtn.Click += Transfer_unlockTaskBtn_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(285, 9);
            label19.Name = "label19";
            label19.Size = new Size(106, 15);
            label19.TabIndex = 13;
            label19.Text = "Select an option : ";
            // 
            // transfer_starOverBtn
            // 
            transfer_starOverBtn.Location = new Point(658, 17);
            transfer_starOverBtn.Name = "transfer_starOverBtn";
            transfer_starOverBtn.Size = new Size(75, 23);
            transfer_starOverBtn.TabIndex = 12;
            transfer_starOverBtn.Text = "Start Over";
            transfer_starOverBtn.UseVisualStyleBackColor = true;
            transfer_starOverBtn.Click += transfer_starOverBtn_Click;
            // 
            // T_transferGridView
            // 
            T_transferGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            T_transferGridView.Location = new Point(6, 241);
            T_transferGridView.Name = "T_transferGridView";
            T_transferGridView.RowHeadersWidth = 62;
            T_transferGridView.RowTemplate.Height = 25;
            T_transferGridView.Size = new Size(765, 155);
            T_transferGridView.TabIndex = 11;
            // 
            // T_all_radio
            // 
            T_all_radio.AutoSize = true;
            T_all_radio.Location = new Point(445, 26);
            T_all_radio.Name = "T_all_radio";
            T_all_radio.Size = new Size(39, 19);
            T_all_radio.TabIndex = 9;
            T_all_radio.TabStop = true;
            T_all_radio.Text = "All";
            T_all_radio.UseVisualStyleBackColor = true;
            T_all_radio.CheckedChanged += T_all_radio_CheckedChanged;
            T_all_radio.MouseCaptureChanged += T_all_radio_MouseCaptureChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 58);
            label9.Name = "label9";
            label9.Size = new Size(87, 15);
            label9.TabIndex = 8;
            label9.Text = "Transferring To:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(transfer_previewBtn);
            panel1.Controls.Add(T_wfitemType_txt);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(T_endTime_check);
            panel1.Controls.Add(T_startBtn);
            panel1.Controls.Add(T_EndTime_txt);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(T_roleId);
            panel1.Controls.Add(T_appstatus);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(T_isTimerCheck);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(T_taskStatus_txt);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(T_taskId_txt);
            panel1.Location = new Point(6, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(766, 158);
            panel1.TabIndex = 7;
            // 
            // transfer_previewBtn
            // 
            transfer_previewBtn.Location = new Point(659, 94);
            transfer_previewBtn.Name = "transfer_previewBtn";
            transfer_previewBtn.Size = new Size(75, 23);
            transfer_previewBtn.TabIndex = 27;
            transfer_previewBtn.Text = "Preview";
            transfer_previewBtn.UseVisualStyleBackColor = true;
            transfer_previewBtn.Click += transfer_previewBtn_Click;
            // 
            // T_wfitemType_txt
            // 
            T_wfitemType_txt.Location = new Point(443, 29);
            T_wfitemType_txt.Name = "T_wfitemType_txt";
            T_wfitemType_txt.Size = new Size(125, 23);
            T_wfitemType_txt.TabIndex = 26;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(443, 11);
            label18.Name = "label18";
            label18.Size = new Size(128, 15);
            label18.TabIndex = 25;
            label18.Text = "Workflow Item Type: ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(312, 121);
            label17.Name = "label17";
            label17.Size = new Size(149, 15);
            label17.TabIndex = 24;
            label17.Text = "Note: use the string format";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 133);
            label16.Name = "label16";
            label16.Size = new Size(51, 15);
            label16.TabIndex = 10;
            label16.Text = "Output :";
            // 
            // T_endTime_check
            // 
            T_endTime_check.AutoSize = true;
            T_endTime_check.Location = new Point(606, 47);
            T_endTime_check.Name = "T_endTime_check";
            T_endTime_check.Size = new Size(103, 19);
            T_endTime_check.TabIndex = 23;
            T_endTime_check.Text = "Only End Time";
            T_endTime_check.UseVisualStyleBackColor = true;
            T_endTime_check.CheckedChanged += T_endTime_check_CheckedChanged;
            // 
            // T_startBtn
            // 
            T_startBtn.Location = new Point(569, 95);
            T_startBtn.Name = "T_startBtn";
            T_startBtn.Size = new Size(75, 23);
            T_startBtn.TabIndex = 22;
            T_startBtn.Text = "Start";
            T_startBtn.UseVisualStyleBackColor = true;
            T_startBtn.Click += T_startBtn_Click;
            // 
            // T_EndTime_txt
            // 
            T_EndTime_txt.Location = new Point(312, 95);
            T_EndTime_txt.Name = "T_EndTime_txt";
            T_EndTime_txt.PlaceholderText = "Example: 2023-03-05 08:50:19.803";
            T_EndTime_txt.Size = new Size(227, 23);
            T_EndTime_txt.TabIndex = 21;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(312, 73);
            label15.Name = "label15";
            label15.Size = new Size(64, 15);
            label15.TabIndex = 20;
            label15.Text = "End Time :";
            // 
            // T_roleId
            // 
            T_roleId.FormattingEnabled = true;
            T_roleId.Location = new Point(13, 95);
            T_roleId.Name = "T_roleId";
            T_roleId.Size = new Size(136, 23);
            T_roleId.TabIndex = 19;
            // 
            // T_appstatus
            // 
            T_appstatus.FormattingEnabled = true;
            T_appstatus.Location = new Point(290, 29);
            T_appstatus.Name = "T_appstatus";
            T_appstatus.Size = new Size(121, 23);
            T_appstatus.TabIndex = 18;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(290, 11);
            label14.Name = "label14";
            label14.Size = new Size(116, 15);
            label14.TabIndex = 17;
            label14.Text = "Application Status : ";
            // 
            // T_isTimerCheck
            // 
            T_isTimerCheck.AutoSize = true;
            T_isTimerCheck.Location = new Point(203, 104);
            T_isTimerCheck.Name = "T_isTimerCheck";
            T_isTimerCheck.Size = new Size(15, 14);
            T_isTimerCheck.TabIndex = 16;
            T_isTimerCheck.UseVisualStyleBackColor = true;
            T_isTimerCheck.CheckedChanged += T_isTimerCheck_CheckedChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(183, 73);
            label13.Name = "label13";
            label13.Size = new Size(55, 15);
            label13.TabIndex = 15;
            label13.Text = "IsTimer :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(16, 73);
            label12.Name = "label12";
            label12.Size = new Size(38, 15);
            label12.TabIndex = 13;
            label12.Text = "Role :";
            // 
            // T_taskStatus_txt
            // 
            T_taskStatus_txt.Location = new Point(98, 29);
            T_taskStatus_txt.Name = "T_taskStatus_txt";
            T_taskStatus_txt.Size = new Size(163, 23);
            T_taskStatus_txt.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(98, 11);
            label11.Name = "label11";
            label11.Size = new Size(78, 15);
            label11.TabIndex = 11;
            label11.Text = "Task Status : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(16, 11);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 10;
            label10.Text = "TaskId : ";
            // 
            // T_taskId_txt
            // 
            T_taskId_txt.Location = new Point(16, 29);
            T_taskId_txt.Name = "T_taskId_txt";
            T_taskId_txt.Size = new Size(50, 23);
            T_taskId_txt.TabIndex = 0;
            T_taskId_txt.KeyPress += T_taskId_txt_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(414, 29);
            label8.Name = "label8";
            label8.Size = new Size(23, 15);
            label8.TabIndex = 6;
            label8.Text = "OR";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(286, 29);
            label7.Name = "label7";
            label7.Size = new Size(23, 15);
            label7.TabIndex = 5;
            label7.Text = "OR";
            // 
            // T_associates_check
            // 
            T_associates_check.AutoSize = true;
            T_associates_check.Location = new Point(327, 27);
            T_associates_check.Name = "T_associates_check";
            T_associates_check.Size = new Size(81, 19);
            T_associates_check.TabIndex = 3;
            T_associates_check.Text = "Associates";
            T_associates_check.UseVisualStyleBackColor = true;
            T_associates_check.CheckedChanged += T_associates_check_CheckedChanged;
            // 
            // T_individual_check
            // 
            T_individual_check.AutoSize = true;
            T_individual_check.Location = new Point(201, 27);
            T_individual_check.Name = "T_individual_check";
            T_individual_check.Size = new Size(78, 19);
            T_individual_check.TabIndex = 2;
            T_individual_check.Text = "Individual";
            T_individual_check.UseVisualStyleBackColor = true;
            T_individual_check.CheckedChanged += T_individual_check_CheckedChanged;
            // 
            // transfer_appId_txt
            // 
            transfer_appId_txt.Location = new Point(66, 19);
            transfer_appId_txt.Name = "transfer_appId_txt";
            transfer_appId_txt.Size = new Size(100, 23);
            transfer_appId_txt.TabIndex = 1;
            transfer_appId_txt.KeyPress += t_appId_txt_KeyPress;
            // 
            // T_appIdLbl
            // 
            T_appIdLbl.AutoSize = true;
            T_appIdLbl.Location = new Point(15, 25);
            T_appIdLbl.Name = "T_appIdLbl";
            T_appIdLbl.RightToLeft = RightToLeft.No;
            T_appIdLbl.Size = new Size(45, 15);
            T_appIdLbl.TabIndex = 0;
            T_appIdLbl.Text = "AppId :";
            T_appIdLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // wfHistoryTab
            // 
            wfHistoryTab.AutoScroll = true;
            wfHistoryTab.Controls.Add(label21);
            wfHistoryTab.Controls.Add(label20);
            wfHistoryTab.Controls.Add(wfHistoryGridView);
            wfHistoryTab.Controls.Add(history_appId_txt);
            wfHistoryTab.Controls.Add(history_appId_lbl);
            wfHistoryTab.Location = new Point(4, 24);
            wfHistoryTab.Margin = new Padding(2);
            wfHistoryTab.Name = "wfHistoryTab";
            wfHistoryTab.Size = new Size(814, 424);
            wfHistoryTab.TabIndex = 4;
            wfHistoryTab.Text = "History";
            wfHistoryTab.ToolTipText = "Get the workflow history";
            wfHistoryTab.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(178, 20);
            label21.Margin = new Padding(2, 0, 2, 0);
            label21.Name = "label21";
            label21.Size = new Size(197, 15);
            label21.TabIndex = 12;
            label21.Text = "Note: type enter for fetch the results";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(6, 47);
            label20.Name = "label20";
            label20.Size = new Size(51, 15);
            label20.TabIndex = 11;
            label20.Text = "Output :";
            // 
            // wfHistoryGridView
            // 
            wfHistoryGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            wfHistoryGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            wfHistoryGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            wfHistoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            wfHistoryGridView.Location = new Point(2, 65);
            wfHistoryGridView.Margin = new Padding(2);
            wfHistoryGridView.Name = "wfHistoryGridView";
            wfHistoryGridView.RowHeadersWidth = 62;
            wfHistoryGridView.RowTemplate.Height = 33;
            wfHistoryGridView.Size = new Size(770, 329);
            wfHistoryGridView.TabIndex = 2;
            // 
            // history_appId_txt
            // 
            history_appId_txt.Location = new Point(56, 17);
            history_appId_txt.Margin = new Padding(2);
            history_appId_txt.Name = "history_appId_txt";
            history_appId_txt.Size = new Size(106, 23);
            history_appId_txt.TabIndex = 1;
            history_appId_txt.KeyDown += history_appId_txt_KeyPress;
            // 
            // history_appId_lbl
            // 
            history_appId_lbl.AutoSize = true;
            history_appId_lbl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            history_appId_lbl.Location = new Point(8, 15);
            history_appId_lbl.Margin = new Padding(2, 0, 2, 0);
            history_appId_lbl.Name = "history_appId_lbl";
            history_appId_lbl.Size = new Size(48, 15);
            history_appId_lbl.TabIndex = 0;
            history_appId_lbl.Text = "AppId : ";
            // 
            // commonTab
            // 
            commonTab.Controls.Add(label27);
            commonTab.Controls.Add(common_userSearch_txt);
            commonTab.Controls.Add(common_startOverBtn);
            commonTab.Controls.Add(label26);
            commonTab.Controls.Add(panel2);
            commonTab.Controls.Add(common_assignBtn);
            commonTab.Controls.Add(common_licBoardId_txt);
            commonTab.Controls.Add(common_examinerId_txt);
            commonTab.Controls.Add(common_examinersandlb_view);
            commonTab.Controls.Add(common_appId_txt);
            commonTab.Controls.Add(label25);
            commonTab.Controls.Add(label24);
            commonTab.Controls.Add(label23);
            commonTab.Controls.Add(label22);
            commonTab.Controls.Add(splitter1);
            commonTab.Location = new Point(4, 24);
            commonTab.Margin = new Padding(2);
            commonTab.Name = "commonTab";
            commonTab.Size = new Size(814, 424);
            commonTab.TabIndex = 5;
            commonTab.Text = "Roles";
            commonTab.ToolTipText = "Get or transfer the application from examiner or licensing board roleId";
            commonTab.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(591, 193);
            label27.Margin = new Padding(2, 0, 2, 0);
            label27.Name = "label27";
            label27.Size = new Size(61, 15);
            label27.TabIndex = 13;
            label27.Text = "Search by:";
            // 
            // common_userSearch_txt
            // 
            common_userSearch_txt.Location = new Point(591, 209);
            common_userSearch_txt.Margin = new Padding(2);
            common_userSearch_txt.Name = "common_userSearch_txt";
            common_userSearch_txt.Size = new Size(173, 23);
            common_userSearch_txt.TabIndex = 12;
            common_userSearch_txt.KeyDown += common_userSearch_txt_KeyDown;
            // 
            // common_startOverBtn
            // 
            common_startOverBtn.Location = new Point(288, 44);
            common_startOverBtn.Margin = new Padding(2);
            common_startOverBtn.Name = "common_startOverBtn";
            common_startOverBtn.Size = new Size(78, 20);
            common_startOverBtn.TabIndex = 11;
            common_startOverBtn.Text = "Start Over";
            common_startOverBtn.UseVisualStyleBackColor = true;
            common_startOverBtn.Click += common_startOverBtn_Click;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(448, 215);
            label26.Margin = new Padding(2, 0, 2, 0);
            label26.Name = "label26";
            label26.Size = new Size(41, 15);
            label26.TabIndex = 10;
            label26.Text = "Users :";
            // 
            // panel2
            // 
            panel2.Controls.Add(common_users_grid);
            panel2.Location = new Point(448, 232);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(317, 166);
            panel2.TabIndex = 1;
            // 
            // common_users_grid
            // 
            common_users_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            common_users_grid.Location = new Point(2, 2);
            common_users_grid.Margin = new Padding(2);
            common_users_grid.Name = "common_users_grid";
            common_users_grid.RowHeadersWidth = 62;
            common_users_grid.RowTemplate.Height = 33;
            common_users_grid.Size = new Size(313, 162);
            common_users_grid.TabIndex = 0;
            // 
            // common_assignBtn
            // 
            common_assignBtn.Location = new Point(448, 162);
            common_assignBtn.Margin = new Padding(2);
            common_assignBtn.Name = "common_assignBtn";
            common_assignBtn.Size = new Size(78, 20);
            common_assignBtn.TabIndex = 9;
            common_assignBtn.Text = "Assign";
            common_assignBtn.UseVisualStyleBackColor = true;
            common_assignBtn.Click += common_assignBtn_Click;
            // 
            // common_licBoardId_txt
            // 
            common_licBoardId_txt.Location = new Point(591, 121);
            common_licBoardId_txt.Margin = new Padding(2);
            common_licBoardId_txt.Name = "common_licBoardId_txt";
            common_licBoardId_txt.Size = new Size(106, 23);
            common_licBoardId_txt.TabIndex = 8;
            common_licBoardId_txt.KeyPress += common_licBoardId_txt_KeyPress;
            // 
            // common_examinerId_txt
            // 
            common_examinerId_txt.Location = new Point(448, 121);
            common_examinerId_txt.Margin = new Padding(2);
            common_examinerId_txt.Name = "common_examinerId_txt";
            common_examinerId_txt.Size = new Size(106, 23);
            common_examinerId_txt.TabIndex = 7;
            common_examinerId_txt.KeyPress += common_examinerId_txt_KeyPress;
            // 
            // common_examinersandlb_view
            // 
            common_examinersandlb_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            common_examinersandlb_view.Location = new Point(27, 85);
            common_examinersandlb_view.Margin = new Padding(2);
            common_examinersandlb_view.Name = "common_examinersandlb_view";
            common_examinersandlb_view.RowHeadersWidth = 62;
            common_examinersandlb_view.RowTemplate.Height = 33;
            common_examinersandlb_view.Size = new Size(340, 295);
            common_examinersandlb_view.TabIndex = 5;
            // 
            // common_appId_txt
            // 
            common_appId_txt.Location = new Point(27, 54);
            common_appId_txt.Margin = new Padding(2);
            common_appId_txt.Name = "common_appId_txt";
            common_appId_txt.Size = new Size(106, 23);
            common_appId_txt.TabIndex = 4;
            common_appId_txt.KeyDown += common_appId_txt_KeyDown;
            common_appId_txt.KeyPress += common_appId_txt_KeyPress;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(27, 25);
            label25.Margin = new Padding(2, 0, 2, 0);
            label25.Name = "label25";
            label25.Size = new Size(108, 15);
            label25.TabIndex = 3;
            label25.Text = "Look Up by AppId :";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(448, 25);
            label24.Margin = new Padding(2, 0, 2, 0);
            label24.Name = "label24";
            label24.Size = new Size(124, 15);
            label24.TabIndex = 2;
            label24.Text = "Assignment of Roles : ";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(591, 85);
            label23.Margin = new Padding(2, 0, 2, 0);
            label23.Name = "label23";
            label23.Size = new Size(110, 15);
            label23.TabIndex = 1;
            label23.Text = "Licensing Board Id :";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(448, 85);
            label22.Margin = new Padding(2, 0, 2, 0);
            label22.Name = "label22";
            label22.Size = new Size(75, 15);
            label22.TabIndex = 0;
            label22.Text = "Examiner Id :";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Margin = new Padding(2);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(432, 424);
            splitter1.TabIndex = 6;
            splitter1.TabStop = false;
            // 
            // queryTab
            // 
            queryTab.AllowDrop = true;
            queryTab.AutoScroll = true;
            queryTab.Controls.Add(queryResultGridView);
            queryTab.Controls.Add(querySource);
            queryTab.Location = new Point(4, 24);
            queryTab.Margin = new Padding(2);
            queryTab.Name = "queryTab";
            queryTab.Size = new Size(814, 424);
            queryTab.TabIndex = 6;
            queryTab.Text = "Rapid query";
            queryTab.ToolTipText = "Execute a single query or selected query, use F5";
            queryTab.UseVisualStyleBackColor = true;
            // 
            // queryResultGridView
            // 
            queryResultGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            queryResultGridView.Location = new Point(2, 256);
            queryResultGridView.Margin = new Padding(2);
            queryResultGridView.Name = "queryResultGridView";
            queryResultGridView.RowHeadersWidth = 62;
            queryResultGridView.RowTemplate.Height = 33;
            queryResultGridView.Size = new Size(770, 143);
            queryResultGridView.TabIndex = 1;
            // 
            // querySource
            // 
            querySource.Location = new Point(2, 2);
            querySource.Margin = new Padding(2);
            querySource.Name = "querySource";
            querySource.Size = new Size(771, 260);
            querySource.TabIndex = 0;
            querySource.Text = "";
            querySource.KeyUp += querySource_KeyUp;
            // 
            // flush
            // 
            flush.Controls.Add(btnLogOut);
            flush.Controls.Add(fbLabel);
            flush.Controls.Add(localHangfire);
            flush.Controls.Add(qaHang);
            flush.Controls.Add(devPerformance);
            flush.Controls.Add(label3);
            flush.Controls.Add(dev);
            flush.Controls.Add(startBtn);
            flush.Controls.Add(tokenTxt);
            flush.Controls.Add(label2);
            flush.Location = new Point(4, 24);
            flush.Name = "flush";
            flush.Size = new Size(814, 424);
            flush.TabIndex = 2;
            flush.Text = "Flushing";
            flush.ToolTipText = "Get the respective hangfire url or flush the application";
            flush.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(635, 78);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(75, 23);
            btnLogOut.TabIndex = 9;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // fbLabel
            // 
            fbLabel.AutoSize = true;
            fbLabel.Cursor = Cursors.Hand;
            fbLabel.Location = new Point(29, 291);
            fbLabel.Name = "fbLabel";
            fbLabel.Size = new Size(20, 15);
            fbLabel.TabIndex = 8;
            fbLabel.TabStop = true;
            fbLabel.Text = "FB";
            fbLabel.LinkClicked += fbLabel_LinkClicked;
            // 
            // localHangfire
            // 
            localHangfire.AutoSize = true;
            localHangfire.Location = new Point(29, 156);
            localHangfire.Margin = new Padding(2, 0, 2, 0);
            localHangfire.Name = "localHangfire";
            localHangfire.Size = new Size(35, 15);
            localHangfire.TabIndex = 7;
            localHangfire.TabStop = true;
            localHangfire.Text = "Local";
            localHangfire.LinkClicked += localHangfire_LinkClicked;
            // 
            // qaHang
            // 
            qaHang.AutoSize = true;
            qaHang.Cursor = Cursors.Hand;
            qaHang.Location = new Point(29, 255);
            qaHang.Name = "qaHang";
            qaHang.Size = new Size(24, 15);
            qaHang.TabIndex = 6;
            qaHang.TabStop = true;
            qaHang.Text = "QA";
            qaHang.LinkClicked += qaHang_LinkClicked;
            // 
            // devPerformance
            // 
            devPerformance.AutoSize = true;
            devPerformance.Cursor = Cursors.Hand;
            devPerformance.Location = new Point(29, 189);
            devPerformance.Name = "devPerformance";
            devPerformance.Size = new Size(98, 15);
            devPerformance.TabIndex = 5;
            devPerformance.TabStop = true;
            devPerformance.Text = "Dev Performance";
            devPerformance.LinkClicked += devPerformance_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 114);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 4;
            label3.Text = "HangFire API's";
            // 
            // dev
            // 
            dev.AutoSize = true;
            dev.Cursor = Cursors.Hand;
            dev.Location = new Point(29, 222);
            dev.Name = "dev";
            dev.Size = new Size(27, 15);
            dev.TabIndex = 3;
            dev.TabStop = true;
            dev.Tag = "https://localhost:44378/hangfire";
            dev.Text = "Dev";
            dev.LinkClicked += dev_LinkClicked;
            // 
            // startBtn
            // 
            startBtn.Location = new Point(534, 78);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(75, 23);
            startBtn.TabIndex = 2;
            startBtn.Text = "Submit";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += flushBtn_Click;
            // 
            // tokenTxt
            // 
            tokenTxt.Location = new Point(102, 31);
            tokenTxt.Name = "tokenTxt";
            tokenTxt.Size = new Size(608, 23);
            tokenTxt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 34);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 0;
            label2.Text = "Token : ";
            // 
            // configuration
            // 
            configuration.Controls.Add(qaZcaler);
            configuration.Controls.Add(radioFB);
            configuration.Controls.Add(checkITS);
            configuration.Controls.Add(config_custom_check);
            configuration.Controls.Add(config_local_check);
            configuration.Controls.Add(config_qa_check);
            configuration.Controls.Add(config_dev_check);
            configuration.Controls.Add(shortLbl);
            configuration.Controls.Add(config_disconnectBtn);
            configuration.Controls.Add(Configstatus);
            configuration.Controls.Add(connectBtn);
            configuration.Controls.Add(connectionStringTxt);
            configuration.Controls.Add(label1);
            configuration.Location = new Point(4, 24);
            configuration.Name = "configuration";
            configuration.Size = new Size(814, 424);
            configuration.TabIndex = 3;
            configuration.Text = "Configuration";
            configuration.ToolTipText = "Set the initial configuration";
            configuration.UseVisualStyleBackColor = true;
            // 
            // qaZcaler
            // 
            qaZcaler.AutoSize = true;
            qaZcaler.Location = new Point(575, 208);
            qaZcaler.Margin = new Padding(2);
            qaZcaler.Name = "qaZcaler";
            qaZcaler.Size = new Size(93, 19);
            qaZcaler.TabIndex = 12;
            qaZcaler.TabStop = true;
            qaZcaler.Text = "QA - (Zcaler)";
            qaZcaler.UseVisualStyleBackColor = true;
            qaZcaler.CheckedChanged += qaZcaler_CheckedChanged;
            // 
            // radioFB
            // 
            radioFB.AutoSize = true;
            radioFB.Location = new Point(407, 250);
            radioFB.Margin = new Padding(2);
            radioFB.Name = "radioFB";
            radioFB.Size = new Size(62, 19);
            radioFB.TabIndex = 11;
            radioFB.TabStop = true;
            radioFB.Text = "Sla Fb  ";
            radioFB.UseVisualStyleBackColor = true;
            radioFB.CheckedChanged += radioFB_CheckedChanged;
            // 
            // checkITS
            // 
            checkITS.AutoSize = true;
            checkITS.Location = new Point(668, 12);
            checkITS.Name = "checkITS";
            checkITS.Size = new Size(75, 19);
            checkITS.TabIndex = 10;
            checkITS.Text = "ITS mode";
            checkITS.UseVisualStyleBackColor = true;
            checkITS.CheckedChanged += checkITS_CheckedChanged;
            // 
            // config_custom_check
            // 
            config_custom_check.AutoSize = true;
            config_custom_check.Location = new Point(575, 250);
            config_custom_check.Margin = new Padding(2);
            config_custom_check.Name = "config_custom_check";
            config_custom_check.Size = new Size(67, 19);
            config_custom_check.TabIndex = 9;
            config_custom_check.TabStop = true;
            config_custom_check.Text = "Custom";
            config_custom_check.UseVisualStyleBackColor = true;
            config_custom_check.CheckedChanged += config_custom_check_CheckedChanged;
            // 
            // config_local_check
            // 
            config_local_check.AutoSize = true;
            config_local_check.Location = new Point(407, 208);
            config_local_check.Margin = new Padding(2);
            config_local_check.Name = "config_local_check";
            config_local_check.Size = new Size(149, 19);
            config_local_check.TabIndex = 8;
            config_local_check.TabStop = true;
            config_local_check.Text = "Dev Performance/Local";
            config_local_check.UseVisualStyleBackColor = true;
            config_local_check.CheckedChanged += config_local_check_CheckedChanged;
            // 
            // config_qa_check
            // 
            config_qa_check.AutoSize = true;
            config_qa_check.Location = new Point(575, 155);
            config_qa_check.Margin = new Padding(2);
            config_qa_check.Name = "config_qa_check";
            config_qa_check.Size = new Size(42, 19);
            config_qa_check.TabIndex = 7;
            config_qa_check.TabStop = true;
            config_qa_check.Text = "QA";
            config_qa_check.UseVisualStyleBackColor = true;
            config_qa_check.CheckedChanged += config_qa_check_CheckedChanged;
            // 
            // config_dev_check
            // 
            config_dev_check.AutoSize = true;
            config_dev_check.Location = new Point(407, 164);
            config_dev_check.Margin = new Padding(2);
            config_dev_check.Name = "config_dev_check";
            config_dev_check.Size = new Size(45, 19);
            config_dev_check.TabIndex = 6;
            config_dev_check.TabStop = true;
            config_dev_check.Text = "Dev";
            config_dev_check.UseVisualStyleBackColor = true;
            config_dev_check.CheckedChanged += config_dev_check_CheckedChanged;
            // 
            // shortLbl
            // 
            shortLbl.AutoSize = true;
            shortLbl.Location = new Point(407, 127);
            shortLbl.Margin = new Padding(2, 0, 2, 0);
            shortLbl.Name = "shortLbl";
            shortLbl.Size = new Size(123, 15);
            shortLbl.TabIndex = 5;
            shortLbl.Text = "Shortcut Connection :";
            // 
            // config_disconnectBtn
            // 
            config_disconnectBtn.Location = new Point(25, 176);
            config_disconnectBtn.Name = "config_disconnectBtn";
            config_disconnectBtn.Size = new Size(75, 23);
            config_disconnectBtn.TabIndex = 4;
            config_disconnectBtn.Text = "Disconect";
            config_disconnectBtn.UseVisualStyleBackColor = true;
            config_disconnectBtn.Click += config_disconnectBtn_Click;
            // 
            // Configstatus
            // 
            Configstatus.AutoSize = true;
            Configstatus.Location = new Point(144, 135);
            Configstatus.Name = "Configstatus";
            Configstatus.Size = new Size(39, 15);
            Configstatus.TabIndex = 3;
            Configstatus.Text = "Status";
            // 
            // connectBtn
            // 
            connectBtn.Location = new Point(25, 127);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(75, 23);
            connectBtn.TabIndex = 2;
            connectBtn.Text = "Connect";
            connectBtn.UseVisualStyleBackColor = true;
            connectBtn.Click += connectBtn_Click;
            // 
            // connectionStringTxt
            // 
            connectionStringTxt.Location = new Point(131, 70);
            connectionStringTxt.Name = "connectionStringTxt";
            connectionStringTxt.Size = new Size(606, 23);
            connectionStringTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 70);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Connection String:";
            // 
            // tabTimer
            // 
            tabTimer.Controls.Add(timerWfTypeTxt);
            tabTimer.Controls.Add(label28);
            tabTimer.Controls.Add(btnTimerClear);
            tabTimer.Controls.Add(gridTimerView);
            tabTimer.Controls.Add(label31);
            tabTimer.Controls.Add(btnTimerStart);
            tabTimer.Controls.Add(txtTimerEndTime);
            tabTimer.Controls.Add(label32);
            tabTimer.Controls.Add(txtTimerAppId);
            tabTimer.Controls.Add(label30);
            tabTimer.Location = new Point(4, 24);
            tabTimer.Name = "tabTimer";
            tabTimer.Padding = new Padding(3);
            tabTimer.Size = new Size(814, 424);
            tabTimer.TabIndex = 7;
            tabTimer.Text = "Timer";
            tabTimer.UseVisualStyleBackColor = true;
            // 
            // timerWfTypeTxt
            // 
            timerWfTypeTxt.Location = new Point(176, 57);
            timerWfTypeTxt.Name = "timerWfTypeTxt";
            timerWfTypeTxt.Size = new Size(125, 23);
            timerWfTypeTxt.TabIndex = 32;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label28.Location = new Point(176, 21);
            label28.Name = "label28";
            label28.Size = new Size(128, 15);
            label28.TabIndex = 31;
            label28.Text = "Workflow Item Type: ";
            // 
            // btnTimerClear
            // 
            btnTimerClear.Location = new Point(395, 136);
            btnTimerClear.Name = "btnTimerClear";
            btnTimerClear.Size = new Size(75, 23);
            btnTimerClear.TabIndex = 30;
            btnTimerClear.Text = "Clear";
            btnTimerClear.UseVisualStyleBackColor = true;
            btnTimerClear.Click += btnTimerClear_Click;
            // 
            // gridTimerView
            // 
            gridTimerView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridTimerView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTimerView.Location = new Point(22, 203);
            gridTimerView.Name = "gridTimerView";
            gridTimerView.RowHeadersWidth = 62;
            gridTimerView.RowTemplate.Height = 25;
            gridTimerView.Size = new Size(580, 186);
            gridTimerView.TabIndex = 29;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(22, 162);
            label31.Name = "label31";
            label31.Size = new Size(149, 15);
            label31.TabIndex = 28;
            label31.Text = "Note: use the string format";
            // 
            // btnTimerStart
            // 
            btnTimerStart.Location = new Point(289, 135);
            btnTimerStart.Name = "btnTimerStart";
            btnTimerStart.Size = new Size(75, 23);
            btnTimerStart.TabIndex = 27;
            btnTimerStart.Text = "Start";
            btnTimerStart.UseVisualStyleBackColor = true;
            btnTimerStart.Click += btnTimerStart_Click;
            // 
            // txtTimerEndTime
            // 
            txtTimerEndTime.Location = new Point(22, 136);
            txtTimerEndTime.Name = "txtTimerEndTime";
            txtTimerEndTime.PlaceholderText = "Example: 2023-03-05 08:50:19.803";
            txtTimerEndTime.Size = new Size(227, 23);
            txtTimerEndTime.TabIndex = 26;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label32.Location = new Point(22, 95);
            label32.Name = "label32";
            label32.Size = new Size(64, 15);
            label32.TabIndex = 25;
            label32.Text = "End Time :";
            // 
            // txtTimerAppId
            // 
            txtTimerAppId.Location = new Point(22, 57);
            txtTimerAppId.Name = "txtTimerAppId";
            txtTimerAppId.Size = new Size(100, 23);
            txtTimerAppId.TabIndex = 11;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label30.Location = new Point(22, 21);
            label30.Name = "label30";
            label30.Size = new Size(46, 15);
            label30.TabIndex = 10;
            label30.Text = "AppId :";
            // 
            // IronPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 452);
            Controls.Add(mainTabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "IronPanel";
            Text = "Iron Flow";
            Load += Form1_Load;
            mainTabControl.ResumeLayout(false);
            tracking.ResumeLayout(false);
            tracking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)T_trackinViewResult).EndInit();
            transfer.ResumeLayout(false);
            transfer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)T_transferGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            wfHistoryTab.ResumeLayout(false);
            wfHistoryTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)wfHistoryGridView).EndInit();
            commonTab.ResumeLayout(false);
            commonTab.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)common_users_grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)common_examinersandlb_view).EndInit();
            queryTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)queryResultGridView).EndInit();
            flush.ResumeLayout(false);
            flush.PerformLayout();
            configuration.ResumeLayout(false);
            configuration.PerformLayout();
            tabTimer.ResumeLayout(false);
            tabTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridTimerView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tracking;
        private TabPage transfer;
        private TabPage flush;
        private TabPage configuration;
        private Label label1;
        private Button connectBtn;
        private TextBox connectionStringTxt;
        private Label Configstatus;
        private Button startBtn;
        private TextBox tokenTxt;
        private Label label2;
        private Label label3;
        private LinkLabel dev;
        private LinkLabel qaHang;
        private LinkLabel devPerformance;
        private LinkLabel localHangfire;
        private CheckBox T_isMainCheck;
        private TextBox Tracking_appIdTxt;
        private TextBox T_applicationIdTxt;
        private Label label5;
        private Label label4;
        private CheckBox T_showAssociatesCheck;
        private DataGridView T_trackinViewResult;
        private Button T_clearBtn;
        private Button T_submitBtn;
        private Label label6;
        private Button config_disconnectBtn;
        private Label T_appIdLbl;
        private TextBox transfer_appId_txt;
        private Label label8;
        private Label label7;
        private CheckBox T_associates_check;
        private CheckBox T_individual_check;
        private Panel panel1;
        private Label label9;
        private RadioButton T_all_radio;
        private Label label10;
        private TextBox T_taskId_txt;
        private TextBox T_taskStatus_txt;
        private Label label11;
        private Label label12;
        private Label label13;
        private CheckBox T_isTimerCheck;
        private Label label14;
        private ComboBox T_roleId;
        private ComboBox T_appstatus;
        private Label label15;
        private TextBox T_EndTime_txt;
        private Button T_startBtn;
        private CheckBox T_endTime_check;
        private Label label16;
        private DataGridView T_transferGridView;
        private Label label17;
        private TextBox T_wfitemType_txt;
        private Label label18;
        private Button transfer_previewBtn;
        private Label label19;
        private Button transfer_starOverBtn;
        private Button Transfer_unlockTaskBtn;
        private TabPage wfHistoryTab;
        private Label history_appId_lbl;
        private TextBox history_appId_txt;
        private Label label20;
        private DataGridView wfHistoryGridView;
        private Label label21;
        private Label shortLbl;
        private RadioButton config_custom_check;
        private RadioButton config_local_check;
        private RadioButton config_qa_check;
        private RadioButton config_dev_check;
        private TabPage commonTab;
        private TextBox common_appId_txt;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private DataGridView common_examinersandlb_view;
        private Splitter splitter1;
        private Label label26;
        private Panel panel2;
        private DataGridView common_users_grid;
        private Button common_assignBtn;
        private TextBox common_licBoardId_txt;
        private TextBox common_examinerId_txt;
        private Button common_startOverBtn;
        private TextBox common_userSearch_txt;
        private TabPage queryTab;
        private DataGridView queryResultGridView;
        private RichTextBox querySource;
        private Label label27;
        private CheckBox checkITS;
        private Button btn_transfer;
        private RadioButton radioFB;
        private TabPage tabTimer;
        private TextBox txtTimerAppId;
        private Label label30;
        private Label label31;
        private Button btnTimerStart;
        private TextBox txtTimerEndTime;
        private Label label32;
        private DataGridView gridTimerView;
        private Button btnTimerClear;
        private LinkLabel fbLabel;
        private Button btnLogOut;
        private TextBox timerWfTypeTxt;
        private Label label28;
        private RadioButton qaZcaler;
    }
}