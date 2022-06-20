using FileUpload_Download.Entities;
using FileUpload_Download.Repository;
using FileUpload_Download.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FileUpload_Download.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileManagerController : ControllerBase
    {
        private readonly IFileUploadService _fileService;
        private readonly string AppDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
        FileManagerContext dBContext = new FileManagerContext();
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
            if (!Directory.Exists(AppDirectory))
                Directory.CreateDirectory(AppDirectory);

            
            var file = dBContext.FileData.Where(n => n.Id == id).FirstOrDefault();

            var path = Path.Combine(AppDirectory, file?.FilePath);

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            var contentType = "APPLICATION/octet-stream";
            var fileName = Path.GetFileName(path);

            return File(memory, contentType, fileName);
        }
    }
}
