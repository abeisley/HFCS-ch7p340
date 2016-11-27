using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch7p340_github
{
    class Opponent
    {
        private Location myLocation;
        private Random random;

        public Opponent(Location startingLocation)
        {
            myLocation = startingLocation;
            random = new Random();
        }

        public void Move()
        {
            if (myLocation is IHasExteriorDoor)
            {
                if (random.Next(2) == 1) // flip a coin
                {
                    IHasExteriorDoor nextLocation = myLocation as IHasExteriorDoor;
                    myLocation = nextLocation.DoorLocation;
                }   
            }

            do
            {
                myLocation = myLocation.Exits[random.Next(myLocation.Exits.Length)];
            } while (!(myLocation is IHidingPlace));
            //debug
            Console.WriteLine(myLocation.Name);
        }

        public bool Check(Location location)
        {
            if (myLocation.Equals(location))
                return true;
            return false;
        }
    }
}
