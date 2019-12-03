using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Mocking.Mocking
{
    public interface IFileReader
    {
        string ReadFile(string path);
    }
    public class FileReader:IFileReader
    {
        public string ReadFile(string path)
        {
            return File.ReadAllText(path);
        }
    }
}