using Hackathon.CoordinationNotes.Service.interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hackathon.CoordinationNotes.Service.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CoordinationNotesController : ControllerBase
	{
		private readonly IBlobService _blobService;
		public CoordinationNotesController(IBlobService blobService)
		{
			_blobService = blobService;
		}


		[HttpGet("{blobName}")]
		public async Task<IActionResult> GetBlob(string blobName)
		{

			if(blobName == null)
			{
				return Ok();
			}
			var data = await _blobService.GetBlobAsync(blobName);

			return File(data.Content.ToStream(), data.Details.ContentType);
		}
		
	}
}
