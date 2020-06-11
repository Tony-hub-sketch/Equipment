using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMS201724112128
{
    public partial class Search_EquNum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((String)Session["Type"] == "admin" || Session["Type"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string keywordstr = TextBox1.Text;
            int keyword = Convert.ToInt32(keywordstr);
            StringBuilder sb = new StringBuilder();
            MessageEntities db = new MessageEntities();
            var result = from m in db.Equipment
                         join m1 in db.Employee on m.EquipmentManager equals m1.EmployeeId
                         join m2 in db.Department on m1.EmployeeBelongDep equals m2.DepartmentId
                         where m.EquipmentId == keyword
                         select new {
                             设备编号 = m.EquipmentId,
                             设备名称 = m.EquipmentName,
                             购买日期 = m.DatePurchase,
                             存放位置 = m.StorageLocation,
                             设备负责人 = m1.EmployeeName,
                             所属部门 = m2.DepartmentName
                         };
            GridView1.DataSource = result.ToList();
            GridView1.DataBind();
            if(result.Count()==0){
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