using System;
using ReaderTextApp.Model;
using System.Collections.Generic;
using System.Text;
using ReaderTextApp.logic;

namespace ReaderTextApp.Controller
{
    class MenuController
    {
        public string ViewResult(int _option)
        {
            FiletoRead filetoRead = new FiletoRead();
            FileInOptions fileInOptions = new FileInOptions(filetoRead.GetFile());
            string message = " ";
            switch (_option)
            {
                case 1:
                    message = fileInOptions.FileNotFiltered();
                    break;
                case 2:
                    message = fileInOptions.FileFilteredChar();
                    break;
                case 3:
                    message = fileInOptions.FileCharacter();
                    break;
                case 4:
                    message = fileInOptions.FilePalindrome();
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            return message;
        }
    }
}
