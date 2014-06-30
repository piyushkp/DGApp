using DGApp.Business_Layer;
using DGApp.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DGApp
{
    public partial class Register : System.Web.UI.Page
    {
        private Customer _customerInfo;
        private Animal _animalInfo;

        protected void Page_Load(object sender, EventArgs e)
        {
            lblStatus.Visible = false;
            lblStatus.InnerText = "";
        }
        protected void Register_Click(object sender, EventArgs e)
        {
            _customerInfo = new Customer();
            _animalInfo = new Animal();
            SaveDate();            
        }

        private void SaveDate()
        {
            try
            {
                bool isSaved = false;
                if (isInputValid())
                {
                    LoginInfo _loginInfo = new LoginInfo();
                    isSaved = _loginInfo.SaveData(_customerInfo, _animalInfo);
                    if (isSaved)
                    {
                        Response.Redirect("/Login.aspx");
                    }
                }
            }
            catch (Exception ex)
            {
                //error page;
            }
        }

        private bool isInputValid()
        {
            bool _isvalid = true; ;
            if (!string.IsNullOrEmpty(txtUsername.Value))
            {
                _customerInfo.UserName = txtUsername.Value;
            }
            else
            {
                lblStatus.InnerText = "Please enter valid Username";
                _isvalid = false;
            }
            if (!string.IsNullOrEmpty(txtFirstname.Value))
            {
                _customerInfo.FirstName = txtFirstname.Value;
            }
            else
            {
                lblStatus.InnerText = "Please enter valid First Name";
                _isvalid = false;
            }
            if (!string.IsNullOrEmpty(txtLastname.Value))
            {
                _customerInfo.LastName = txtLastname.Value;
            }
            else
            {
                lblStatus.InnerText = "Please enter valid Last Name";
                _isvalid = false;
            }
            if (!string.IsNullOrEmpty(txtEmail.Value))
            {
                _customerInfo.Email = txtEmail.Value;
            }
            else
            {
                lblStatus.InnerText = "Please enter valid Email";
                _isvalid = false;
            }
            if (!string.IsNullOrEmpty(txtPhone.Value))
            {
                _customerInfo.Phone = txtPhone.Value;
            }
            else
            {
                lblStatus.InnerText = "Please enter valid Phone";
                _isvalid = false;
            }
            if (!string.IsNullOrEmpty(txtPassword.Value) && !string.IsNullOrEmpty(txtConfirmPassword.Value))
            {
                if (txtConfirmPassword.Value == txtPassword.Value)
                {
                    _customerInfo.Password = txtPassword.Value;
                }
                else
                {
                    lblStatus.InnerText = "Passwords are not same";
                    _isvalid = false;
                }
            }
            else
            {
                lblStatus.InnerText = "Please enter valid Password";
                _isvalid = false;
            }
            if (!string.IsNullOrEmpty(txtPetname.Value))
            {
                _animalInfo.Name = txtPetname.Value;
            }
            else
            {
                lblStatus.InnerText = "Please enter valid Pet name";
                _isvalid = false;
            }

            if (!string.IsNullOrEmpty(lblselectpetCategory.Items[lblselectpetCategory.SelectedIndex].ToString()))
            {
                _animalInfo.Category = lblselectpetCategory.Items[lblselectpetCategory.SelectedIndex].ToString();
            }
            else
            {
                lblStatus.InnerText = "Please enter valid Pet Category";
                _isvalid = false;
            }

            if (!string.IsNullOrEmpty(txtBreed.Value))
            {
                _animalInfo.Breed = txtBreed.Value;
            }
            else
            {
                lblStatus.InnerText = "Please enter valid Breed";
                _isvalid = false;
            }

            if (!string.IsNullOrEmpty(txtDateBorn.Value))
            {
                _animalInfo.DateBorn = txtDateBorn.Value;
            }
            else
            {
                lblStatus.InnerText = "Please enter valid Date Born";
                _isvalid = false;
            }
            if (!string.IsNullOrEmpty(lblselectpetGender.Items[lblselectpetGender.SelectedIndex].ToString()))
            {
                _animalInfo.Gender = lblselectpetGender.Items[lblselectpetGender.SelectedIndex].ToString();
            }
            else
            {
                lblStatus.InnerText = "Please enter valid Pet Gender";
                _isvalid = false;
            }

            return _isvalid;
        }
    }
}