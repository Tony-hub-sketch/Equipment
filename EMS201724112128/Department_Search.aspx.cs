using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMS201724112128
{
    public partial class Department_Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((String)Session["Type"] == "employee" || Session["Type"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string keywordstr = TextBox1.Text;
            StringBuilder sb = new StringBuilder();
            if (DropDownList1.SelectedValue == "部门编号")
            {
                int keyword = Convert.ToInt32(keywordstr);
                MessageEntities db = new MessageEntities();
                var result = from m in db.Department
                             where m.DepartmentId == keyword
                             select new
                             {
                                 部门编号 = m.DepartmentId,
                                 部门名称 = m.DepartmentName,
                                 部门主管 = m.DepartmentManager
                             };
                GridView1.DataSource = result.ToList();
                GridView1.DataBind();
                if (result.Count() == 0)
                {
                    sb.Append("查无信息!");
                    Label1.Text = sb.ToString();
                }
                else
                {
                    sb.Append("");
                    Label1.Text = sb.ToString();
                }
            }
            else if (DropDownList1.SelectedValue == "部门名称")
            {
                MessageEntities db = new MessageEntities();
                var result = from m in db.Department
                             where m.DepartmentName == keywordstr
                             select new
                             {
                                 部门编号 = m.DepartmentId,
                                 部门名称 = m.DepartmentName,
                                 部门主管 = m.DepartmentManager
                             };
                GridView1.DataSource = result.ToList();
                GridView1.DataBind();
                if (result.Count() == 0)
                {
                    sb.Append("查无信息!");
                    Label1.Text = sb.ToString();
                }
                else
                {
                    sb.Append("");
                    Label1.Text = sb.ToString();
                }
            }
            else
            {
                int keyword = Convert.ToInt32(keywordstr);
                MessageEntities db = new MessageEntities();
                var result = from m in db.Department
                             where m.DepartmentManager == keyword
                             select new
                             {
                                 部门编号 = m.DepartmentId,
                                 部门名称 = m.DepartmentName,
                                 部门主管 = m.DepartmentManager
                             };
                GridView1.DataSource = result.ToList();
                GridView1.DataBind();
                if (result.Count() == 0)
                {
                    sb.Append("查无信息!");
                    Label1.Text = sb.ToString();
                }
                else
                {
                    sb.Append("");
                    Label1.Text = sb.ToString();
                }
            }
        }
    }
}