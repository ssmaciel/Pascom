using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppPascom
{
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();
			BindingContext = new HomeViewModel();
		}
	}
}
