using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TeoGlassForms
{
	public partial class SiteSelectionPage : ContentPage
	{
		public SiteSelectionPage()
		{
			InitializeComponent();

			TestButton.Clicked += TestButton_Clicked;
			PackingButton.Clicked += PackingButton_Clicked;
		}

		void PackingButton_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new MainMenuPage());
		}

		void TestButton_Clicked(object sender, EventArgs e)
		{

		}
	}
}
