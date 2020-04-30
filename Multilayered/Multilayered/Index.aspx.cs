using BusinessLogicLayer.Implementations;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
namespace Multilayered
{
    public partial class Index : System.Web.UI.Page
    {
        UserManagement userm = new UserManagement();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                GetAll();
            }   
        }
        public void GetAll()
        {
            GridView1.DataSource= userm.Read();
            GridView1.DataBind();


        }

        protected void newuser_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddUser.aspx");
        }
    }

}
