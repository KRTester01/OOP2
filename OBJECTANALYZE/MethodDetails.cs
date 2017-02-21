using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBJECTANALYZE
{
    class MethodDetails
    {
        public enum AccessModifier { Public, Private}

        public class MethodDetail
        {
            public string MethodName { get; set; }


            public AccessModifier MethodAccessModifier { get; set; }
        }
    }
}
