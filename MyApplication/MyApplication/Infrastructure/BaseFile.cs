using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Infrastructure
{
    public abstract class BaseFile : IFile
    {

        protected string _GetFileExtensions(string fileData)
            
        {
            string[] splitDatas = fileData.Split('.');

            string _fileExtension = splitDatas[splitDatas.Length - 1];

            return _fileExtension;
        }

        protected virtual string _GetFileName(string fileData)
        {
            string[] splitDatas = fileData.Split('.');

            string _fileName = splitDatas[0];

            return _fileName;
        }

        public abstract string GetFileName(string fileData);
       
    }
}
