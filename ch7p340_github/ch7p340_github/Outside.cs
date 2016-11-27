using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch7p340_github
{
    class Outside : Location
    {
        public bool Hot { get; private set; }

        public Outside(string name, bool hot) : base(name)
        {
            Hot = hot;
        }

        public override string Description {
            get
            {
                if (Hot)
                    return base.Description + " It's very hot here.";
                else
                    return base.Description;
            }
        }
    }
}
