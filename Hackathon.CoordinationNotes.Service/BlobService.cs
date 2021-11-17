using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Hackathon.CoordinationNotes.Service.interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hackathon.CoordinationNotes.Service
{
	internal class BlobService : IBlobService
	{

		private readonly BlobServiceClient _blobServiceClient;

		public BlobService(BlobServiceClient blobServiceClient)
		{
			_blobServiceClient = blobServiceClient;
		}
		public Task DeleteBlobAsync(string name)
		{
			throw new System.NotImplementedException();
		}

		public async Task<BlobDownloadResult> GetBlobAsync(string name)
		{
			var containterClient = _blobServiceClient.GetBlobContainerClient("coordinationnotes");

			var blobClient = containterClient.GetBlobClient(name);

			return await blobClient.DownloadContentAsync();
		}

		public Task<IEnumerable<string>> ListBlobsAsync()
		{
			throw new System.NotImplementedException();
		}

		public Task UploadContentBlobAsync(string content, string fileName)
		{
			throw new System.NotImplementedException();
		}

		public Task UploadFileBlobAsync(string filePath, string fileName)
		{
			throw new System.NotImplementedException();
		}
	}
}