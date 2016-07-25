using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL101
{
    internal class NotImplementedByReferenceAssemblyException : NotImplementedException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotImplementedByReferenceAssemblyException"/> class.
        /// </summary>
        internal NotImplementedByReferenceAssemblyException()
            : base("This is a reference assembly and does not contain implementation. Be sure to install the PCL101 package into your application so the platform implementation assembly will be used at runtime.")
        {
        }
    }
}
