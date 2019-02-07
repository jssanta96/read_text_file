using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReaderTextApp.logic
{
    class FileInOptions
    {
        private string _file { get; set; }
        public FileInOptions(string _filev)
        {
            _file = _filev;
        }
        public string FileNotFiltered()
        {
            return _file;
        }
        
        public  string FileFilteredChar()
        {
            List<string> lstContentFile;
            List<string> lstContentResult = new List<string>();

            lstContentFile = _file.Split(' ').ToList();


            for (int i = 0; i < lstContentFile.Count; i++)
            {
                if (lstContentFile[i].StartsWith("t")) {

                    lstContentResult.Add(lstContentFile[i]);
                }
            }

            if (lstContentResult.Count == 0)
            {
                return "No se encontraron resultados";
            }

            return String.Join(",",lstContentResult);
        }

        public string FilePalindrome()
        {
            List<string> lstContentFile;
            List<string> lstContentResult = new List<string>();
         
           
            lstContentFile = _file.Split(' ').ToList();



            for (int i = 0; i < lstContentFile.Count; i++)
            {
                char[] charString = lstContentFile[i].ToArray();
                Array.Reverse(charString);

                
                if (lstContentFile[i].Equals(String.Join("", charString)))
                {
                    
                    lstContentResult.Add(lstContentFile[i]);
                }

            }

            if (lstContentResult.Count == 0)
            {
                return "No se encontraron resultados";
            }

            return String.Join(",", lstContentResult);
        }

        public string FileCharacter()
        {
            List<string> lstContentFile ;
            List<string> lstContentResult = new List<string>();

            lstContentFile = _file.Split(' ').ToList();


            for (int i = 0; i < lstContentFile.Count; i++)
            {
                if (lstContentFile[i].Count()==5)
                {

                    lstContentResult.Add(lstContentFile[i]);
                }
            }

            if (lstContentResult.Count == 0)
            {
                return "No se encontraron resultados";
            }

            return String.Join(",", lstContentResult);

        }


    }
}
