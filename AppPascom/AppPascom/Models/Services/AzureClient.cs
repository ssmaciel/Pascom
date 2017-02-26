using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace AppPascom
{
	public class AzureClient
	{
		private IMobileServiceClient _client;
		private IMobileServiceTable<Post> _table;
		private const string serviceUri = "http://pascon.azurewebsites.net";
		public AzureClient()
		{
			_client = new MobileServiceClient(serviceUri);

			_table = _client.GetTable<Post>();
		}

		public async Task<IEnumerable<Post>> GetPosts()
		{
			var empty = new Post[0];
			try
			{
				return await _table.ToEnumerableAsync();
			}
			catch (Exception ex)
			{
				return empty;
			}
		}

		public async void AddPost(Post post)
		{
			await _table.InsertAsync(post);
		}

		public async void UpdatePost(Post post)
		{
			await _table.UpdateAsync(post);
		}

		public async void DeletePost(Post post)
		{
			await _table.DeleteAsync(post);
		}


	}
}
