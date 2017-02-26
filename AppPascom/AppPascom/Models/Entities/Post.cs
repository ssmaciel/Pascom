using System;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace AppPascom
{
	[DataTable("Post")]
	public class Post : ObservableBaseObject
	{
		private string _Id;

        [JsonProperty("Id")]
		public string Id
		{
			get { return _Id; }
			set { _Id = value; OnPropertyChanged();}
		}

		private string _FullDescription;
		[JsonProperty("FullDescription")]
		public string FullDescription
		{
			get { return _FullDescription; }
			set { _FullDescription = value; OnPropertyChanged(); }
		}

		private string _ReducedDescription;
		[JsonProperty("ReducedDescription")]
		public string ReducedDescription
		{
			get { return _ReducedDescription; }
			set { _ReducedDescription = value; OnPropertyChanged(); }
		}

		private string _Photo;
		[JsonProperty("Photo")]
		public string Photo
		{
			get { return _Photo; }
			set { _Photo = value; OnPropertyChanged(); }
		}

        [Version]
		public string Version { get; set; }
	}
}
