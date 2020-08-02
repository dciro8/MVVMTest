using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMTest.ViewModels
{
  public  class LoginViewModel:BaseViewModel
    {
        #region Attributes
        private string email;
        private string password;
        #endregion

        #region Propertis
        public string EmailText
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }
        public string PasswordText
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }
        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get { 
                return new RelayCommand(Login); 
            }
        }

        private void Login()
        {
            if (EmailText.ToString() == "" && password.ToString() == "")
            {
                Application.Current.MainPage.DisplayAlert("Correct", "Logrado", "Ok");
            }
            else {
                Application.Current.MainPage.DisplayAlert("Incorrecto", "No Logrado", "Cancel");
            }

        }
        #endregion
        #region Constructor

        #endregion
    }
}
