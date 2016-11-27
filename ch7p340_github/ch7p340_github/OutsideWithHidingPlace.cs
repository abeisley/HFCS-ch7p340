using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch7p340_github
{
    class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        public OutsideWithHidingPlace(string name, bool hot, string hidingPlace) : base(name, hot)
        {
            HidingPlace = hidingPlace;
        }

        public override string Description
        {
            get
            {
                return base.Description + " and you could look " +
                    HidingPlace + ".";
            }
        }

        public string HidingPlace { get; }
    }
}
