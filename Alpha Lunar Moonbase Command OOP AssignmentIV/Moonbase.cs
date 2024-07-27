using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;


namespace Alpha_Lunar_Moonbase_Command_OOP_AssignmentIV
{
    public class Moonbase // Moonbase class to manage the game
    {
        public Area CurrentArea { get; private set; } // The current area of the moonbase
        public string PlayerName { get; set; }   // The player's name

        public Moonbase()
        {
            InitializeAreas();  // Initialize the areas of the moonbase
        }

        private void InitializeAreas() // Initialize the areas of the moonbase
        {
            Area commandControl = new Area("Command and Control Room", 
                "This room is filled with advanced computer systems, large monitors displaying various moonbase stats, and communication equipment. The room hums with the sound of machinery, creating an atmosphere of constant activity and importance.",
                  Properties.Resources.ControlCenter);

            Area scienceLab = new Area("Science Research Lab", 
                "The lab is equipped with state-of-the-art scientific instruments, including microscopes, centrifuges, and analysis computers. Experiments in various stages of completion can be seen on the workbenches. The air smells faintly of chemicals and ozone.",
                  Properties.Resources.RnDLab);

            Area quantumDiner = new Area("Quantum Diner",
                "This cozy area serves as both a cafeteria and a social hub. Food synthesizers line one wall, while comfortable seating areas are scattered throughout. The large viewing window offers a breathtaking view of the lunar landscape.",
                 Properties.Resources.Diner);
         

            Area livingQuarters = new Area("Living Quarters", 
                "This area contains personal sleeping pods, each equipped with entertainment systems and communication devices. The lighting is softer here, creating a more relaxed atmosphere. There's also a small gym and a meditation room for off-duty relaxation.",
                 Properties.Resources.Sleeping);

           // commandControl.East = scienceLab;        // Set the connections between the areas
            //commandControl.West = quantumDiner;     // Set the connections between the areas
           // commandControl.South = livingQuarters;  // Set the connections between the areas

          //  commandControl.East = scienceLab;        // Set the connections between the areas
           // commandControl.West = quantumDiner;     // Set the connections between the areas
           // commandControl.South = livingQuarters;

            //scienceLab.West = commandControl;        // Set the connections between the areas
          //  quantumDiner.East = commandControl;     // Set the connections between the areas
           // livingQuarters.North = commandControl; // Set the connections between the areas

            
            // Set connections between the areas
            setConnections(commandControl, null, livingQuarters, scienceLab, quantumDiner);
            setConnections(scienceLab, null, null, null, commandControl);
            setConnections(quantumDiner, null, null, commandControl, null);
            setConnections(livingQuarters, commandControl, null, null, null);



            CurrentArea = commandControl;        // Set the current area to the Command and Control Room
        }

        private void setConnections(Area area, Area north, Area south, Area east, Area west)
        {
            area.North = north;  // Set the connections between the areas
            area.South = south;  // Set the connections between the areas
            area.East = east;   // Set the connections between the areas
            area.West = west;  // Set the connections between the areas
        }

        public bool Move(string direction)  // Move the player to a new area
        {
            Area nextArea = null;          // The next area to move to
            switch (direction.ToLower())   
            {
                case "north": nextArea = CurrentArea.North; break;   // Check the direction and set the next area accordingly
                case "south": nextArea = CurrentArea.South; break;   // Check the direction and set the next area accordingly
                case "east": nextArea = CurrentArea.East; break;    // Check the direction and set the next area accordingly
                case "west": nextArea = CurrentArea.West; break;    // Check the direction and set the next area accordingly
            }

            if (nextArea != null)
            {
                CurrentArea = nextArea;   // Move the player to the next area
                return true;             // Return true if the player can move
            }
            return false;             // Return false if the player cannot move
        }

       
        
        

    }

}
