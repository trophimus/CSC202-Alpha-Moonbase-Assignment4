using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing; 

namespace Alpha_Lunar_Moonbase_Command_OOP_AssignmentIV
{
    
    
        public class Area  // Area class to represent a location in the moonbase
        {
            public string Name { get; set; }            // The name of the area
            public string Description { get; set; }     // The description of the area
            public Image BackgroundImage { get; set; }  // The background image of the area
            public Area North { get; set; }            // The area to the north
            public Area South { get; set; }           // The area to the south
            public Area East { get; set; }           // The area to the east 
            public Area West { get; set; }          // The area to the west

            public Area(string name, string description, Image backgroundImage)
            {
                Name = name;                                  // Set the name of the area
                Description = description;                   // Set the description of the area
                BackgroundImage = backgroundImage;     // Load the background image of the area
            }

           
            public void DisplayInfo(Label lblRoomName, TextBox txtRoomDescription, PictureBox picBackground)
            {
                lblRoomName.Text = Name;                       // Set the name of the area
                txtRoomDescription.Text = Description;        // Set the description of the area
                picBackground.Image = BackgroundImage;      // Set the background image of the area
                picBackground.SizeMode = PictureBoxSizeMode.StretchImage;
        }
            }






    
}
