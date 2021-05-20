using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Core
{
    public static class Major
    {
        public const string AnabilimDali = "Ana Bilim Dalı";
        public const string CiftAnaDal = "Çift Ana Dal";

        public static List<string> GetMajor()
        {
            return new List<string> { AnabilimDali, CiftAnaDal };
        }
     }
    
}
