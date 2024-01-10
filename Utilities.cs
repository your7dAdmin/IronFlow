using IronFlow.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace IronFlow
{
    public class Utilities
    {
        public Utilities()
        {

        }

        public void UpdateExaminerAndLicBoard(int appId, int examinerId, int licBoardId, SqlConnection cnn)
        {
            if (cnn != null && cnn.State == ConnectionState.Open && appId > 0)
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.Parameters.AddWithValue("@appId", appId);
                    //Examiner
                    if (examinerId > 0)
                    {
                        cmd.CommandText = "UPDATE AssignAppExaminer SET ExaminerId = @examinerId WHERE AppId = @appId;";
                        cmd.Parameters.AddWithValue("@examinerId", examinerId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("The Examiner has updated", "Success");
                    }

                    if (licBoardId > 0)
                    {
                        //Licensing Board
                        cmd.CommandText = "UPDATE AssignAppLicBoard SET LicBoardId = @licBoardId WHERE AppId = @appId;";
                        cmd.Parameters.AddWithValue("@licBoardId", licBoardId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("The Licensing Board has updated", "Success");
                    }


                }
            }
            else
            {
                MessageBox.Show("An error has been ocurred", "Error");
                MessageBox.Show("You must to start the connection again", "Warning");
            }
        }

        public DataTable? GetUsersAssignedByAppId(int appId, SqlConnection cnn)
        {
            if (cnn != null && cnn.State == ConnectionState.Open)
            {
                string getUsersQuery = $"SELECT \r\nUserId, UserName AS Email, CONCAT(FirstName, LastName) AS [Name],\r\nIIF(COUNT(A.AppId) > 0, 1, 0) AS IsExaminerAssigned,\r\nIIF(COUNT(L.AppId) > 0, 1, 0) AS IsLicBoardAssigned\r\nFROM [User] U\r\nLEFT JOIN AssignAppExaminer A ON U.UserId = A.ExaminerId\r\nLEFT JOIN AssignAppLicBoard L ON U.UserId = L.LicBoardId\r\nWHERE U.[UserName] IS NOT NULL AND U.IsActive = 1 AND (A.AppId = {appId} OR L.AppId = {appId})\r\nGROUP BY U.UserId, U.UserName, U.FirstName, U.LastName;";
                SqlCommand cmd = new SqlCommand(getUsersQuery, cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            else
            {
                MessageBox.Show("An error has been ocurred", "Error");
                MessageBox.Show("You must to start the connection again", "Warning");
            }

            return null;
        }

        public DataTable? GetUsers(SqlConnection cnn)
        {
            if (cnn != null && cnn.State == ConnectionState.Open)
            {
                string getUsersQuery = $"SELECT UserId, CONCAT(FirstName,' ',LastName) AS [Name], UserName AS Email FROM [User] WHERE [UserName] IS NOT NULL AND IsActive = 1;";
                SqlCommand cmd = new SqlCommand(getUsersQuery, cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }

            return null;
        }

        public bool isNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            return e.Handled;
        }


        public DataTable? ExecuteQuery(string query, SqlConnection cnn)
        {

            if (cnn != null && cnn.State == ConnectionState.Open && !string.IsNullOrWhiteSpace(query))
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            else
            {
                MessageBox.Show("An error has been ocurred", "Error");
                MessageBox.Show("You must to start the connection again", "Warning");
            }

            return null;
        }

        /*
         * TypeId: 1 for roleId and 2 for appStatusId
         */
        public ComboItem SetItemValue(object dataSource, ApplicationBase application, int typeId)
        {
            int currentRoleId = 0;
            int appStatusId = 0;

            ComboItem[] comboItems = (ComboItem[])dataSource;
            ComboItem? result = null;

            if (typeId == 1)
            {

                bool isValidRole = int.TryParse(application.RoleId, out currentRoleId);
                if (!isValidRole) { currentRoleId = 2; }  //system role by default
                result = comboItems.ToList().Find(r => r.ID == currentRoleId);
            }
            else if (typeId == 2)
            {
                bool isValidStatus = int.TryParse(application.AppStatusId, out appStatusId);
                if (!isValidStatus) { appStatusId = 2; }  //intake complete statsus
                result = comboItems.ToList().Find(r => r.ID == appStatusId);
            }

            return result;
        }
    }
}
