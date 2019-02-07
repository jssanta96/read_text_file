using System;
using System.Collections.Generic;
using System.Text;

namespace ReaderTextApp.Model
{
    class FiletoRead
    {
        private readonly string  _file = @"C:\users\Desarrollo\documents\archivo.txt";
        public string GetFile()
        {
            string content;
            System.IO.StreamReader streamReader = new System.IO.StreamReader(_file);
            content = streamReader.ReadToEnd();
            streamReader.Close();

            return content;
        }
    }
}
