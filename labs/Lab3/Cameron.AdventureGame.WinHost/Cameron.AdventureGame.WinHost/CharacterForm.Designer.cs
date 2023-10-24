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
            this.components = new System.ComponentModel.Container();
            this._CharacterNameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._RaceComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this._ClassComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this._RandomToonButton = new System.Windows.Forms.Button();
            this._SaveButton = new System.Windows.Forms.Button();
            this._CancelButton = new System.Windows.Forms.Button();
            this._StrengthListBox = new System.Windows.Forms.ListBox();
            this._AgilityListBox = new System.Windows.Forms.ListBox();
            this._IntellectListBox = new System.Windows.Forms.ListBox();
            this._CharismaListBox = new System.Windows.Forms.ListBox();
            this._DefenseListBox = new System.Windows.Forms.ListBox();
            this._ConstitutionListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.characterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).BeginInit();
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
            this._RaceComboBox.Location = new System.Drawing.Point(307, 38);
            this._RaceComboBox.Name = "_RaceComboBox";
            this._RaceComboBox.Size = new System.Drawing.Size(183, 33);
            this._RaceComboBox.TabIndex = 2;
            this._RaceComboBox.SelectedIndexChanged += new System.EventHandler(this.OnRaceChoice);
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
            this._ClassComboBox.SelectedIndexChanged += new System.EventHandler(this.OnClassChoice);
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
            // _RandomToonButton
            // 
            this._RandomToonButton.Location = new System.Drawing.Point(60, 384);
            this._RandomToonButton.Name = "_RandomToonButton";
            this._RandomToonButton.Size = new System.Drawing.Size(228, 54);
            this._RandomToonButton.TabIndex = 12;
            this._RandomToonButton.Text = "Random Character";
            this._RandomToonButton.UseVisualStyleBackColor = true;
            this._RandomToonButton.Click += new System.EventHandler(this.OnRandom);
            // 
            // _SaveButton
            // 
            this._SaveButton.Location = new System.Drawing.Point(398, 384);
            this._SaveButton.Name = "_SaveButton";
            this._SaveButton.Size = new System.Drawing.Size(124, 42);
            this._SaveButton.TabIndex = 13;
            this._SaveButton.Text = "Save";
            this._SaveButton.UseVisualStyleBackColor = true;
            this._SaveButton.Click += new System.EventHandler(this.OnSave);
            // 
            // _CancelButton
            // 
            this._CancelButton.Location = new System.Drawing.Point(589, 384);
            this._CancelButton.Name = "_CancelButton";
            this._CancelButton.Size = new System.Drawing.Size(127, 42);
            this._CancelButton.TabIndex = 14;
            this._CancelButton.Text = "Cancel";
            this._CancelButton.UseVisualStyleBackColor = true;
            this._CancelButton.Click += new System.EventHandler(this.OnCancel);
            // 
            // _StrengthListBox
            // 
            this._StrengthListBox.FormattingEnabled = true;
            this._StrengthListBox.ItemHeight = 25;
            this._StrengthListBox.Location = new System.Drawing.Point(13, 106);
            this._StrengthListBox.Name = "_StrengthListBox";
            this._StrengthListBox.Size = new System.Drawing.Size(94, 29);
            this._StrengthListBox.TabIndex = 15;
            this._StrengthListBox.SelectedIndexChanged += new System.EventHandler(this._StrengthListBox_SelectedIndexChanged);
            // 
            // _AgilityListBox
            // 
            this._AgilityListBox.FormattingEnabled = true;
            this._AgilityListBox.ItemHeight = 25;
            this._AgilityListBox.Location = new System.Drawing.Point(12, 165);
            this._AgilityListBox.Name = "_AgilityListBox";
            this._AgilityListBox.Size = new System.Drawing.Size(94, 29);
            this._AgilityListBox.TabIndex = 16;
            // 
            // _IntellectListBox
            // 
            this._IntellectListBox.FormattingEnabled = true;
            this._IntellectListBox.ItemHeight = 25;
            this._IntellectListBox.Location = new System.Drawing.Point(13, 230);
            this._IntellectListBox.Name = "_IntellectListBox";
            this._IntellectListBox.Size = new System.Drawing.Size(94, 29);
            this._IntellectListBox.TabIndex = 17;
            // 
            // _CharismaListBox
            // 
            this._CharismaListBox.FormattingEnabled = true;
            this._CharismaListBox.ItemHeight = 25;
            this._CharismaListBox.Location = new System.Drawing.Point(13, 295);
            this._CharismaListBox.Name = "_CharismaListBox";
            this._CharismaListBox.Size = new System.Drawing.Size(94, 29);
            this._CharismaListBox.TabIndex = 18;
            // 
            // _DefenseListBox
            // 
            this._DefenseListBox.FormattingEnabled = true;
            this._DefenseListBox.ItemHeight = 25;
            this._DefenseListBox.Location = new System.Drawing.Point(272, 154);
            this._DefenseListBox.Name = "_DefenseListBox";
            this._DefenseListBox.Size = new System.Drawing.Size(94, 29);
            this._DefenseListBox.TabIndex = 19;
            // 
            // _ConstitutionListBox
            // 
            this._ConstitutionListBox.FormattingEnabled = true;
            this._ConstitutionListBox.ItemHeight = 25;
            this._ConstitutionListBox.Location = new System.Drawing.Point(272, 244);
            this._ConstitutionListBox.Name = "_ConstitutionListBox";
            this._ConstitutionListBox.Size = new System.Drawing.Size(94, 29);
            this._ConstitutionListBox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Strength";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Agility";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Intellect";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Charisma";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Defense";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "Constitution";
            // 
            // characterBindingSource
            // 
            this.characterBindingSource.DataSource = typeof(Cameron.AdventureGame.Character);
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 476);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._ConstitutionListBox);
            this.Controls.Add(this._DefenseListBox);
            this.Controls.Add(this._CharismaListBox);
            this.Controls.Add(this._IntellectListBox);
            this.Controls.Add(this._AgilityListBox);
            this.Controls.Add(this._StrengthListBox);
            this.Controls.Add(this._CancelButton);
            this.Controls.Add(this._SaveButton);
            this.Controls.Add(this._RandomToonButton);
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
            this.Load += new System.EventHandler(this.CharacterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).EndInit();
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
        private System.Windows.Forms.Button _RandomToonButton;
        private System.Windows.Forms.Button _SaveButton;
        private System.Windows.Forms.Button _CancelButton;
        private System.Windows.Forms.ListBox _StrengthListBox;
        private System.Windows.Forms.ListBox _AgilityListBox;
        private System.Windows.Forms.ListBox _IntellectListBox;
        private System.Windows.Forms.ListBox _CharismaListBox;
        private System.Windows.Forms.ListBox _DefenseListBox;
        private System.Windows.Forms.ListBox _ConstitutionListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource characterBindingSource;
    }
}