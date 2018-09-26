using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
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
        GameEngine MainEngine;
        bool buttonRunning;
        public int xPos;
        public int yPos;
        Map rtsMap;
      

        public void timeMethod() // for the game timer
        {
            lblMilSec.Text = String.Format("{0:00}", timeMs);
            lblSec.Text = String.Format("{0:00}", timeSec);
            lblMins.Text = String.Format("{0:00}", timeMin);
        }     

        private void Form1_Load(object sender, EventArgs e)
        {
            rtsMap = new Map(mapGrid, this);
            Unit MeleeUnit = new MeleeUnit();
            MainEngine = new GameEngine(this);
            Unit RangedUnit = new RangedUnit();

            rtsMap.placeMap();
        }

        public abstract class Building
        {
            protected int xPosition;
            protected int yPosition;
            protected int buildingHealth;
            protected int buildingTeam;
            protected char buildingSymbol;

            public Building()
            {

            }

            public virtual void buildingDeath()
            {
                
            }

            public virtual void ToString()
            {

            }

            public int XPosition
            {
                get { return xPosition; }
                set { xPosition = value; }
            }

            public int YPosition
            {
                get { return yPosition; }
                set { yPosition = value; }
            }

            public int BuildingHealth
            {
                get { return buildingHealth; }
                set { buildingHealth = value; }
            }

            public int BuildingTeam
            {
                get { return buildingTeam; }
                set { buildingTeam = value; }
            }

            public char BuildingSymbol
            {
                get { return buildingSymbol; }
                set { buildingSymbol = value; }
            }

            public abstract void Save();
                 
        }

        [Serializable]
        public class ResourceBuilding : Building
        {
            rtsGame gameInterface = new rtsGame();
            
            private string resourceType;
            private int resourcesPerTick = 0;
            private int resourcesRemaining; //Total u have
            private int i;
            rtsGame form1;

            public ResourceBuilding(rtsGame form1)
            {
                this.form1 = form1;
            }

            public override void buildingDeath()
            {
                buildingHealth = 1000;
                
                if(BuildingHealth <= 0)
                {
                   
                }
            }

            public override void ToString()
            {
                string resourceType;
            }

            public override void Save()
            {

            }

            public string ResourceType
            {
                get { return resourceType; }
                set { resourceType = value; }
            }

            public int ResourcesPerTick
            {
                get { return resourcesPerTick; }
                set { resourcesPerTick = value; }
            }

            public int ResourcesRemaining
            {
                get { return resourcesRemaining; }
                set { resourcesRemaining = value; }
            }

            public int I
            {
                get { return i; }
                set { i = value; }
            }


            public void GenerateResources() //int
            {              
                ResourcesPerTick = (i++) + 1;
                form1.lblCurrency.Text = String.Format("{0:00}", ResourcesPerTick);

                //if()
                //{

                //}
            }

        }
        [Serializable]
        public class FactoryBuilding : Building
        {
            private int unitProduction;
            private int productionPerTick;
            private int spawnPoint;
            rtsGame form1;

            public FactoryBuilding(rtsGame form1)
            {
                this.form1 = form1;
            }

            public override void buildingDeath()
            {
                buildingHealth = 1000;

                if (BuildingHealth <= 0)
                {

                }
            }

            public override void ToString()
            {

            }

            public int UnitProduction
            {
                get { return unitProduction; }
                set { unitProduction = value; }
            }

            public int ProductionPerTick
            {
                get { return productionPerTick; }
                set { productionPerTick = value; }
            }

            public int SpawnPoint
            {
                get { return spawnPoint; }
                set { spawnPoint = value; }
            }

            public void SpawnNewUnits()  //int
            {

            }

            public override void Save()
            {

            }
        }

        public abstract class Unit : Button
        {
            protected string nameofTypeUnit;        
            private int xPosition;
            private int yPosition;
            private int unitHealth;
            private int unitSpeed;
            private int unitAttack;
            private int unitAttackRange;
            private int unitTeam;
            private char unitSymbol;
            private int maxHealth;
            private bool isAttacking;

            public Unit()
            {
         
            }

            public string NameofTypeUnit
            {
                get { return nameofTypeUnit; }
                set { nameofTypeUnit = value; }
            }

            public int MaxHealth
            {
                get { return maxHealth; }
                set { maxHealth = value; }
            }

            public bool IsAttacking
            {
                get { return isAttacking; }
                set { isAttacking = value; }
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

            public abstract void Save();
        }
        [Serializable]
        public class MeleeUnit : Unit
        {

            //GameEngine meleeUnitCalled = new GameEngine();
            //public int unitMovement;
            //public bool isFighting;
            //public int fullHealth;            
            //public int damageGiven;
            //public int damageTaken;

            public MeleeUnit()
            {
                UnitSymbol = 'M';  
            }

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
                //isFighting = true;
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

            public override void Save()
            {

            }
        }
        [Serializable]
        public class RangedUnit : Unit
        {
            public bool isFighting;
            public int fullHealth = 100;

            public RangedUnit()
            {
                UnitSymbol = 'R';
            }

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

            public override void Save()
            {

            }
        }
        [Serializable]
        public class Map
        {
           // ResourceBuilding makeBuilding = new ResourceBuilding();
            public string[,] gameMap = new string[20, 20];
            public int generateNumR, generateNumM;  // int's that stores the user's input
            TableLayoutPanel mapGrid;
            rtsGame rtsGame;
            rtsGame textBoxes = new rtsGame();
            int x, y;

            ResourceBuilding teamOneRBuilding;
            ResourceBuilding teamTwoRBuilding;
            FactoryBuilding teamOneFBuilding;
            FactoryBuilding teamTwoFBuilding;

            // Put Factory building object thingies here


            public Map(TableLayoutPanel mapGrid, rtsGame rtsGame )
            {
                this.rtsGame = rtsGame;
                this.mapGrid = mapGrid;
                this.teamOneRBuilding = new ResourceBuilding(rtsGame);
                this.teamTwoRBuilding = new ResourceBuilding(rtsGame);
                this.teamOneFBuilding = new FactoryBuilding(rtsGame);
                this.teamTwoFBuilding = new FactoryBuilding(rtsGame);
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        gameMap[i, j] = "temp";   
                    }
                }
            }

            public void generateUNITS()
            {
                Random unitsToMake = new Random(Guid.NewGuid().GetHashCode());
                //RangedUnit[] rangedUnitsGen = new RangedUnit[generateNumR]; //binds the unit array to the user input
                //MeleeUnit[] meleeUnitGen = new MeleeUnit[generateNumM];
                mapGrid.Controls.Clear();

                //int generateNumR = Convert.ToInt32(rtsGame.rangedTextB.Text);
                //int generateNumM = Convert.ToInt32(rtsGame.meleeTextBox.Text);

                teamOneRBuilding.XPosition = 0;
                teamOneRBuilding.YPosition = 0;

                teamTwoRBuilding.XPosition = 19;
                teamTwoRBuilding.YPosition = 19;

                teamOneFBuilding.XPosition = 19;
                teamOneFBuilding.YPosition = 0;

                teamTwoFBuilding.XPosition = 0;
                teamTwoFBuilding.YPosition = 19;

                gameMap[teamOneRBuilding.XPosition, teamOneRBuilding.YPosition] = "1RBuilding";
                gameMap[teamOneFBuilding.XPosition, teamOneFBuilding.YPosition] = "1FBuilding";

                gameMap[teamTwoRBuilding.XPosition, teamTwoRBuilding.YPosition] = "2RBuilding";
                gameMap[teamTwoFBuilding.XPosition, teamTwoFBuilding.YPosition] = "2FBuilding";

                rtsGame game = new rtsGame();
                

                for (int i  = 0; i  < 20 ; i ++)
                {
                    x = unitsToMake.Next(0, 20);
                    y = unitsToMake.Next(0, 20);

                    //rangedUnitsGen[i] = new RangedUnit();
                    //rangedUnitsGen[i].Text = rangedUnitsGen[i].UnitSymbol.ToString();
                    //rangedUnitsGen[i].Width = 100;
                    //rangedUnitsGen[i].Height = 100;
                    //int xPos = unitsToMake.Next(0, 20);
                    //int yPos = unitsToMake.Next(0, 20);
                    //gameMap[xPos, yPos] = rangedUnitsGen[i].Text;
                    //mapGrid.Controls.Add(rangedUnitsGen[i], xPos, yPos);                  

                    if (gameMap[x, y] != "1RBuilding" && gameMap[x, y] != "2RBuilding" && gameMap[x, y] != "2FBuilding" && gameMap[x, y] != "1FBuilding")
                    {
                        gameMap[x, y] = "ranged";
                    }
                }

                //for (int i = 0; i < generateNumM; i++)
                //{
                //    meleeUnitGen[i] = new MeleeUnit();

                //    meleeUnitGen[i].Text = meleeUnitGen[i].UnitSymbol.ToString();
                //    meleeUnitGen[i].Width = 100;
                //    meleeUnitGen[i].Height = 100;
                //    int xPos = unitsToMake.Next(0, 10);
                //    int yPos = unitsToMake.Next(0, 10);
                //    mapGrid.Controls.Add(meleeUnitGen[i], xPos, yPos);
                //}            

                for (int i = 0; i < 20; i++)
                {
                    x = unitsToMake.Next(0, 20);
                    y = unitsToMake.Next(0, 20);

                    if (gameMap[x, y] != "ranged" && gameMap[x, y] != "1RBuilding" && gameMap[x, y] != "2RBuilding" && gameMap[x, y] != "2FBuilding" && gameMap[x, y] != "1FBuilding")
                    {
                        gameMap[x, y] = "melee";
                    }
                }                
            }

            public void placeMap()
            {
                mapGrid.Controls.Clear();
                generateUNITS();

                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        Button mapButton = new Button();
                        if (gameMap[i, j] == "temp")
                        {
                            mapButton.Text = "*";
                            mapButton.Height = 100;
                            mapButton.Width = 100;
                            //mapButton.Click += new EventHandler(rtsGame btnEmpty);
                            mapGrid.Controls.Add(mapButton);
                        }
                        else if (gameMap[i, j] == "1RBuilding")
                        {
                            mapButton.Text = "o";
                            mapButton.BackColor = Color.Orange;
                            mapButton.Height = 100;
                            mapButton.Width = 100;
                            //mapButton.Click += new EventHandler(rtsGame btnEmpty);
                            mapGrid.Controls.Add(mapButton);
                        }
                        else if (gameMap[i, j] == "2RBuilding")
                        {
                            //Add BG colour of button
                            mapButton.Text = "o";
                            mapButton.BackColor = Color.Yellow;
                            mapButton.Height = 100;
                            mapButton.Width = 100;
                            //mapButton.Click += new EventHandler(rtsGame btnEmpty);
                            mapGrid.Controls.Add(mapButton);
                        }
                        else if (gameMap[i, j] == "1FBuilding")
                        {
                            //Add BG colour of button
                            mapButton.Text = "x";
                            mapButton.BackColor = Color.Orange;
                            mapButton.Height = 110;
                            mapButton.Width = 110;
                            //mapButton.Click += new EventHandler(rtsGame btnEmpty);
                            mapGrid.Controls.Add(mapButton);
                        }
                        else if (gameMap[i, j] == "2FBuilding")
                        {
                            //Add BG colour of button
                            mapButton.Text = "x";
                            mapButton.BackColor = Color.Yellow;
                            mapButton.Height = 110;
                            mapButton.Width = 110;
                            //mapButton.Click += new EventHandler(rtsGame btnEmpty);
                            mapGrid.Controls.Add(mapButton);
                        }
                        else if (gameMap[i, j] == "ranged")
                        {
                            mapButton.Text = "R";
                            mapButton.Height = 100;
                            mapButton.Width = 100;
                            //mapButton.Click += new EventHandler(rtsGame btnEmpty);
                            mapGrid.Controls.Add(mapButton);
                        }
                        else if (gameMap[i, j] != "temp" && gameMap[i, j] != "ranged" && gameMap[i, j] != "1RBuilding" && gameMap[i, j] != "2RBuilding" && gameMap[x, y] != "1FBuilding" && gameMap[x, y] != "2FBuilding")
                        {
                            mapButton.Text = "M";
                            mapButton.Height = 100;
                            mapButton.Width = 100;
                            //mapButton.Click += new EventHandler(rtsGame btnEmpty);
                            mapGrid.Controls.Add(mapButton);
                        }
                    }
                }
            }

            //public void generateUnits()
            //{               
            //    Random unitsToMake = new Random(Guid.NewGuid().GetHashCode());
            //    RangedUnit[] rangedUnitsGen = new RangedUnit[generateNumR]; //binds the unit array to the user input
            //    MeleeUnit[] meleeUnitGen = new MeleeUnit[generateNumM];
            //    mapGrid.Controls.Clear();

            //    for (int i = 0; i < 20; i++)
            //    {
            //        for (int j = 0; j < 20; j++)
            //        {
            //            Button mapButton = new Button();

            //            if (rtsGame.rtsMap.gameMap[i, j] == "_")
            //            {
            //                mapButton.Text = "*";
            //                mapButton.Width = 100;
            //                mapButton.Height = 100;
            //               // mapGrid.Controls.Add(mapButton);

            //                // if (gameMap[i,j] != 'R')
            //            }

            //            if (rtsGame.rtsMap.gameMap[i, j] == "ResourceBuilding")
            //            {
            //                mapButton.Text = "C";
            //                mapButton.BackColor = Color.Aqua;
            //                mapButton.Width = 100;
            //                mapButton.Height = 100;
            //                //mapGrid.Controls.Add(mapButton);
            //            }

            //            if (rtsGame.rtsMap.gameMap[i, j] == "FactoryBuilding")
            //            {
            //                mapButton.Text = "F";
            //                mapButton.BackColor = Color.Aqua;
            //                mapButton.Width = 100;
            //                mapButton.Height = 100;
            //                //mapGrid.Controls.Add(mapButton);
            //            }



            //            //if (rtsMap.gameMap[i, j] != "FactoryBuilding" && rtsMap.gameMap[i, j] != "M" && rtsMap.gameMap[i, j] != "R" && rtsMap.gameMap[i, j] != "*")
            //            //{
            //            //    rtsMap.gameMap[0, 0] = mapButton.Text = "C";
            //            //    mapButton.BackColor = Color.Aqua;
            //            //    mapButton.Width = 100;
            //            //    mapButton.Height = 100;
            //            //    mapGrid.Controls.Add(mapButton);
            //            //}

            //            //if (rtsMap.gameMap[i, j] != "ResourceBuilding" && rtsMap.gameMap[i, j] != "M" && rtsMap.gameMap[i, j] != "R" && rtsMap.gameMap[i, j] != "*")
            //            //{
            //            //    rtsMap.gameMap[19, 19] = mapButton.Text = "F";
            //            //    mapButton.BackColor = Color.Aqua;
            //            //    mapButton.Width = 100;
            //            //    mapButton.Height = 100;
            //            //    mapGrid.Controls.Add(mapButton);
            //            //}


            //            //if (rtsMap.gameMap[i, j] != "_" && rtsMap.gameMap[i, j] != "FactoryBuilding" && rtsMap.gameMap[i, j] != "R" && rtsMap.gameMap[i, j] != "M")
            //            //{
            //            //    rtsMap.gameMap[0, 0] = mapButton.Text = "C";
            //            //    mapButton.BackColor = Color.Aqua;
            //            //    mapButton.Width = 100;
            //            //    mapButton.Height = 100;
            //            //    mapGrid.Controls.Add(mapButton);
            //            //}

            //            //if (rtsMap.gameMap[i, j] != "_" && rtsMap.gameMap[i, j] != "ResourceBuilding" && rtsMap.gameMap[i, j] != "R" && rtsMap.gameMap[i, j] != "M")
            //            //{
            //            //    rtsMap.gameMap[19, 13] = mapButton.Text = "F";
            //            //    mapButton.BackColor = Color.Aqua;
            //            //    mapButton.Width = 100;
            //            //    mapButton.Height = 100;
            //            //    mapGrid.Controls.Add(mapButton);
            //            //}
            //        }
            //    }
            //    for (int i = 0; i < generateNumR; i++)
            //    {

            //        rangedUnitsGen[i] = new RangedUnit();               
            //        rangedUnitsGen[i].Text = rangedUnitsGen[i].UnitSymbol.ToString();
            //        rangedUnitsGen[i].Width = 100;
            //        rangedUnitsGen[i].Height = 100;
            //        int xPos = unitsToMake.Next(0, 20);
            //        int yPos = unitsToMake.Next(0, 20);
            //      //  gameMap[xPos, yPos] = rangedUnitsGen[i];
            //        //mapGrid.Controls.Add(rangedUnitsGen[i],xPos, yPos);

            //    }

            //    for (int i = 0; i < generateNumM; i++)
            //    {
            //        meleeUnitGen[i] = new MeleeUnit();

            //        meleeUnitGen[i].Text = meleeUnitGen[i].UnitSymbol.ToString();
            //        meleeUnitGen[i].Width = 100;
            //        meleeUnitGen[i].Height = 100;
            //        int xPos = unitsToMake.Next(0, 10);
            //        int yPos = unitsToMake.Next(0, 10);
            //        //mapGrid.Controls.Add(meleeUnitGen[i], xPos, yPos);
            //    }

                
            //        /*for (int i = 0; i < generateNumR; i++)
            //        {
            //            for (int j = 0; j < generateNumM; j++)
            //            {
            //                i = unitsToMake.Next(0, generateNumR);

            //                j = unitsToMake.Next(0, generateNumM);
            //            }
            //        } */
            //        // set two arrays one for each unit type - connect each array to the user input give under their click events - also connect it to a random
            //    }

            public void makeUnit()
            {
                
            }

            public void moveToPosition()
            {

            }

            public void updatePosition()
            {

            }

            public void Read()
            {

            }
        }

        public class GameEngine
        {
            MeleeUnit pikemen;
            RangedUnit archers;
            //ResourceBuilding resources;
            rtsGame form1;
        
            public ResourceBuilding Resources
            {
                get;
                set;
            }

            public GameEngine(rtsGame form1)
            {
                this.form1 = form1;
                pikemen = new MeleeUnit();
                archers = new RangedUnit();
                Resources = new ResourceBuilding(form1);
            }
        }

        private void gamePause_Click(object sender, EventArgs e)
        {
            buttonRunning = false;
        }

        private void rangedUnits_Click(object sender, EventArgs e)
        {
            simulationInfo.Text = "";
            simulationInfo.Text = "Unit Type: Ranged" + Environment.NewLine + "Unit Health: 100" + Environment.NewLine + "Unit Speed: 5" + Environment.NewLine +
                "Unit Attack Range: 3" + Environment.NewLine + "Unit Symbol: R"; //display unit info
        }

        private void meleeUnit_Click(object sender, EventArgs e)
        {
            simulationInfo.Text = "";
            simulationInfo.Text = "Unit Type: Melee" + Environment.NewLine + "Unit Health: 100" + Environment.NewLine + "Unit Speed: 3" + Environment.NewLine +
               "Unit Attack Range: 1" + Environment.NewLine + "Unit Symbol: M"; //display unit info
        }

        private void rangedTextB_TextChanged(object sender, EventArgs e)
        {
            Map map = new Map(mapGrid, this);
            map.generateNumR = Convert.ToInt32(rangedTextB.Text); //Get the user input
        }

        private void meleeTextBox_TextChanged(object sender, EventArgs e)
        {
            Map map = new Map(mapGrid, this);
            map.generateNumM = Convert.ToInt32(meleeTextBox.Text); //Get the user input
        }

        private void resourceTimer_Tick(object sender, EventArgs e)
        {
           
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gameStart_Click(object sender, EventArgs e)
        {           
            buttonRunning = true;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {           
            if(buttonRunning)
            {
                timeMs++;              // Makes the timer work

                if (timeMs >= 100)
                {
                    timeSec++;
                    timeMs = 0;
                    MainEngine.Resources.GenerateResources();

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
   
    

