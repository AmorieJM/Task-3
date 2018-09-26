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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.generateRangedUnits = new System.Windows.Forms.Label();
            this.rangedUnitName = new System.Windows.Forms.Label();
            this.rangedUnits = new System.Windows.Forms.PictureBox();
            this.rangedTextB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.generateMeleeUnits = new System.Windows.Forms.Label();
            this.meleeUnitName = new System.Windows.Forms.Label();
            this.meleeUnit = new System.Windows.Forms.PictureBox();
            this.meleeTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.resourceName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rangedUnits)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meleeUnit)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.generateRangedUnits);
            this.groupBox1.Controls.Add(this.rangedUnitName);
            this.groupBox1.Controls.Add(this.rangedUnits);
            this.groupBox1.Controls.Add(this.rangedTextB);
            this.groupBox1.Location = new System.Drawing.Point(629, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 350);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ranged Unit Information";
            // 
            // generateRangedUnits
            // 
            this.generateRangedUnits.AutoSize = true;
            this.generateRangedUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateRangedUnits.Location = new System.Drawing.Point(25, 226);
            this.generateRangedUnits.Name = "generateRangedUnits";
            this.generateRangedUnits.Size = new System.Drawing.Size(81, 17);
            this.generateRangedUnits.TabIndex = 27;
            this.generateRangedUnits.Text = "Generate:";
            // 
            // rangedUnitName
            // 
            this.rangedUnitName.AutoSize = true;
            this.rangedUnitName.Font = new System.Drawing.Font("Colonna MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangedUnitName.Location = new System.Drawing.Point(54, 171);
            this.rangedUnitName.Name = "rangedUnitName";
            this.rangedUnitName.Size = new System.Drawing.Size(112, 30);
            this.rangedUnitName.TabIndex = 26;
            this.rangedUnitName.Text = "Archers";
            // 
            // rangedUnits
            // 
            this.rangedUnits.Image = ((System.Drawing.Image)(resources.GetObject("rangedUnits.Image")));
            this.rangedUnits.Location = new System.Drawing.Point(60, 51);
            this.rangedUnits.Name = "rangedUnits";
            this.rangedUnits.Size = new System.Drawing.Size(106, 117);
            this.rangedUnits.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rangedUnits.TabIndex = 25;
            this.rangedUnits.TabStop = false;
            this.rangedUnits.Click += new System.EventHandler(this.rangedUnits_Click);
            // 
            // rangedTextB
            // 
            this.rangedTextB.Location = new System.Drawing.Point(162, 223);
            this.rangedTextB.Name = "rangedTextB";
            this.rangedTextB.Size = new System.Drawing.Size(76, 22);
            this.rangedTextB.TabIndex = 24;
            this.rangedTextB.TextChanged += new System.EventHandler(this.rangedTextB_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.generateMeleeUnits);
            this.groupBox2.Controls.Add(this.meleeUnitName);
            this.groupBox2.Controls.Add(this.meleeUnit);
            this.groupBox2.Controls.Add(this.meleeTextBox);
            this.groupBox2.Location = new System.Drawing.Point(973, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 350);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Melee Unit Information";
            // 
            // generateMeleeUnits
            // 
            this.generateMeleeUnits.AutoSize = true;
            this.generateMeleeUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateMeleeUnits.Location = new System.Drawing.Point(55, 228);
            this.generateMeleeUnits.Name = "generateMeleeUnits";
            this.generateMeleeUnits.Size = new System.Drawing.Size(81, 17);
            this.generateMeleeUnits.TabIndex = 28;
            this.generateMeleeUnits.Text = "Generate:";
            // 
            // meleeUnitName
            // 
            this.meleeUnitName.AutoSize = true;
            this.meleeUnitName.Font = new System.Drawing.Font("Colonna MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meleeUnitName.Location = new System.Drawing.Point(52, 171);
            this.meleeUnitName.Name = "meleeUnitName";
            this.meleeUnitName.Size = new System.Drawing.Size(123, 30);
            this.meleeUnitName.TabIndex = 27;
            this.meleeUnitName.Text = "Pikemen";
            // 
            // meleeUnit
            // 
            this.meleeUnit.Image = ((System.Drawing.Image)(resources.GetObject("meleeUnit.Image")));
            this.meleeUnit.Location = new System.Drawing.Point(58, 51);
            this.meleeUnit.Name = "meleeUnit";
            this.meleeUnit.Size = new System.Drawing.Size(106, 117);
            this.meleeUnit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.meleeUnit.TabIndex = 26;
            this.meleeUnit.TabStop = false;
            this.meleeUnit.Click += new System.EventHandler(this.meleeUnit_Click);
            // 
            // meleeTextBox
            // 
            this.meleeTextBox.Location = new System.Drawing.Point(162, 223);
            this.meleeTextBox.Name = "meleeTextBox";
            this.meleeTextBox.Size = new System.Drawing.Size(76, 22);
            this.meleeTextBox.TabIndex = 28;
            this.meleeTextBox.TextChanged += new System.EventHandler(this.meleeTextBox_TextChanged);
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
            this.lblCurrency.Location = new System.Drawing.Point(941, 61);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(24, 17);
            this.lblCurrency.TabIndex = 25;
            this.lblCurrency.Text = "00";
            // 
            // resourceName
            // 
            this.resourceName.AutoSize = true;
            this.resourceName.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resourceName.Location = new System.Drawing.Point(878, 59);
            this.resourceName.Name = "resourceName";
            this.resourceName.Size = new System.Drawing.Size(45, 20);
            this.resourceName.TabIndex = 26;
            this.resourceName.Text = "Obol:";
            // 
            // rtsGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1263, 653);
            this.Controls.Add(this.resourceName);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox2);
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
            ((System.ComponentModel.ISupportInitialize)(this.rangedUnits)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meleeUnit)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox rangedUnits;
        private System.Windows.Forms.TextBox rangedTextB;
        private System.Windows.Forms.TextBox meleeTextBox;
        private System.Windows.Forms.PictureBox meleeUnit;
        private System.Windows.Forms.Label rangedUnitName;
        private System.Windows.Forms.Label meleeUnitName;
        private System.Windows.Forms.Label generateRangedUnits;
        private System.Windows.Forms.Label generateMeleeUnits;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label resourceName;
    }
}

