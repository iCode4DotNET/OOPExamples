using System.Collections.Generic;
using System.IO;

namespace SadrTools.Extension
{
    public static class FileExt
    {
        public static string Print(this IEnumerable<FileInfo> files) 
        {
            var str = "";
            foreach (var file in files) 
            {
                str += $"{file.Name.PadRight(60)} : " +
                       $"{file.Length} B  " +
                       $"{file.Length/1024} KB\n\n";  
            }

            return str;
        }
    }
    

}
