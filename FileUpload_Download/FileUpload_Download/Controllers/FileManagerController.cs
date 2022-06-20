using FileUpload_Download.Entities;
using FileUpload_Download.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FileUpload_Download.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileManagerController : ControllerBase
    {
        private readonly IFileUploadService _fileService;

        public FileManagerController(IFileUploadService fileService)
        {
            _fileService = fileService;
        }

        [HttpPost]
        public async Task PostAsync([FromForm] FileModel model)
        {
            await _fileService.UploadFileAsync(model);  
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> DownloadFile(int id)
        {
            var s=await _fileService.DownloadFileAsync(id);
            return Ok(s);
        }
     }
}
