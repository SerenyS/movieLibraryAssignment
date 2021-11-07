using System;
using NLog;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace movieLibraryAssignment
{
    public interface IMedia{
        void Read();
        void Write();
    }
}