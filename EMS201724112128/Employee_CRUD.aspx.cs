using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMS201724112128
{
    public partial class Employee_CRUD1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ShowData();
            }
            if ((String)Session["Type"] == "employee" || Session["Type"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }
        String sqlconn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\\Message.mdf';";
        void ShowData()
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = sqlconn;
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                GridView1.DataSource = dr;
                GridView1.DataBind();
                cn.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = sqlconn;
                    cn.Open();
                    string sqlstr = "INSERT INTO Employee(EmployeeId,EmployeePassword,EmployeeName,EmployeePhone,IfManager,EmployeeBelongDep) " +
                    "VALUES(@id,@pw,@name,@phone,@ifm,@dep)";
                    SqlCommand cmd = new SqlCommand(sqlstr, cn);
                    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@pw", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NChar));
                    cmd.Parameters.Add(new SqlParameter("@phone", SqlDbType.Char));
                    cmd.Parameters.Add(new SqlParameter("@ifm", SqlDbType.Bit));
                    cmd.Parameters.Add(new SqlParameter("@dep", SqlDbType.Int));
                    cmd.Parameters["@id"].Value = EmpNum_Tb.Text;
                    cmd.Parameters["@pw"].Value = EmpPas_TB.Text;
                    cmd.Parameters["@name"].Value = EmpNam_TB.Text;
                    cmd.Parameters["@phone"].Value = EmpPho_TB.Text;
                    cmd.Parameters["@ifm"].Value = Convert.ToByte(IfMan_RB.SelectedValue);
                    cmd.Parameters["@dep"].Value = EmpDep_TB.Text;
                    cmd.ExecuteNonQuery();
                    ShowData();
                    cn.Close();
                }
                Label1.Text = "插入成功";
            }
            catch
            {
                Label1.Text = "操作错误";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = sqlconn;
                    cn.Open();
                    string sqlstr = string.Format("DELETE FROM Employee " + "WHERE EmployeeId=@id");
                    SqlCommand cmd = new SqlCommand(sqlstr, cn);
                    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                    cmd.Parameters["@id"].Value = EmpNum_Tb.Text;
                    cmd.ExecuteNonQuery();
                    ShowData();
                    Label1.Text = "删除成功";
                    cn.Close();
                }
            }
            catch
            {
                Label1.Text = "请先删除【设备管理员/部门主管】身份";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = sqlconn;
                    cn.Open();
                    string sqlstr = "UPDATE Employee SET EmployeePassword=@pw,EmployeeName=@name,EmployeePhone=@phone,IfManager=@ifm,EmployeeBelongDep=@dep WHERE EmployeeId=@id";
                    SqlCommand cmd = new SqlCommand(sqlstr, cn);
                    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@pw", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NChar));
                    cmd.Parameters.Add(new SqlParameter("@phone", SqlDbType.Char));
                    cmd.Parameters.Add(new SqlParameter("@ifm", SqlDbType.Bit));
                    cmd.Parameters.Add(new SqlParameter("@dep", SqlDbType.Int));
                    cmd.Parameters["@id"].Value = EmpNum_Tb.Text;
                    cmd.Parameters["@pw"].Value = EmpPas_TB.Text;
                    cmd.Parameters["@name"].Value = EmpNam_TB.Text;
                    cmd.Parameters["@phone"].Value = EmpPho_TB.Text;
                    cmd.Parameters["@ifm"].Value = Convert.ToByte(IfMan_RB.SelectedValue);
                    cmd.Parameters["@dep"].Value = EmpDep_TB.Text;
                    cmd.ExecuteNonQuery();
                    ShowData();
                    cn.Close();
                }
                Label1.Text = "修改成功";
            }
            catch
            {
                Label1.Text = "操作错误";
            }
        }
    }
}