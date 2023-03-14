using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using NativeMedia;
using System.Threading;

namespace ICS.Windows
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Profile : ContentPage
	{
		public Profile ()
		{
			InitializeComponent ();
		}

        private async void OnImageChange(object sender, System.EventArgs e)
        {
            var pickImage = await FilePicker.PickAsync(new PickOptions
            {
                FileTypes = FilePickerFileType.Images,
                PickerTitle = "Выберете картинку"
            });

            if (pickImage != null)
            {
                NameImageLabel.Text = pickImage.FileName;
                NameImageLabel.IsVisible = true;
                //image.IsAnimationPlaying = false;
                //image.Source = ImageSource.FromFile(pickImage.FullPath);
            }
        }


    }

    

}