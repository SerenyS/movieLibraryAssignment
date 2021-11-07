using System;
using NLog;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace movieLibraryAssignment
{
    public abstract class LibraryItem {

       public int ItemID { get; set;}
        public string Title { get; set;}
     
        public abstract int getLastID();
    }
}