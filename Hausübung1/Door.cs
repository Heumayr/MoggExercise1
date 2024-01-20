using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Hausübung1
{
    internal class Door
    {
        public string position = string.Empty;
        public bool IsClosed { get; set; }
        public bool IsLocked { get; set; }
        public string Position { get { return position; } set { position = value; } }
    }
}


