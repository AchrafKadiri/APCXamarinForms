using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APCXamarinForms
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();
            btn_Previous.Clicked += Button_Clicked;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            Navigation.PopToRootAsync();
        }
    }
}