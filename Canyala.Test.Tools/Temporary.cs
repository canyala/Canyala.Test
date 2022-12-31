//
// Copyright (c) 2012 Canyala Innovation AB
//
// All rights reserved.
//

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canyala.Test.Tools
{
    public sealed class Temporary : IDisposable
    {
        public string FilePath { get; private set; }

        internal Temporary() 
            { FilePath = Path.GetTempFileName(); }

        bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            try
            {
                if (!disposed)
                {
                    if (File.Exists(FilePath)) 
                        File.Delete(FilePath);
                }
            }
            finally
            {
                disposed = true;
            }
        }

        ~Temporary()
        {
            Dispose(false);
        }
    }
}
