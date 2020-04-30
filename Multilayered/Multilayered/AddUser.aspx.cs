using BusinessLogicLayer.Implementations;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Multilayered
{
    public partial class AddUser : System.Web.UI.Page
    {
        UserManagement userm = new UserManagement();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddUser_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName = txtUsername.Value.ToString();
            user.Password = txtPassword.Value.ToString();
            user.FirstName = txtFirstname.Value.ToString();
            user.LastName = txtLastName.Value.ToString();
            user.Hobby = txtHobby.Value.ToString();
            user.isActive = true;
            if (userm.Create(user))
            {
                Response.Write("<script>alert('User Added');</script>");
                Response.Redirect("index.aspx");
            }
        }
    }
}