using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch7p340_github
{
    class Room : Location
    {
        public Room(string name, string decoration) : base(name)
        {
            Decoration = decoration;
        }

        public string Decoration { get; private set; }

        public override string Description {
            get
            {
                return base.Description + " You see " + Decoration;
            }
        }
    }
}
