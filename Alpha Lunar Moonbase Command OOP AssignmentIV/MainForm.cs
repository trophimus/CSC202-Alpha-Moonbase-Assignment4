using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;
using System.Reflection.Emit;

namespace Alpha_Lunar_Moonbase_Command_OOP_AssignmentIV
{
    public partial class MainForm : Form
    { 
        private ToolTip toolTip;      // ToolTip object to provide help to the user
        private Moonbase moonbase;   // Moonbase object to manage the game
        private SpeechSynthesizer synthesizer;    // SpeechSynthesizer object to provide audio feedback to the user
        private string playerName;   // Store the player's name


        public MainForm()
        {
            InitializeComponent();      // Initialize the form components
            moonbase = new Moonbase();  // Create a new Moonbase object
            InitializeToolTips();       // Initialize the ToolTips
            synthesizer = new SpeechSynthesizer();   // Create a new SpeechSynthesizer object
            synthesizer.SelectVoiceByHints(VoiceGender.Female);   // Set the SpeechSynthes to female voice 
            synthesizer.Volume = 100;    // Set the volume to 100
            synthesizer.Rate = 0;       // Set the rate to 0
            UpdateDisplay();           // Update the display
            BTNeast.Click += new EventHandler(BTNeast_Click);
            BTNwest.Click += new EventHandler(BTNwest_Click);
            BTNsouth.Click += new EventHandler(BTNsouth_Click);
            BTNnorth.Click += new EventHandler(BTNnorth_Click);






            string playerName = "AAA ";
            using (var ShowDialog = new ShowDialog())
            {
                if (ShowDialog.ShowDialog() == DialogResult.OK)
                {
                    playerName = ShowDialog.username;
                }
                
                
                    
                
            }
            moonbase.PlayerName = playerName;
            UpdateDisplay();
        }  
        private void TBTusername_TextChanged(object sender, EventArgs e)
        {
           
            
               
            
        }

        
        
            
        

        private void BTNnorth_Click(object sender, EventArgs e)
        {
            if (moonbase.Move("north"))   // If the player can move north
            {
                UpdateDisplay();          // Update the display
            }
            
               
            

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeToolTips();
        }

        private void InitializeToolTips()
        {
            toolTip = new ToolTip();
            toolTip.SetToolTip(BTNnorth, "Go to the Command Center");
            toolTip.SetToolTip(BTNeast, "Go to the Quantum Diner");
            toolTip.SetToolTip(BTNwest, "Go to the Research Lab");
            toolTip.SetToolTip(BTNsouth, "Go to the Living Quarters");
        }

        


        private void BTNeast_Click(object sender, EventArgs e) 
        {
            if (moonbase.Move("east"))
            {
                UpdateDisplay();
            }
        }

        private void BTNwest_Click(object sender, EventArgs e)
        {
            if (moonbase.Move("west"))
            {
                UpdateDisplay();
            }
        }

        private void BTNsouth_Click(object sender, EventArgs e)
        {
            if (moonbase.Move("south"))
            {
                UpdateDisplay();
            }
        }

         private void ToggleButtons(Button clickedButton)
        {             
            BTNnorth.Enabled = true;
            BTNeast.Enabled = true;
            BTNwest.Enabled = true;
            BTNsouth.Enabled = true;
            
            clickedButton.Enabled = false;
        }
        
         private void UpdateDisplay()
         {
          moonbase.CurrentArea.DisplayInfo(lblRoomName, txtRoomDescription, picBackground);  // Display the current area information
                                                                                             // Get the player's name from the TextBox
            
            moonbase.PlayerName = playerName;

          // Get the current room name
          string roomName = moonbase.CurrentArea.Name;

          // Use SpeechSynthesizer to say the welcome message
            synthesizer.SpeakAsync($"{playerName}, welcome to {roomName}");
         }
    }

}

