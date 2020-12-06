
namespace FarmerCrossing
{
    partial class FarmerCrossing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FarmerCrossing));
            this.picCornRight = new System.Windows.Forms.PictureBox();
            this.picWolfRight = new System.Windows.Forms.PictureBox();
            this.picDuckRight = new System.Windows.Forms.PictureBox();
            this.picBoat = new System.Windows.Forms.PictureBox();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnEndGame = new System.Windows.Forms.Button();
            this.picColliderRight = new System.Windows.Forms.PictureBox();
            this.picCornLeft = new System.Windows.Forms.PictureBox();
            this.picWolfLeft = new System.Windows.Forms.PictureBox();
            this.picDuckLeft = new System.Windows.Forms.PictureBox();
            this.picColliderLeft = new System.Windows.Forms.PictureBox();
            this.radDuck = new System.Windows.Forms.RadioButton();
            this.radWolf = new System.Windows.Forms.RadioButton();
            this.radCorn = new System.Windows.Forms.RadioButton();
            this.picBoatLeft = new System.Windows.Forms.PictureBox();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCornRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWolfRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDuckRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColliderRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCornLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWolfLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDuckLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColliderLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoatLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // picCornRight
            // 
            this.picCornRight.BackColor = System.Drawing.Color.Transparent;
            this.picCornRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picCornRight.Image = ((System.Drawing.Image)(resources.GetObject("picCornRight.Image")));
            this.picCornRight.Location = new System.Drawing.Point(895, 342);
            this.picCornRight.Name = "picCornRight";
            this.picCornRight.Size = new System.Drawing.Size(71, 72);
            this.picCornRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCornRight.TabIndex = 10;
            this.picCornRight.TabStop = false;
            // 
            // picWolfRight
            // 
            this.picWolfRight.BackColor = System.Drawing.Color.Transparent;
            this.picWolfRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picWolfRight.Image = ((System.Drawing.Image)(resources.GetObject("picWolfRight.Image")));
            this.picWolfRight.Location = new System.Drawing.Point(895, 464);
            this.picWolfRight.Name = "picWolfRight";
            this.picWolfRight.Size = new System.Drawing.Size(71, 72);
            this.picWolfRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWolfRight.TabIndex = 8;
            this.picWolfRight.TabStop = false;
            // 
            // picDuckRight
            // 
            this.picDuckRight.BackColor = System.Drawing.Color.Transparent;
            this.picDuckRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picDuckRight.Image = ((System.Drawing.Image)(resources.GetObject("picDuckRight.Image")));
            this.picDuckRight.Location = new System.Drawing.Point(895, 604);
            this.picDuckRight.Name = "picDuckRight";
            this.picDuckRight.Size = new System.Drawing.Size(71, 72);
            this.picDuckRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDuckRight.TabIndex = 6;
            this.picDuckRight.TabStop = false;
            // 
            // picBoat
            // 
            this.picBoat.BackColor = System.Drawing.Color.Transparent;
            this.picBoat.Image = ((System.Drawing.Image)(resources.GetObject("picBoat.Image")));
            this.picBoat.Location = new System.Drawing.Point(788, 486);
            this.picBoat.Name = "picBoat";
            this.picBoat.Size = new System.Drawing.Size(71, 50);
            this.picBoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoat.TabIndex = 14;
            this.picBoat.TabStop = false;
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMoveLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveLeft.Location = new System.Drawing.Point(524, 967);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(153, 50);
            this.btnMoveLeft.TabIndex = 15;
            this.btnMoveLeft.Text = "<-- Move Left";
            this.btnMoveLeft.UseVisualStyleBackColor = false;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // btnEndGame
            // 
            this.btnEndGame.BackColor = System.Drawing.Color.DarkRed;
            this.btnEndGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndGame.Location = new System.Drawing.Point(969, 2);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.Size = new System.Drawing.Size(57, 47);
            this.btnEndGame.TabIndex = 16;
            this.btnEndGame.Text = "X";
            this.btnEndGame.UseVisualStyleBackColor = false;
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
            // 
            // picColliderRight
            // 
            this.picColliderRight.BackColor = System.Drawing.Color.Transparent;
            this.picColliderRight.Location = new System.Drawing.Point(843, 374);
            this.picColliderRight.Name = "picColliderRight";
            this.picColliderRight.Size = new System.Drawing.Size(100, 280);
            this.picColliderRight.TabIndex = 13;
            this.picColliderRight.TabStop = false;
            // 
            // picCornLeft
            // 
            this.picCornLeft.BackColor = System.Drawing.Color.Transparent;
            this.picCornLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picCornLeft.Image = ((System.Drawing.Image)(resources.GetObject("picCornLeft.Image")));
            this.picCornLeft.Location = new System.Drawing.Point(54, 342);
            this.picCornLeft.Name = "picCornLeft";
            this.picCornLeft.Size = new System.Drawing.Size(71, 72);
            this.picCornLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCornLeft.TabIndex = 19;
            this.picCornLeft.TabStop = false;
            // 
            // picWolfLeft
            // 
            this.picWolfLeft.BackColor = System.Drawing.Color.Transparent;
            this.picWolfLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picWolfLeft.Enabled = false;
            this.picWolfLeft.Image = ((System.Drawing.Image)(resources.GetObject("picWolfLeft.Image")));
            this.picWolfLeft.Location = new System.Drawing.Point(54, 464);
            this.picWolfLeft.Name = "picWolfLeft";
            this.picWolfLeft.Size = new System.Drawing.Size(71, 72);
            this.picWolfLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWolfLeft.TabIndex = 18;
            this.picWolfLeft.TabStop = false;
            // 
            // picDuckLeft
            // 
            this.picDuckLeft.BackColor = System.Drawing.Color.Transparent;
            this.picDuckLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picDuckLeft.Enabled = false;
            this.picDuckLeft.Image = ((System.Drawing.Image)(resources.GetObject("picDuckLeft.Image")));
            this.picDuckLeft.Location = new System.Drawing.Point(54, 604);
            this.picDuckLeft.Name = "picDuckLeft";
            this.picDuckLeft.Size = new System.Drawing.Size(71, 72);
            this.picDuckLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDuckLeft.TabIndex = 17;
            this.picDuckLeft.TabStop = false;
            // 
            // picColliderLeft
            // 
            this.picColliderLeft.BackColor = System.Drawing.Color.Transparent;
            this.picColliderLeft.Location = new System.Drawing.Point(94, 374);
            this.picColliderLeft.Name = "picColliderLeft";
            this.picColliderLeft.Size = new System.Drawing.Size(100, 280);
            this.picColliderLeft.TabIndex = 20;
            this.picColliderLeft.TabStop = false;
            // 
            // radDuck
            // 
            this.radDuck.AutoSize = true;
            this.radDuck.BackColor = System.Drawing.Color.Transparent;
            this.radDuck.Location = new System.Drawing.Point(365, 924);
            this.radDuck.Name = "radDuck";
            this.radDuck.Size = new System.Drawing.Size(51, 17);
            this.radDuck.TabIndex = 21;
            this.radDuck.TabStop = true;
            this.radDuck.Text = "Duck";
            this.radDuck.UseVisualStyleBackColor = false;
            // 
            // radWolf
            // 
            this.radWolf.AutoSize = true;
            this.radWolf.BackColor = System.Drawing.Color.Transparent;
            this.radWolf.Location = new System.Drawing.Point(498, 924);
            this.radWolf.Name = "radWolf";
            this.radWolf.Size = new System.Drawing.Size(47, 17);
            this.radWolf.TabIndex = 22;
            this.radWolf.TabStop = true;
            this.radWolf.Text = "Wolf";
            this.radWolf.UseVisualStyleBackColor = false;
            // 
            // radCorn
            // 
            this.radCorn.AutoSize = true;
            this.radCorn.BackColor = System.Drawing.Color.Transparent;
            this.radCorn.Location = new System.Drawing.Point(630, 924);
            this.radCorn.Name = "radCorn";
            this.radCorn.Size = new System.Drawing.Size(47, 17);
            this.radCorn.TabIndex = 23;
            this.radCorn.TabStop = true;
            this.radCorn.Text = "Corn";
            this.radCorn.UseVisualStyleBackColor = false;
            // 
            // picBoatLeft
            // 
            this.picBoatLeft.BackColor = System.Drawing.Color.Transparent;
            this.picBoatLeft.Enabled = false;
            this.picBoatLeft.Image = ((System.Drawing.Image)(resources.GetObject("picBoatLeft.Image")));
            this.picBoatLeft.Location = new System.Drawing.Point(177, 486);
            this.picBoatLeft.Name = "picBoatLeft";
            this.picBoatLeft.Size = new System.Drawing.Size(71, 50);
            this.picBoatLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoatLeft.TabIndex = 24;
            this.picBoatLeft.TabStop = false;
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMoveRight.Enabled = false;
            this.btnMoveRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveRight.Location = new System.Drawing.Point(365, 967);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(153, 50);
            this.btnMoveRight.TabIndex = 25;
            this.btnMoveRight.Text = "Move Right -->";
            this.btnMoveRight.UseVisualStyleBackColor = false;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(683, 967);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(47, 50);
            this.btnHelp.TabIndex = 26;
            this.btnHelp.Text = "i";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // FarmerCrossing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1026, 1029);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.picBoatLeft);
            this.Controls.Add(this.radCorn);
            this.Controls.Add(this.radWolf);
            this.Controls.Add(this.radDuck);
            this.Controls.Add(this.picCornLeft);
            this.Controls.Add(this.picWolfLeft);
            this.Controls.Add(this.picDuckLeft);
            this.Controls.Add(this.picColliderLeft);
            this.Controls.Add(this.btnEndGame);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.picBoat);
            this.Controls.Add(this.picCornRight);
            this.Controls.Add(this.picWolfRight);
            this.Controls.Add(this.picDuckRight);
            this.Controls.Add(this.picColliderRight);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FarmerCrossing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FamerCrossing";
            this.Load += new System.EventHandler(this.FarmerCrossing_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FarmerCrossing_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picCornRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWolfRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDuckRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColliderRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCornLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWolfLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDuckLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColliderLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoatLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picCornRight;
        private System.Windows.Forms.PictureBox picWolfRight;
        private System.Windows.Forms.PictureBox picDuckRight;
        private System.Windows.Forms.PictureBox picBoat;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnEndGame;
        private System.Windows.Forms.PictureBox picColliderRight;
        private System.Windows.Forms.PictureBox picCornLeft;
        private System.Windows.Forms.PictureBox picWolfLeft;
        private System.Windows.Forms.PictureBox picDuckLeft;
        private System.Windows.Forms.PictureBox picColliderLeft;
        private System.Windows.Forms.RadioButton radDuck;
        private System.Windows.Forms.RadioButton radWolf;
        private System.Windows.Forms.RadioButton radCorn;
        private System.Windows.Forms.PictureBox picBoatLeft;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnHelp;
    }
}

