using System;
using NLog;
using System.IO;
using System.Collections.Generic;

namespace movieLibraryAssignment
{
    class Program
    {
            private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
           UserSelection selections = new UserSelection();
           selections.MenuSelection();
        }
        
    }
}
