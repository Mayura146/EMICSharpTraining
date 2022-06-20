using FileUpload_Download.Entities;
using System.Threading.Tasks;

namespace FileUpload_Download.Repository
{
    public interface IFileUploadRepository
    {
        public Task UploadFileAsync(FileModel fileModel);
        public Task<int> DownloadFileAsync(int id);
    }
}
