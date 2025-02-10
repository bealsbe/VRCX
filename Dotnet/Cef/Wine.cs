using System;
using System.Runtime.InteropServices;

namespace VRCX
{
    public static class Wine
    {
        [DllImport("ntdll.dll")]
        private static extern IntPtr wine_get_version();

        public static bool GetIfWine()
        {
            return false;
        }
    }
}