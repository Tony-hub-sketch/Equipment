using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMS201724112128
{
    public partial class Employee_Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string keywordstr = TextBox1.Text;
            StringBuilder sb = new StringBuilder();
            if (DropDownList1.SelectedValue == "员工编号")
            {
                int keyword = Convert.ToInt32(keywordstr);
                MessageEntities db = new MessageEntities();
                var result = from m in db.Employee
                             where m.EmployeeId == keyword
                             select new
                             {
                                 员工编号 = m.EmployeeId,
                                 员工姓名 = m.EmployeeName,
                                 联系电话 = m.EmployeePhone,
                                 所属部门=m.EmployeePhone,
                                 是否为管理人=m.IfManager
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
            else if (DropDownList1.SelectedValue == "员工姓名")
            {
                MessageEntities db = new MessageEntities();
                var result = from m in db.Employee
                             where m.EmployeeName == keywordstr
                             select new
                             {
                                 员工编号 = m.EmployeeId,
                                 员工姓名 = m.EmployeeName,
                                 联系电话 = m.EmployeePhone,
                                 所属部门 = m.EmployeePhone,
                                 是否为管理人 = m.IfManager
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
            else if(DropDownList1.SelectedValue == "联系电话")
            {
                MessageEntities db = new MessageEntities();
                var result = from m in db.Employee
                             where m.EmployeePhone == keywordstr
                             select new
                             {
                                 员工编号 = m.EmployeeId,
                                 员工姓名 = m.EmployeeName,
                                 联系电话 = m.EmployeePhone,
                                 所属部门 = m.EmployeePhone,
                                 是否为管理人 = m.IfManager
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
            else if (DropDownList1.SelectedValue == "所属部门")
            {
                int keyword = Convert.ToInt32(keywordstr);
                MessageEntities db = new MessageEntities();
                var result = from m in db.Employee
                             where m.EmployeeBelongDep == keyword
                             select new
                             {
                                 员工编号 = m.EmployeeId,
                                 员工姓名 = m.EmployeeName,
                                 联系电话 = m.EmployeePhone,
                                 所属部门 = m.EmployeePhone,
                                 是否为管理人 = m.IfManager
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
                sb.Append("");
                Label1.Text = sb.ToString();
                if (keywordstr=="Y"|| keywordstr == "y"|| keywordstr=="1")
                {
                    Boolean keyword = true;
                    MessageEntities db = new MessageEntities();
                    var result = from m in db.Employee
                                 where m.IfManager == keyword
                                 select new
                                 {
                                     员工编号 = m.EmployeeId,
                                     员工姓名 = m.EmployeeName,
                                     联系电话 = m.EmployeePhone,
                                     所属部门 = m.EmployeeBelongDep,
                                     是否为管理人 = m.IfManager
                                 };
                    GridView1.DataSource = result.ToList();
                    GridView1.DataBind();
                }
                else if(keywordstr == "N" || keywordstr == "n" || keywordstr == "0")
                {
                    Boolean keyword = false;
                    MessageEntities db = new MessageEntities();
                    var result = from m in db.Employee
                                 where m.IfManager == keyword
                                 select new
                                 {
                                     员工编号 = m.EmployeeId,
                                     员工姓名 = m.EmployeeName,
                                     联系电话 = m.EmployeePhone,
                                     所属部门 = m.EmployeeBelongDep,
                                     是否为管理人 = m.IfManager
                                 };
                    GridView1.DataSource = result.ToList();
                    GridView1.DataBind();
                }
                else
                {
                    sb.Append("查无信息!");
                    Label1.Text = sb.ToString();
                }
            }
        }
    }
}