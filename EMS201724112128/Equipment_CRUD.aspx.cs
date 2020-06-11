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
    public partial class Equipment_CRUD : System.Web.UI.Page
    {
        String sqlconn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\\Message.mdf';";
        void ShowData()
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = sqlconn;
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Equipment", cn);
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
                    string sqlstr = "INSERT INTO Equipment(EquipmentId,EquipmentName,EquipmentSpecs,EquipmentPrice,DatePurchase,StorageLocation,EquipmentManager)" +
                    "VALUES(@id,@name,@spes,@price,@date,@area,@admin)";
                    SqlCommand cmd = new SqlCommand(sqlstr, cn);
                    cmd.Parameters.Add(new SqlParameter("@id",SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NChar));
                    cmd.Parameters.Add(new SqlParameter("@spes", SqlDbType.NVarChar));
                    cmd.Parameters.Add(new SqlParameter("@price", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@date", SqlDbType.Date));
                    cmd.Parameters.Add(new SqlParameter("@area", SqlDbType.NChar));
                    cmd.Parameters.Add(new SqlParameter("@admin", SqlDbType.Int));
                    cmd.Parameters["@id"].Value = EquNum_Tb.Text;
                    cmd.Parameters["@name"].Value = EquNam_TB.Text;
                    cmd.Parameters["@spes"].Value = EquSiz_TB.Text;
                    cmd.Parameters["@price"].Value = EquPri_TB.Text;
                    cmd.Parameters["@date"].Value = BuyDat_TB.Text;
                    cmd.Parameters["@area"].Value = EquSto_TB.Text;
                    cmd.Parameters["@admin"].Value = EquMan_TB.Text;
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
                    string sqlstr = string.Format("DELETE FROM Equipment " + "WHERE EquipmentId=@id");
                    SqlCommand cmd = new SqlCommand(sqlstr, cn);
                    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                    cmd.Parameters["@id"].Value = EquNum_Tb.Text;
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
                    string sqlstr = "UPDATE Equipment SET EquipmentName=@name,EquipmentSpecs=@spes,EquipmentPrice=@price,DatePurchase=@date,StorageLocation=@area,EquipmentManager=@admin WHERE EquipmentId=@id";
                    SqlCommand cmd = new SqlCommand(sqlstr, cn);
                    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NChar));
                    cmd.Parameters.Add(new SqlParameter("@spes", SqlDbType.NVarChar));
                    cmd.Parameters.Add(new SqlParameter("@price", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@date", SqlDbType.Date));
                    cmd.Parameters.Add(new SqlParameter("@area", SqlDbType.NChar));
                    cmd.Parameters.Add(new SqlParameter("@admin", SqlDbType.Int));
                    cmd.Parameters["@id"].Value = EquNum_Tb.Text;
                    cmd.Parameters["@name"].Value = EquNam_TB.Text;
                    cmd.Parameters["@spes"].Value = EquSiz_TB.Text;
                    cmd.Parameters["@price"].Value = EquPri_TB.Text;
                    cmd.Parameters["@date"].Value = BuyDat_TB.Text;
                    cmd.Parameters["@area"].Value = EquSto_TB.Text;
                    cmd.Parameters["@admin"].Value = EquMan_TB.Text;
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