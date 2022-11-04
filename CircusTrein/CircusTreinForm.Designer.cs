namespace CircusTrein
{
    partial class CircusTrein
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoegWagon = new System.Windows.Forms.Button();
            this.lbWagon = new System.Windows.Forms.ListBox();
            this.cbED = new System.Windows.Forms.CheckBox();
            this.lbCircus = new System.Windows.Forms.ListBox();
            this.btnSorteer = new System.Windows.Forms.Button();
            this.tbWagon = new System.Windows.Forms.TextBox();
            this.rbKlein = new System.Windows.Forms.RadioButton();
            this.rbMG = new System.Windows.Forms.RadioButton();
            this.rbGroot = new System.Windows.Forms.RadioButton();
            this.gpAnimal = new System.Windows.Forms.GroupBox();
            this.btnDebug = new System.Windows.Forms.Button();
            this.pbTrein = new System.Windows.Forms.PictureBox();
            this.gpAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrein)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grootte van je dier ->";
            // 
            // btnVoegWagon
            // 
            this.btnVoegWagon.Location = new System.Drawing.Point(94, 233);
            this.btnVoegWagon.Name = "btnVoegWagon";
            this.btnVoegWagon.Size = new System.Drawing.Size(103, 34);
            this.btnVoegWagon.TabIndex = 6;
            this.btnVoegWagon.Text = "Voeg Dier";
            this.btnVoegWagon.UseVisualStyleBackColor = true;
            this.btnVoegWagon.Click += new System.EventHandler(this.btnVoegWagon_Click);
            // 
            // lbWagon
            // 
            this.lbWagon.FormattingEnabled = true;
            this.lbWagon.ItemHeight = 16;
            this.lbWagon.Location = new System.Drawing.Point(414, 73);
            this.lbWagon.Name = "lbWagon";
            this.lbWagon.Size = new System.Drawing.Size(394, 324);
            this.lbWagon.TabIndex = 7;
            // 
            // cbED
            // 
            this.cbED.AutoSize = true;
            this.cbED.Location = new System.Drawing.Point(94, 191);
            this.cbED.Name = "cbED";
            this.cbED.Size = new System.Drawing.Size(135, 20);
            this.cbED.TabIndex = 8;
            this.cbED.Text = "eet andere dieren";
            this.cbED.UseVisualStyleBackColor = true;
            // 
            // lbCircus
            // 
            this.lbCircus.FormattingEnabled = true;
            this.lbCircus.ItemHeight = 16;
            this.lbCircus.Location = new System.Drawing.Point(964, 486);
            this.lbCircus.Name = "lbCircus";
            this.lbCircus.Size = new System.Drawing.Size(185, 116);
            this.lbCircus.TabIndex = 11;
            this.lbCircus.Visible = false;
            // 
            // btnSorteer
            // 
            this.btnSorteer.Location = new System.Drawing.Point(158, 405);
            this.btnSorteer.Name = "btnSorteer";
            this.btnSorteer.Size = new System.Drawing.Size(103, 46);
            this.btnSorteer.TabIndex = 12;
            this.btnSorteer.Text = "Sorteer Wagon";
            this.btnSorteer.UseVisualStyleBackColor = true;
            this.btnSorteer.Click += new System.EventHandler(this.btnSorteer_Click);
            // 
            // tbWagon
            // 
            this.tbWagon.AllowDrop = true;
            this.tbWagon.Location = new System.Drawing.Point(841, 53);
            this.tbWagon.Multiline = true;
            this.tbWagon.Name = "tbWagon";
            this.tbWagon.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbWagon.Size = new System.Drawing.Size(281, 376);
            this.tbWagon.TabIndex = 13;
            // 
            // rbKlein
            // 
            this.rbKlein.AutoSize = true;
            this.rbKlein.Location = new System.Drawing.Point(153, 68);
            this.rbKlein.Name = "rbKlein";
            this.rbKlein.Size = new System.Drawing.Size(57, 20);
            this.rbKlein.TabIndex = 14;
            this.rbKlein.TabStop = true;
            this.rbKlein.Text = "Klein";
            this.rbKlein.UseVisualStyleBackColor = true;
            // 
            // rbMG
            // 
            this.rbMG.AutoSize = true;
            this.rbMG.Location = new System.Drawing.Point(153, 105);
            this.rbMG.Name = "rbMG";
            this.rbMG.Size = new System.Drawing.Size(100, 20);
            this.rbMG.TabIndex = 15;
            this.rbMG.TabStop = true;
            this.rbMG.Text = "Middelgroot";
            this.rbMG.UseVisualStyleBackColor = true;
            // 
            // rbGroot
            // 
            this.rbGroot.AutoSize = true;
            this.rbGroot.Location = new System.Drawing.Point(153, 142);
            this.rbGroot.Name = "rbGroot";
            this.rbGroot.Size = new System.Drawing.Size(61, 20);
            this.rbGroot.TabIndex = 16;
            this.rbGroot.TabStop = true;
            this.rbGroot.Text = "Groot";
            this.rbGroot.UseVisualStyleBackColor = true;
            // 
            // gpAnimal
            // 
            this.gpAnimal.Controls.Add(this.rbKlein);
            this.gpAnimal.Controls.Add(this.rbGroot);
            this.gpAnimal.Controls.Add(this.rbMG);
            this.gpAnimal.Controls.Add(this.label1);
            this.gpAnimal.Controls.Add(this.cbED);
            this.gpAnimal.Controls.Add(this.btnVoegWagon);
            this.gpAnimal.Location = new System.Drawing.Point(64, 73);
            this.gpAnimal.Name = "gpAnimal";
            this.gpAnimal.Size = new System.Drawing.Size(283, 302);
            this.gpAnimal.TabIndex = 17;
            this.gpAnimal.TabStop = false;
            this.gpAnimal.Text = "Voeg je eigen dier toe!";
            // 
            // btnDebug
            // 
            this.btnDebug.Location = new System.Drawing.Point(1155, 597);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(15, 14);
            this.btnDebug.TabIndex = 18;
            this.btnDebug.Text = "Debug";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // pbTrein
            // 
            this.pbTrein.Location = new System.Drawing.Point(414, 405);
            this.pbTrein.Name = "pbTrein";
            this.pbTrein.Size = new System.Drawing.Size(307, 117);
            this.pbTrein.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbTrein.TabIndex = 19;
            this.pbTrein.TabStop = false;
            // 
            // CircusTrein
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 623);
            this.Controls.Add(this.pbTrein);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.gpAnimal);
            this.Controls.Add(this.tbWagon);
            this.Controls.Add(this.btnSorteer);
            this.Controls.Add(this.lbCircus);
            this.Controls.Add(this.lbWagon);
            this.Name = "CircusTrein";
            this.Text = "Circus Trein";
            this.Load += new System.EventHandler(this.CircusTrein_Load);
            this.gpAnimal.ResumeLayout(false);
            this.gpAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrein)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoegWagon;
        private System.Windows.Forms.ListBox lbWagon;
        private System.Windows.Forms.CheckBox cbED;
        private System.Windows.Forms.ListBox lbCircus;
        private System.Windows.Forms.Button btnSorteer;
        private System.Windows.Forms.TextBox tbWagon;
        private System.Windows.Forms.RadioButton rbKlein;
        private System.Windows.Forms.RadioButton rbMG;
        private System.Windows.Forms.RadioButton rbGroot;
        private System.Windows.Forms.GroupBox gpAnimal;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.PictureBox pbTrein;
    }
}

