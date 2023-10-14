namespace Cameron.AdventureGame.WinHost
{
    partial class CharacterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
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
        private void InitializeComponent ()
        {
            this._CharacterNameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._RaceComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this._ClassComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _CharacterNameTxtBox
            // 
            this._CharacterNameTxtBox.Location = new System.Drawing.Point(12, 41);
            this._CharacterNameTxtBox.Name = "_CharacterNameTxtBox";
            this._CharacterNameTxtBox.Size = new System.Drawing.Size(276, 31);
            this._CharacterNameTxtBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Character Name";
            // 
            // _RaceComboBox
            // 
            this._RaceComboBox.FormattingEnabled = true;
            this._RaceComboBox.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Gnome",
            "Human",
            "Gnoll"});
            this._RaceComboBox.Location = new System.Drawing.Point(323, 39);
            this._RaceComboBox.Name = "_RaceComboBox";
            this._RaceComboBox.Size = new System.Drawing.Size(183, 33);
            this._RaceComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Race";
            // 
            // _ClassComboBox
            // 
            this._ClassComboBox.FormattingEnabled = true;
            this._ClassComboBox.Items.AddRange(new object[] {
            "Paladin",
            "Cleric",
            "Warrior",
            "Rogue",
            "Mage",
            "Wizard",
            "Spell Sword",
            "Shield Warden"});
            this._ClassComboBox.Location = new System.Drawing.Point(530, 38);
            this._ClassComboBox.Name = "_ClassComboBox";
            this._ClassComboBox.Size = new System.Drawing.Size(245, 33);
            this._ClassComboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Class/Profession";
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._ClassComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._RaceComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._CharacterNameTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharacterForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Character";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _CharacterNameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _RaceComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _ClassComboBox;
        private System.Windows.Forms.Label label3;
    }
}