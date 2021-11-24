using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenisys
{
    public class Group
    {
        public string Name { get; set; }
        public string ParentName { get; set; }
        public Group Parent { get; set; }
        public List<string> Permissions { get; set; }
    }
}
