using PrismTest.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Prism.Mvvm;

namespace PrismTest.ViewModels
{
    class LoginVM: BindableBase
    {
        private Login login;
        public LoginVM()
        {
            login = new Login();    
            if(login.Username == "aremu" && login.Password == "adebola")
            {
                login.Valid = true;
            }
            //login.Username = "aremu";
            //login.Password = "adebola";
        }
        public Login LoginP
        {
            get { return login; }
            set { SetProperty(ref login, value); }           
        }

      
    }
}
