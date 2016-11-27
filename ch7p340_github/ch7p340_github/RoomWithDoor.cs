using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch7p340_github
{
    class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration, string hidingPlace, string doorDescription) : base(name, decoration, hidingPlace)
        {
            DoorDescription = doorDescription;
        }

        public string DoorDescription { get; }

        public override string Description
        {
            get
            {
                return base.Description + " and " + 
                    DoorDescription + ".";
            }
        }

        public Location DoorLocation { get; set; }
    }
}
