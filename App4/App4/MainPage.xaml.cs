using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App4;
using App4.DataBase;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private  void BtnLogin_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Login.Text) || string.IsNullOrEmpty(Password.Text))
            {
                DisplayAlert("Ошибка авторизации", "Заполните поля", "Закрыть");
            }
            else
            {
            var user = App.Db.GetUser(Login.Text, Password.Text);
            if (user != null)
            {
                 Navigation.PushModalAsync(new Page1(user));
            }
            else
            {
                 DisplayAlert("Ошибка авторизации", "Неверный логин или пароль", "Закрыть");
            }

            }
        }

        private  void BtnReg_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Rgist());
        }
        
    }
}
