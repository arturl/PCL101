using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL101
{
    public sealed class Math
    {
        // Subtraction is platform-independent
        public static int subtract(int x, int y)
        {
            return x - y;
        }

        // Addition is platform-dependent
        public static int add(int x, int y)
        {
#if DESKTOP
            // Desktop impl needs to spawn a thread
            return DesktopSupport.SpawnThreadAndAddTwoNumbers(x, y);
#elif WINDOWS_UWP
            // Desktop impl needs to spawn a task
            return UWPSupport.SpawnTaskAndAddTwoNumbers(x, y);
#elif ANDROID
            // Android impl is something else entirely
            return AndroidSupport.AddTwoNumbers(x, y);
#else
            // This can only happen on an unsupported platform: assume this platform doesn't support addition
            throw new NotImplementedByReferenceAssemblyException();
#endif
        }
    }
}