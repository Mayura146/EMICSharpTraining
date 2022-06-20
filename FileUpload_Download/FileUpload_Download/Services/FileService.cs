using FileUpload_Download.Entities;
using FileUpload_Download.Repository;
using System.Threading.Tasks;

namespace FileUpload_Download.Services
{
    public class FileService : IFileUploadService
    {
        private readonly IFileUploadRepository _fileRepository;

        public FileService(IFileUploadRepository repository)
        {
            _fileRepository = repository;
        }
     

        public async Task UploadFileAsync(FileModel fileModel)
        {
        await _fileRepository.UploadFileAsync(fileModel);   
        }
    }
}
