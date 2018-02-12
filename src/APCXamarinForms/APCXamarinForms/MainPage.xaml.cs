using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace APCXamarinForms
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            btn_Next.Clicked += Button_Clicked;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new Page2());
        }
    }
}
