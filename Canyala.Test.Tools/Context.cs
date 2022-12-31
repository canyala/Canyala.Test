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
    public static class Context
    {
        /// <summary>
        /// Gets the full file path to a file name in the current application directory.
        /// </summary>
        /// <param name="fileName">the name of the file to get ("test.ttl" etc.)</param>
        /// <returns>The full path to the file specified ("C:\Program Files\MyApp\test.ttl")</returns>
        public static string TestFile(string fileName)
        {
            var applicationBase = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            return Path.Combine(Directory.GetParent(applicationBase).Parent.FullName, "TestFiles", fileName);
        }

        public static Temporary GetTemporary()
            { return new Temporary(); }
    }
}
