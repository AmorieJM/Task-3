using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Amorie Marinus
   18015219
   GADE SEM2 ASSIGNMENT 1 - 15/08/17

    References:

    Anon., 2016. Civilization Wiki. [Online] 
Available at: https://vignette.wikia.nocookie.net/civilization/images/7/7f/Archer_%28Civ6%29.png/revision/latest?cb=20161106191622
[Accessed 15 August 2018].
Anon., 2016. Civilization Wiki. [Online] 
Available at: https://d1u5p3l4wpay3k.cloudfront.net/civ6_gamepedia_en/thumb/3/38/Icon_unit_spearman_portrait.png/250px-Icon_unit_spearman_portrait.png?version=484d792ca4d1d74f73df0e895f05af84
[Accessed 14 August 2018].
SaeThunder, 2016. Youtube - Stopwatch using c#. [Online] 
Available at: https://youtu.be/lp9cJJUDUsk
[Accessed 10 August 2018].

   */

namespace SEM2_ASSIGNMENT_TASK1
{
    public partial class rtsGame : Form
    {
        public rtsGame()
        {
            InitializeComponent();
            //newGame();
        }
        // Var's declared in scope
        int timeMs, timeSec, timeMin; //for the timer
        bool buttonRunning;
        Map rtsMap = new Map();

        public void timeMethod()
        {
            lblMilSec.Text = String.Format("{0:00}", timeMs);
            lblSec.Text = String.Format("{0:00}", timeSec);
            lblMins.Text = String.Format("{0:00}", timeMin);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Unit MeleeUnit = new MeleeUnit();
           
            Unit RangedUnit = new RangedUnit();

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Button mapButton = new Button();

                    if (rtsMap.gameMap[i, j] == "_")
                    {
                        mapButton.Text = "*";
                        mapButton.Width = 100;
                        mapButton.Height = 100;
                        mapGrid.Controls.Add(mapButton);
                    }
                }
            }
        }
        public abstract class Unit
        {           
            private int xPosition;
            private int yPosition;
            private int unitHealth;
            private int unitSpeed;
            private int unitAttack;
            private int unitAttackRange;
            private int unitTeam;
            private char unitSymbol;

            public Unit()
            {
         
            }

            public int XPostition
            {
                get {return xPosition;}
                set {xPosition = value;}
            }

            public int YPosition
            {
                get { return yPosition; }
                set { yPosition = value; }
            }

            public int UnitHealth
            {
                get { return unitHealth; }
                set { unitHealth = value; }
            }

            public int UnitSpeed
            {
                get { return unitSpeed; }
                set { unitSpeed = value; }
            }

            public int UnitAttack
            {
                get { return unitAttack; }
                set { unitAttack = value; }
            }

            public int UnitAttackRange
            {
                get { return unitAttackRange; }
                set { unitAttackRange = value; }
            }

            public int UnitTeam
            {
                get { return unitTeam; }
                set { unitTeam = value; }
            }

            public char UnitSymbol
            {
                get { return unitSymbol; }
                set { unitSymbol = value; }
            }
            public virtual void moveUnit()
            {
                
            }

            public virtual void unitCombat()
            {

            }

            public virtual void isWithinRange()
            {
                
            }

            public virtual void closestUnit()
            {

            }

            public virtual void unitDeath()
            {

            }

            public virtual void unitInformation()
            {

            }       
        }

        public class MeleeUnit : Unit
        {
            
            public int unitMovement;
            public bool isFighting;
            public int fullHealth;            
            public int damageGiven;
            public int damageTaken; 

            public override void moveUnit()
            {               
                //this.XPostition = XPostition;
                //this.YPosition = YPosition;
            }

            public override void unitCombat()
            {
          
            }

            public override void isWithinRange()
            {
                isFighting = true;
            }

            public override void closestUnit()
            {

            }

            public override void unitDeath()
            {

            }

            public override void unitInformation()
            {

            }
        }

        public class RangedUnit : Unit
        {
            public bool isFighting;
            public int fullHealth = 100;
           
            public override void moveUnit()
            {
                
            }

            public override void unitCombat()
            {

            }

            public override void isWithinRange()
            {

            }

            public override void closestUnit()
            {

            }

            public override void unitDeath()
            {

            }

            public override void unitInformation()
            {

            }
        }

        public class Map
        {
            public string[,] gameMap = new string[20, 20];
            public int generateNumR, generateNumM;  // int's that stores the user's input

            public Map()
            {
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        gameMap[i, j] = "_";
                    }
                }
            }

            public void generateUnits()
            {
               // for (int i = 0; i < 20; i++)
               // {
                  //  Random unitsToMake = new Random(Guid.NewGuid().GetHashCode());
                   // generateNumR 
               // }
                Random unitsToMake = new Random(Guid.NewGuid().GetHashCode());
                int[] rangedUnitsGen = new int[generateNumR]; //binds the unit array to the user input
                int[] meleeUnitGen = new int[generateNumM];

                for (int i = 0; i < generateNumR; i++)
                {
                    for (int j = 0; j < generateNumM; j++)
                    {
                        i = unitsToMake.Next(0, generateNumR);

                        j = unitsToMake.Next(0, generateNumM);
                    }
                } 
                // set two arrays one for each unit type - connect each array to the user input give under their click events - also connect it to a random
            }

            public void newGame()
            {
                
            }

            public void moveToPosition()
            {

            }

            public void updatePosition()
            {

            }
        }

        public class GameEngine : Unit
        {
            MeleeUnit archers = new MeleeUnit();
            RangedUnit pikemen = new RangedUnit();
        }

        private void gamePause_Click(object sender, EventArgs e)
        {
            buttonRunning = false;
        }

        private void gameReset_Click(object sender, EventArgs e)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (NotImplementedException notImp)
            {
                DialogResult result = MessageBox.Show("WARNING! You are about to reset the game.", notImp.Message, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    timeMs = 0;
                    timeSec = 0;
                    timeMin = 0;

                    rangedTextB.Text = "";
                    meleeTextBox.Text = "";
                }
            }                  
        }

        private void rangedUnits_Click(object sender, EventArgs e)
        {
            simulationInfo.Text = "";
            simulationInfo.Text = "Unit Type: Ranged" + Environment.NewLine + "Unit Health: 100" + Environment.NewLine + "Unit Speed: 5" + Environment.NewLine +
                "Unit Attack Range: 3" + Environment.NewLine + "Unit Symbol: R";
        }

        private void meleeUnit_Click(object sender, EventArgs e)
        {
            simulationInfo.Text = "";
            simulationInfo.Text = "Unit Type: Melee" + Environment.NewLine + "Unit Health: 100" + Environment.NewLine + "Unit Speed: 3" + Environment.NewLine +
               "Unit Attack Range: 1" + Environment.NewLine + "Unit Symbol: M";
        }

        private void imSad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I tried!", "Ugh", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void rangedTextB_TextChanged(object sender, EventArgs e)
        {
            rtsMap.generateNumR = Convert.ToInt32(rangedTextB.Text); //Get the user input
        }

        private void meleeTextBox_TextChanged(object sender, EventArgs e)
        {          
            rtsMap.generateNumM = Convert.ToInt32(meleeTextBox.Text); //Get the user input
        }
        // Now I need to connect the user input to an array that randomly places units on the map (Nested for Loop?)

        private void gameStart_Click(object sender, EventArgs e)
        {           
            buttonRunning = true;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if(buttonRunning)
            {
                timeMs++;

                if (timeMs >= 100)
                {
                    timeSec++;
                    timeMs = 0;      

                    if (timeSec >= 60)
                    {
                        timeMin++;
                        timeSec = 0;
                    }
                }
            }
            timeMethod(); // calls function to draw the time
        }
    }
}
   
    

