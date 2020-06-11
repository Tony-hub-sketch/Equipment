using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMS201724112128
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TestLabel.Text = "";
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;//Unobtrusive ValidationMode是一种隐式的验证方式，需要前端调用jquery来进行身份验证。且默认启用。
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                String sqlconn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\\Message.mdf';";
                SqlConnection myConnection = new SqlConnection(sqlconn);
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand("select EmployeeId,EmployeePassword,IfManager,EmployeeName from Employee", myConnection);
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    for (int i = 0; i < myReader.FieldCount; i++)
                    {
                        if (myReader[0].ToString().Equals(UserNumTextBox.Text) && myReader[1].ToString().Equals(PasswordTextBox.Text) && myReader[2].Equals(bool.Parse(TypeRadioButtonList.SelectedValue)) && myReader[2].Equals(true))
                        {
                            Session["Name"] = myReader[3].ToString();
                            Session["Type"] = "admin";
                            Response.Redirect("Admin.aspx?EmployeeName=" + UserNumTextBox.Text);//管理员
                        }
                        else if (myReader[0].ToString().Equals(UserNumTextBox.Text) && myReader[1].ToString().Equals(PasswordTextBox.Text) && myReader[2].Equals(bool.Parse(TypeRadioButtonList.SelectedValue)) && myReader[2].Equals(false))
                        {
                            Session["Name"] = myReader[3].ToString();
                            Session["Type"] = "employee";
                            Response.Redirect("Employee.aspx");//普通员工
                        }
                        else
                        {
                            TestLabel.Text = "登录失败";
                        }
                    }
                }
            }
            catch
            {
                TestLabel.Text = "登录失败";
            }
        }
    }
}