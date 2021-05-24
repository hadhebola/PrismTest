using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrismTest.Models
{
    class Login: BindableBase
    {
        private string _Username;
        private string _Password;
        private bool _Valid;
        
        public string Username
        {
            get { return _Username; }
            set { SetProperty(ref _Username, value); }
        }

        public string Password
        {
            get { return _Password; }
            set { SetProperty(ref _Password, value); }
        } 
        
        public bool Valid
        {
            get { return _Valid; }
            set { SetProperty(ref _Valid, value); }
        }
    }
}
