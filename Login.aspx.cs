using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DGApp.Objects;
using DGApp.Business_Layer;

namespace DGApp
{
    public partial class Login : System.Web.UI.Page
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        private Customer _customerInfo;

        protected void Page_Load(object sender, EventArgs e)
        {
            lblStatus.Visible = false;
            lblStatus.InnerText = "";
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            UserName = txtUsername.Value;
            Password = txtPassword.Value;
            LoginData();
        }

        protected bool isInputValid()
        {
            if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password))
            {
                return true;
            }
            return false;
        }

        protected void LoginData()
        {
            if (isInputValid())
            {
                LoginInfo _loginInfo = new LoginInfo();
                _customerInfo = _loginInfo.Login(UserName, Password);
                if (_customerInfo.CustomerID != null && _customerInfo.CustomerID > 0)
                {
                    Response.Redirect("http://www.google.com");
                }
                else
                {
                    lblStatus.Visible = true;
                    lblStatus.InnerText = "Invalid Credentails ! Please try again.";
                }
            }
        }
    }
}