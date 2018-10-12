using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Infrastructure
{
    public class CustomDateTimeFile : BaseFile
    {
        public override string GetFileName(string fileData)
        {
            string _fileName = _GetFileName(fileData);

            string _fileExtension = _GetFileExtensions(fileData);
            string fileName = $"{_fileName}_{DateTime.Now.ToString("yyyyMMddHHmmss")}.{_fileExtension}";
            return fileName;
        }
    }
}
