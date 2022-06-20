using FileUpload_Download.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FileUpload_Download.Repository
{
    public class FileRepository : IFileUploadRepository
    {
        private readonly string AppDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
        private static IEnumerable<List<FileRecord>> _fileDb;
        private readonly FileManagerContext _context;

        public FileRepository(IEnumerable<List<FileRecord>> fileRecords,FileManagerContext fileManagerContext)
        {
            _fileDb = fileRecords;  
            _context = fileManagerContext;
        }
      
   
        public async Task UploadFileAsync(FileModel fileModel)
        {
         try
            {
                FileRecord file= await SaveFileAsync(fileModel.MyFile);
                if(!string.IsNullOrEmpty(file.FilePath))
                {
                    file.AltText = fileModel.AltText;
                    file.Description = fileModel.Description;
                    SaveToDb(file);
                }
            }
            catch
            {
                throw;
            }
        }

        private void SaveToDb(FileRecord record)
        {
            if (record == null)
                throw new ArgumentNullException($"{nameof(record)}");
            FileData fileData = new FileData();
            fileData.FilePath = record.FilePath;
            fileData.FileName = record.FileName;
            fileData.FileExtension = record.FileFormat;
            fileData.MimeType = record.ContentType;
            _context.FileData.Add(fileData);
            _context.SaveChangesAsync();
        }

        private async Task<FileRecord> SaveFileAsync(IFormFile formFile)
        {
            FileRecord file = new FileRecord();
            if(formFile!=null)
            {
                if(Directory.Exists(AppDirectory))
                    Directory.CreateDirectory(AppDirectory);

                var fileName=DateTime.Now.Ticks.ToString()+ Path.GetExtension(formFile.FileName);
                var path=Path.Combine(AppDirectory, fileName);
                file.Id = _fileDb.Count() + 1;
                file.FilePath = path;
                file.FileName = fileName;
                file.FileFormat=Path.GetExtension(formFile.FileName);
                file.ContentType=formFile.ContentType;
                FileStream fs = new FileStream(path, FileMode.Create);
                await fs.CopyToAsync(fs);
            }

            return file;
        }

        
    }
}
