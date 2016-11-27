using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch7p340_github
{
    class RoomWithHidingPlace : Room, IHidingPlace
    {
        public RoomWithHidingPlace(string name, string decoration, string hidingPlace) : base(name, decoration)
        {
            HidingPlace = hidingPlace;
        }

        public string HidingPlace { get; }

        public override string Description
        {
            get
            {
                return base.Description + " and you could look " +
                    HidingPlace;
            }
        }
    }
}
