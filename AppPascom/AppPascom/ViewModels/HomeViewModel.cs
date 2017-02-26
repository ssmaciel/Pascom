using System;
using System.Collections.ObjectModel;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices.Sync;
using Xamarin.Forms;

namespace AppPascom
{
	public class HomeViewModel : ObservableBaseObject
	{
		public ObservableCollection<Post> Posts { get; set; }
		private AzureClient _client;
		public Command RefreshCommand { get; set; }
		public Command GenerateContactsCommand { get; set; }
		private bool isBusy;
		public bool IsBusy
		{
			get { return isBusy; }
			set { isBusy = value; OnPropertyChanged(); }
		}

		public HomeViewModel()
		{
			RefreshCommand = new Command(() => Load());
			Posts = new ObservableCollection<Post>();
			_client = new AzureClient();
			//var result =  _client.GetPosts();
			//if (result != null)
			//{
			//	var ret = result.Result;
			//	if (ret != null)
			//	{
			//		Posts = new ObservableCollection<Post>(ret);
			//	}
			//}
			Load();
		}


		public async void Load()
		{
			var result = await _client.GetPosts();

			Posts.Clear();

			foreach (var item in result)
			{
				Posts.Add(item);
			}
			IsBusy = false;
		}
	}
}
