using System;
using System.Collections.Generic;
using System.Linq;
using DGApp.Objects;
using System.Web;
using DGApp.Data_Layer;

namespace DGApp.Business_Layer
{
    public class LoginInfo
    {
        private Customer _customerInfo;
        private Animal _animalInfo;

        public Customer Login(string username, string passsword)
        {
            _customerInfo = new Customer();
            passsword = EncodeTo64(passsword);
            LoginDAL _loginDAL = new LoginDAL();
            _customerInfo = _loginDAL.CheckCredentials(username, passsword);

            return _customerInfo;

        }

        public bool SaveData(Customer _customerInfo, Animal _animalInfo)
        {
            try
            {
                _customerInfo.Password = EncodeTo64(_customerInfo.Password);
                LoginDAL _loginDAL = new LoginDAL();
               return _loginDAL.SaveData(_customerInfo, _animalInfo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }


        /// <summary>
        /// Encodes the to64.
        /// </summary>
        /// <param name="toEncode">To encode.</param>
        /// <returns></returns>
        public static string EncodeTo64(string toEncode)
        {
            byte[] toEncodeAsBytes = System.Text.Encoding.UTF8.GetBytes(toEncode);

            string returnValue = System.Convert.ToBase64String(toEncodeAsBytes);

            return returnValue;
        }

    }
}