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
    public partial class Department_CRUD : System.Web.UI.Page
    {
        String sqlconn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\\Message.mdf';";
        void ShowData()
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = sqlconn;
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Department", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                GridView1.DataSource = dr;
                GridView1.DataBind();
                cn.Close();
            }
        }
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = sqlconn;
                    cn.Open();
                    string sqlstr = "INSERT INTO Department(DepartmentId,DepartmentName,DepartmentManager)" +
                    "VALUES(@id,@name,@admin)";
                    SqlCommand cmd = new SqlCommand(sqlstr, cn);
                    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NChar));
                    cmd.Parameters.Add(new SqlParameter("@admin", SqlDbType.Int));
                    cmd.Parameters["@id"].Value = DepNum_Tb.Text;
                    cmd.Parameters["@name"].Value = DepNam_TB.Text;
                    cmd.Parameters["@admin"].Value = DepMan_TB.Text;
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
                    string sqlstr = string.Format("DELETE FROM Department " + "WHERE DepartmentId=@id");
                    SqlCommand cmd = new SqlCommand(sqlstr, cn);
                    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                    cmd.Parameters["@id"].Value = DepNum_Tb.Text;
                    cmd.ExecuteNonQuery();
                    ShowData();
                    cn.Close();
                }
                Label1.Text = "删除成功";
            }
            catch
            {
                Label1.Text = "操作错误";
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
                    string sqlstr = "UPDATE Department SET DepartmentName=@name,DepartmentManager=@admin WHERE DepartmentId=@id";
                    SqlCommand cmd = new SqlCommand(sqlstr, cn);
                    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NChar));
                    cmd.Parameters.Add(new SqlParameter("@admin", SqlDbType.Int));
                    cmd.Parameters["@id"].Value = DepNum_Tb.Text;
                    cmd.Parameters["@name"].Value = DepNam_TB.Text;
                    cmd.Parameters["@admin"].Value = DepMan_TB.Text;
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