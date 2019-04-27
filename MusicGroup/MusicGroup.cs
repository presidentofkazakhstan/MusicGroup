using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGroup
{
    public class MusicGroup
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public virtual Song Song { get; set; }
    }
}
