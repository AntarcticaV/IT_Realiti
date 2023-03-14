using ICS.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ICS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnButtonClickedSigIn(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Tabbed());
        }
    }
}
