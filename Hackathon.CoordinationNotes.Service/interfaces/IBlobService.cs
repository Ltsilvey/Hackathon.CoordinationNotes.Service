using Azure.Storage.Blobs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.CoordinationNotes.Service.interfaces
{
	public interface IBlobService
	{
		public Task<BlobDownloadResult> GetBlobAsync(string name);

		public Task<IEnumerable<string>> ListBlobsAsync();

		public Task UploadFileBlobAsync(string filePath, string fileName);

		public Task UploadContentBlobAsync(string content, string fileName);

		public Task DeleteBlobAsync(string name);
	}
}
