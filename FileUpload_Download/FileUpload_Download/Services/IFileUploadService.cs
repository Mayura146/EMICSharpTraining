using FileUpload_Download.Entities;
using System.Threading.Tasks;

namespace FileUpload_Download.Services
{
    public interface IFileUploadService
    {
        public Task UploadFileAsync(FileModel fileModel);
        public Task<int> DownloadFileAsync(int id);
    }
}
