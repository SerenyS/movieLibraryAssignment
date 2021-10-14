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
       

        public abstract void Read();
        public abstract void Write();
        public abstract int getLastID();
    }
}