using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App4.DataBase;

namespace App4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Rgist : ContentPage
    {
        public Rgist()
        {
            InitializeComponent();
        }
        private  void BtnReg_Clicked(object sender, EventArgs e)
        {
            User user = new User()
            {
                Login = ELogin.Text,
                Password = EPassword.Text
            };
            App.Db.SaveUser(user);
            DisplayAlert("Регистрация", "Всё ОК", "Закрыть");
            Navigation.PushModalAsync(new MainPage());
        }
    }
}