using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch7p340_github
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            ResetGame("");
        }

        // create object references
        RoomWithDoor livingRoom;
        Room diningRoom;
        RoomWithDoor kitchen;
        OutsideWithDoor frontYard;
        OutsideWithHidingPlace garden;
        OutsideWithDoor backYard;
        Room stairs;
        RoomWithHidingPlace upstairsHallway;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;
        RoomWithHidingPlace bathroom;
        OutsideWithHidingPlace driveway;

        Location currentLocation;
        Opponent opponent;
        private bool gameStarted;
        public int numberOfMoves = 0;

        public void CreateObjects()
        {
            // create rooms
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "in the closet", "an oak door with a brass knob");
            diningRoom = new Room("Dining Room", "crystal chandelier");
            kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances", "in the cabinet", "a screen door");
            frontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
            garden = new OutsideWithHidingPlace("Garden", false, "in the shed");
            backYard = new OutsideWithDoor("Back Yard", true, "a screen door");
            stairs = new Room("Stairs", "a wooden bannister");
            upstairsHallway = new RoomWithHidingPlace("Upstairs Hallway", "a picture of a dog", "in the closet");
            masterBedroom = new RoomWithHidingPlace("Master Bedroom", "a large bed", "under the bed");
            secondBedroom = new RoomWithHidingPlace("Second Bedroom", "a small bed", "under the bed");
            bathroom = new RoomWithHidingPlace("Bathroom", "a sink and a toilet", "in the shower");
            driveway = new OutsideWithHidingPlace("Driveway", false, "in the garage");

            // link rooms together
            livingRoom.Exits = new Location[] { frontYard, diningRoom, stairs };
            livingRoom.DoorLocation = frontYard;
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            kitchen.Exits = new Location[] { diningRoom, backYard };
            kitchen.DoorLocation = backYard;
            frontYard.Exits = new Location[] { livingRoom, backYard, garden, driveway };
            frontYard.DoorLocation = livingRoom;
            garden.Exits = new Location[] { frontYard, backYard };
            backYard.Exits = new Location[] { kitchen, garden, frontYard, driveway };
            backYard.DoorLocation = kitchen;
            stairs.Exits = new Location[] { livingRoom, upstairsHallway };
            upstairsHallway.Exits = new Location[] { stairs, masterBedroom, secondBedroom, bathroom };
            masterBedroom.Exits = new Location[] { upstairsHallway };
            secondBedroom.Exits = new Location[] { upstairsHallway };
            bathroom.Exits = new Location[] { upstairsHallway };
            driveway.Exits = new Location[] { frontYard, backYard };
        }

        private void MoveToANewLocation(Location newLocation)
        {
            currentLocation = newLocation;
            numberOfMoves++;
            RedrawForm();
        }

        private void RedrawForm()
        {
            exits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
            {
                exits.Items.Add(currentLocation.Exits[i].Name);
            }
            exits.SelectedIndex = 0;

            if (currentLocation is IHasExteriorDoor)
                goThoughTheDoor.Visible = true;
            else
                goThoughTheDoor.Visible = false;

            if (currentLocation is IHidingPlace)
            {
                IHidingPlace thisRoom = currentLocation as IHidingPlace;
                check.Text = "Check " + thisRoom.HidingPlace;
                check.Visible = true;
            }
            else
                check.Visible = false;

            if (gameStarted)
            {
                hide.Visible = false;
                goHere.Visible = true;
                exits.Visible = true;
                description.Text = currentLocation.Description;
            }
            else
            {
                hide.Visible = true;
                goHere.Visible = false;
                exits.Visible = false;
                goThoughTheDoor.Visible = false;
                check.Visible = false;
            }
        }

        private void ResetGame(string message)
        {
            opponent = new Opponent(frontYard);
            MoveToANewLocation(livingRoom);
            gameStarted = false;
            numberOfMoves = 0;
            description.Text = message;
            RedrawForm();
        }

        private void goHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[exits.SelectedIndex]);
        }

        private void goThoughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor here = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(here.DoorLocation);
        }

        private void check_Click(object sender, EventArgs e)
        {
            if (opponent.Check(currentLocation))
            {
                string message = "You found me in " + numberOfMoves +
                    " moves! I was hiding in the " + currentLocation.Name;
                ResetGame(message);
            }
            else
                MessageBox.Show("There's nothing here...");
        }

        private void hide_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                description.Text = i + "...";
                opponent.Move();
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }
            description.Text = "Ready or not, here I come!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            gameStarted = true;
            RedrawForm();

        }
    }
}
