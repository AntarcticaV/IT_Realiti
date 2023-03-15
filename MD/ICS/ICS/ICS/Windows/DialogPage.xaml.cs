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
	public partial class DialogPage : ContentPage
	{
		public DialogPage ()
		{
			InitializeComponent ();
        }

        private void OnClickedSendButton(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(InputEntry.Text))
            {
                if (InputEntry.Text[0] == ' ')
                    InputEntry.Text.Trim();

                MassageScroll.Children.Add(new Frame()
                {
                    BackgroundColor = Color.Black,
                    CornerRadius = 60,
                    HorizontalOptions = LayoutOptions.End,
                    Content = new Label()
                    {
                        Text = InputEntry.Text,
                        TextColor = Color.White,
                    }
                });
            }
            InputEntry.Text = "";

        }

    }
}