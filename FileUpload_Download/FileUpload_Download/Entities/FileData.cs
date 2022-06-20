﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FileUpload_Download.Entities
{
    public partial class FileData
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public string MimeType { get; set; }
        public string FilePath { get; set; }
    }
}
