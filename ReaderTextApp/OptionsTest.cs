using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;
using ReaderTextApp.logic;

namespace ReaderTextApp
{
    [TestFixture]
    class OptionsTest
    {
        [TestCase]
        public void Add()
        {
            
            string file=@"rute\rue\";
            FileInOptions fileInOptions = new FileInOptions(file);
            Assert.AreEqual("text result", fileInOptions.FileNotFiltered());
        }
    }
}
