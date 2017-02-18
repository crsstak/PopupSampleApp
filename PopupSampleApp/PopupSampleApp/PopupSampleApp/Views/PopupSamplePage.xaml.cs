using System;
using Xamarin.Forms;

namespace PopupSampleApp.Views
{
	public partial class PopupSamplePage : ContentPage
	{
		public PopupSamplePage()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, EventArgs e)
		{
			stackLayout.IsVisible = true;
			popup.IsVisible = true;
		}

		private void stackLayout_Tapped(object sender, TappedEventArgs e)
		{
			stackLayout.IsVisible = false;
			popup.IsVisible = false;
		}
	}
}
