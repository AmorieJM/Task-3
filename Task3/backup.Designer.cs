namespace SEM2_ASSIGNMENT_TASK1
{
    partial class rtsGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rtsGame));
            this.teamNameOne = new System.Windows.Forms.Label();
            this.gameStart = new System.Windows.Forms.Button();
            this.gamePause = new System.Windows.Forms.Button();
            this.simulationInfo = new System.Windows.Forms.TextBox();
            this.lblMins = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.punctuationOne = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMilSec = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.mapGrid = new System.Windows.Forms.TableLayoutPanel();
            this.saveButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.resourceName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.teamOneXP = new System.Windows.Forms.Label();
            this.teamOneXPLBL = new System.Windows.Forms.Label();
            this.totalCountOneLBL = new System.Windows.Forms.Label();
            this.team1Total = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.teamTwoXP = new System.Windows.Forms.Label();
            this.teamTwoXPLBL = new System.Windows.Forms.Label();
            this.totalCountTwoLBL = new System.Windows.Forms.Label();
            this.recourseNameTwo = new System.Windows.Forms.Label();
            this.Team2Total = new System.Windows.Forms.Label();
            this.lblCurrency2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameOne
            // 
            this.teamNameOne.AutoSize = true;
            this.teamNameOne.Location = new System.Drawing.Point(12, 85);
            this.teamNameOne.Name = "teamNameOne";
            this.teamNameOne.Size = new System.Drawing.Size(0, 17);
            this.teamNameOne.TabIndex = 4;
            // 
            // gameStart
            // 
            this.gameStart.BackColor = System.Drawing.SystemColors.Info;
            this.gameStart.Location = new System.Drawing.Point(822, 79);
            this.gameStart.Name = "gameStart";
            this.gameStart.Size = new System.Drawing.Size(75, 23);
            this.gameStart.TabIndex = 8;
            this.gameStart.Text = "START";
            this.gameStart.UseVisualStyleBackColor = false;
            this.gameStart.Click += new System.EventHandler(this.gameStart_Click);
            // 
            // gamePause
            // 
            this.gamePause.BackColor = System.Drawing.SystemColors.Info;
            this.gamePause.Location = new System.Drawing.Point(984, 79);
            this.gamePause.Name = "gamePause";
            this.gamePause.Size = new System.Drawing.Size(75, 23);
            this.gamePause.TabIndex = 9;
            this.gamePause.Text = "PAUSE";
            this.gamePause.UseVisualStyleBackColor = false;
            this.gamePause.Click += new System.EventHandler(this.gamePause_Click);
            // 
            // simulationInfo
            // 
            this.simulationInfo.Location = new System.Drawing.Point(822, 114);
            this.simulationInfo.Multiline = true;
            this.simulationInfo.Name = "simulationInfo";
            this.simulationInfo.Size = new System.Drawing.Size(237, 107);
            this.simulationInfo.TabIndex = 10;
            // 
            // lblMins
            // 
            this.lblMins.AutoSize = true;
            this.lblMins.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMins.Location = new System.Drawing.Point(857, 11);
            this.lblMins.Name = "lblMins";
            this.lblMins.Size = new System.Drawing.Size(53, 34);
            this.lblMins.TabIndex = 1;
            this.lblMins.Text = "00";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.Location = new System.Drawing.Point(928, 12);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(53, 34);
            this.lblSec.TabIndex = 11;
            this.lblSec.Text = "00";
            // 
            // punctuationOne
            // 
            this.punctuationOne.AutoSize = true;
            this.punctuationOne.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punctuationOne.Location = new System.Drawing.Point(910, 11);
            this.punctuationOne.Name = "punctuationOne";
            this.punctuationOne.Size = new System.Drawing.Size(25, 34);
            this.punctuationOne.TabIndex = 14;
            this.punctuationOne.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(977, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 34);
            this.label1.TabIndex = 15;
            this.label1.Text = ".";
            // 
            // lblMilSec
            // 
            this.lblMilSec.AutoSize = true;
            this.lblMilSec.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilSec.Location = new System.Drawing.Point(992, 17);
            this.lblMilSec.Name = "lblMilSec";
            this.lblMilSec.Size = new System.Drawing.Size(42, 28);
            this.lblMilSec.TabIndex = 16;
            this.lblMilSec.Text = "00";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // mapGrid
            // 
            this.mapGrid.ColumnCount = 20;
            this.mapGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mapGrid.Location = new System.Drawing.Point(12, 12);
            this.mapGrid.Name = "mapGrid";
            this.mapGrid.RowCount = 20;
            this.mapGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mapGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mapGrid.Size = new System.Drawing.Size(587, 586);
            this.mapGrid.TabIndex = 18;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1093, 583);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(76, 23);
            this.saveButton.TabIndex = 23;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(1175, 583);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(76, 23);
            this.readButton.TabIndex = 24;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(57, 42);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(24, 17);
            this.lblCurrency.TabIndex = 25;
            this.lblCurrency.Text = "00";
            // 
            // resourceName
            // 
            this.resourceName.AutoSize = true;
            this.resourceName.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resourceName.Location = new System.Drawing.Point(6, 40);
            this.resourceName.Name = "resourceName";
            this.resourceName.Size = new System.Drawing.Size(46, 20);
            this.resourceName.TabIndex = 26;
            this.resourceName.Text = "Gold:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.teamOneXP);
            this.groupBox1.Controls.Add(this.teamOneXPLBL);
            this.groupBox1.Controls.Add(this.totalCountOneLBL);
            this.groupBox1.Controls.Add(this.team1Total);
            this.groupBox1.Controls.Add(this.resourceName);
            this.groupBox1.Controls.Add(this.lblCurrency);
            this.groupBox1.Location = new System.Drawing.Point(629, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 161);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Team One Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // teamOneXP
            // 
            this.teamOneXP.AutoSize = true;
            this.teamOneXP.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamOneXP.Location = new System.Drawing.Point(6, 73);
            this.teamOneXP.Name = "teamOneXP";
            this.teamOneXP.Size = new System.Drawing.Size(92, 20);
            this.teamOneXP.TabIndex = 30;
            this.teamOneXP.Text = "Experience:";
            // 
            // teamOneXPLBL
            // 
            this.teamOneXPLBL.AutoSize = true;
            this.teamOneXPLBL.Location = new System.Drawing.Point(95, 76);
            this.teamOneXPLBL.Name = "teamOneXPLBL";
            this.teamOneXPLBL.Size = new System.Drawing.Size(24, 17);
            this.teamOneXPLBL.TabIndex = 29;
            this.teamOneXPLBL.Text = "00";
            // 
            // totalCountOneLBL
            // 
            this.totalCountOneLBL.AutoSize = true;
            this.totalCountOneLBL.Location = new System.Drawing.Point(130, 112);
            this.totalCountOneLBL.Name = "totalCountOneLBL";
            this.totalCountOneLBL.Size = new System.Drawing.Size(24, 17);
            this.totalCountOneLBL.TabIndex = 28;
            this.totalCountOneLBL.Text = "00";
            // 
            // team1Total
            // 
            this.team1Total.AutoSize = true;
            this.team1Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team1Total.Location = new System.Drawing.Point(7, 112);
            this.team1Total.Name = "team1Total";
            this.team1Total.Size = new System.Drawing.Size(117, 17);
            this.team1Total.TabIndex = 27;
            this.team1Total.Text = "Combat Points:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.teamTwoXP);
            this.groupBox2.Controls.Add(this.teamTwoXPLBL);
            this.groupBox2.Controls.Add(this.totalCountTwoLBL);
            this.groupBox2.Controls.Add(this.recourseNameTwo);
            this.groupBox2.Controls.Add(this.Team2Total);
            this.groupBox2.Controls.Add(this.lblCurrency2);
            this.groupBox2.Location = new System.Drawing.Point(968, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 161);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Team Two Information";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // teamTwoXP
            // 
            this.teamTwoXP.AutoSize = true;
            this.teamTwoXP.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamTwoXP.Location = new System.Drawing.Point(6, 73);
            this.teamTwoXP.Name = "teamTwoXP";
            this.teamTwoXP.Size = new System.Drawing.Size(92, 20);
            this.teamTwoXP.TabIndex = 32;
            this.teamTwoXP.Text = "Experience:";
            // 
            // teamTwoXPLBL
            // 
            this.teamTwoXPLBL.AutoSize = true;
            this.teamTwoXPLBL.Location = new System.Drawing.Point(95, 75);
            this.teamTwoXPLBL.Name = "teamTwoXPLBL";
            this.teamTwoXPLBL.Size = new System.Drawing.Size(24, 17);
            this.teamTwoXPLBL.TabIndex = 31;
            this.teamTwoXPLBL.Text = "00";
            // 
            // totalCountTwoLBL
            // 
            this.totalCountTwoLBL.AutoSize = true;
            this.totalCountTwoLBL.Location = new System.Drawing.Point(122, 112);
            this.totalCountTwoLBL.Name = "totalCountTwoLBL";
            this.totalCountTwoLBL.Size = new System.Drawing.Size(24, 17);
            this.totalCountTwoLBL.TabIndex = 30;
            this.totalCountTwoLBL.Text = "00";
            // 
            // recourseNameTwo
            // 
            this.recourseNameTwo.AutoSize = true;
            this.recourseNameTwo.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recourseNameTwo.Location = new System.Drawing.Point(6, 42);
            this.recourseNameTwo.Name = "recourseNameTwo";
            this.recourseNameTwo.Size = new System.Drawing.Size(46, 20);
            this.recourseNameTwo.TabIndex = 28;
            this.recourseNameTwo.Text = "Gold:";
            // 
            // Team2Total
            // 
            this.Team2Total.AutoSize = true;
            this.Team2Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team2Total.Location = new System.Drawing.Point(7, 112);
            this.Team2Total.Name = "Team2Total";
            this.Team2Total.Size = new System.Drawing.Size(117, 17);
            this.Team2Total.TabIndex = 29;
            this.Team2Total.Text = "Combat Points:";
            // 
            // lblCurrency2
            // 
            this.lblCurrency2.AutoSize = true;
            this.lblCurrency2.Location = new System.Drawing.Point(57, 44);
            this.lblCurrency2.Name = "lblCurrency2";
            this.lblCurrency2.Size = new System.Drawing.Size(24, 17);
            this.lblCurrency2.TabIndex = 27;
            this.lblCurrency2.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(610, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 33);
            this.label2.TabIndex = 25;
            this.label2.Text = "The Pendant ";
            // 
            // rtsGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1263, 653);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mapGrid);
            this.Controls.Add(this.lblMilSec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.punctuationOne);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.simulationInfo);
            this.Controls.Add(this.gamePause);
            this.Controls.Add(this.gameStart);
            this.Controls.Add(this.teamNameOne);
            this.Controls.Add(this.lblMins);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rtsGame";
            this.Text = "RTS Simulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label teamNameOne;
        private System.Windows.Forms.Button gameStart;
        private System.Windows.Forms.Button gamePause;
        private System.Windows.Forms.TextBox simulationInfo;
        private System.Windows.Forms.Label lblMins;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label punctuationOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMilSec;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.TableLayoutPanel mapGrid;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label resourceName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label teamOneXP;
        private System.Windows.Forms.Label teamOneXPLBL;
        private System.Windows.Forms.Label totalCountOneLBL;
        private System.Windows.Forms.Label team1Total;
        private System.Windows.Forms.Label teamTwoXP;
        private System.Windows.Forms.Label teamTwoXPLBL;
        private System.Windows.Forms.Label totalCountTwoLBL;
        private System.Windows.Forms.Label recourseNameTwo;
        private System.Windows.Forms.Label Team2Total;
        private System.Windows.Forms.Label lblCurrency2;
        private System.Windows.Forms.Label label2;
    }
}

