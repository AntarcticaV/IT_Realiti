using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ICS.Windows
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SingUpPage : ContentPage
	{
		public SingUpPage ()
		{
			InitializeComponent ();
		}

        private async void OnClickedSaveUserButton(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Tabbed());
        }

        private async void OnClickedBackButton(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

    }
}