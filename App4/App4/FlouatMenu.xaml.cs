using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlouatMenu : ContentPage
    {
        public FlouatMenu()
        {
            InitializeComponent();
        }

        private void pipo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }
    }
}