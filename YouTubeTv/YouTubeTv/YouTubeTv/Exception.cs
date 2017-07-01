using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTv
{
    [Serializable]
    public class Exception : System.Exception
    {
        public Exception() { }
        public Exception(string message) : base(message) { }
        public Exception(string message, System.Exception inner) : base(message, inner) { }
        protected Exception(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
   
}
