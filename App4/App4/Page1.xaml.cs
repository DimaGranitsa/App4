using System;
using System.Collections;
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
    public partial class Page1 : FlyoutPage
    {
        private  static User currentUser;
        public Page1(User user)
        {
            InitializeComponent();
            currentUser = user;
            floyaut.listview.ItemSelected += OnSelectedItem;
        }

        private void OnSelectedItem(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as FL;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetPage));
                floyaut.listview.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}