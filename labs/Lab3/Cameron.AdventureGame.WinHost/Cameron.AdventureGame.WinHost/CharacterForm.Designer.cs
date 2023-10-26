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
            this._SaveButton = new System.Windows.Forms.Button();
            this._CancelButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this._StrengthUpDown = new System.Windows.Forms.NumericUpDown();
            this._AgilityUpDown = new System.Windows.Forms.NumericUpDown();
            this._IntellectUpDown = new System.Windows.Forms.NumericUpDown();
            this._CharismaUpDown = new System.Windows.Forms.NumericUpDown();
            this._DefenseUpDown = new System.Windows.Forms.NumericUpDown();
            this._ConstUpDown = new System.Windows.Forms.NumericUpDown();
            this.characterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FreePointLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._StrengthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AgilityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._IntellectUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CharismaUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DefenseUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ConstUpDown)).BeginInit();
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
            // _SaveButton
            // 
            this._SaveButton.Location = new System.Drawing.Point(589, 201);
            this._SaveButton.Name = "_SaveButton";
            this._SaveButton.Size = new System.Drawing.Size(124, 42);
            this._SaveButton.TabIndex = 13;
            this._SaveButton.Text = "Save";
            this._SaveButton.UseVisualStyleBackColor = true;
            this._SaveButton.Click += new System.EventHandler(this.OnSave);
            // 
            // _CancelButton
            // 
            this._CancelButton.Location = new System.Drawing.Point(589, 276);
            this._CancelButton.Name = "_CancelButton";
            this._CancelButton.Size = new System.Drawing.Size(127, 42);
            this._CancelButton.TabIndex = 14;
            this._CancelButton.Text = "Cancel";
            this._CancelButton.UseVisualStyleBackColor = true;
            this._CancelButton.Click += new System.EventHandler(this.OnCancel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Strength";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Agility";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Intellect";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Charisma";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Defense";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(266, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "Constitution";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(362, 411);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(233, 25);
            this.label10.TabIndex = 28;
            this.label10.Text = "Available Status Points";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 51);
            this.button1.TabIndex = 29;
            this.button1.Text = "Randomize";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // _StrengthUpDown
            // 
            this._StrengthUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.characterBindingSource, "Strength", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
            this._StrengthUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.characterBindingSource, "Strength", true));
            this._StrengthUpDown.Location = new System.Drawing.Point(60, 143);
            this._StrengthUpDown.Name = "_StrengthUpDown";
            this._StrengthUpDown.Size = new System.Drawing.Size(120, 31);
            this._StrengthUpDown.TabIndex = 30;
            this._StrengthUpDown.ValueChanged += new System.EventHandler(this._StrengthUpDown_ValueChanged);
            // 
            // _AgilityUpDown
            // 
            this._AgilityUpDown.Location = new System.Drawing.Point(60, 214);
            this._AgilityUpDown.Name = "_AgilityUpDown";
            this._AgilityUpDown.Size = new System.Drawing.Size(120, 31);
            this._AgilityUpDown.TabIndex = 31;
            this._AgilityUpDown.ValueChanged += new System.EventHandler(this._AgilityUpDown_ValueChanged);
            // 
            // _IntellectUpDown
            // 
            this._IntellectUpDown.Location = new System.Drawing.Point(60, 295);
            this._IntellectUpDown.Name = "_IntellectUpDown";
            this._IntellectUpDown.Size = new System.Drawing.Size(120, 31);
            this._IntellectUpDown.TabIndex = 32;
            this._IntellectUpDown.ValueChanged += new System.EventHandler(this._IntellectUpDown_ValueChanged);
            // 
            // _CharismaUpDown
            // 
            this._CharismaUpDown.Location = new System.Drawing.Point(60, 375);
            this._CharismaUpDown.Name = "_CharismaUpDown";
            this._CharismaUpDown.Size = new System.Drawing.Size(120, 31);
            this._CharismaUpDown.TabIndex = 33;
            this._CharismaUpDown.ValueChanged += new System.EventHandler(this._CharismaUpDown_ValueChanged);
            // 
            // _DefenseUpDown
            // 
            this._DefenseUpDown.Location = new System.Drawing.Point(271, 186);
            this._DefenseUpDown.Name = "_DefenseUpDown";
            this._DefenseUpDown.Size = new System.Drawing.Size(120, 31);
            this._DefenseUpDown.TabIndex = 34;
            this._DefenseUpDown.ValueChanged += new System.EventHandler(this._DefenseUpDown_ValueChanged);
            // 
            // _ConstUpDown
            // 
            this._ConstUpDown.Location = new System.Drawing.Point(271, 286);
            this._ConstUpDown.Name = "_ConstUpDown";
            this._ConstUpDown.Size = new System.Drawing.Size(120, 31);
            this._ConstUpDown.TabIndex = 35;
            this._ConstUpDown.ValueChanged += new System.EventHandler(this._ConstUpDown_ValueChanged);
            // 
            // characterBindingSource
            // 
            this.characterBindingSource.DataSource = typeof(Cameron.AdventureGame.Character);
            // 
            // FreePointLabel
            // 
            this.FreePointLabel.AutoSize = true;
            this.FreePointLabel.Location = new System.Drawing.Point(437, 375);
            this.FreePointLabel.Name = "FreePointLabel";
            this.FreePointLabel.Size = new System.Drawing.Size(82, 25);
            this.FreePointLabel.TabIndex = 36;
            this.FreePointLabel.Text = "label11";
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 476);
            this.Controls.Add(this.FreePointLabel);
            this.Controls.Add(this._ConstUpDown);
            this.Controls.Add(this._DefenseUpDown);
            this.Controls.Add(this._CharismaUpDown);
            this.Controls.Add(this._IntellectUpDown);
            this.Controls.Add(this._AgilityUpDown);
            this.Controls.Add(this._StrengthUpDown);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._CancelButton);
            this.Controls.Add(this._SaveButton);
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
            ((System.ComponentModel.ISupportInitialize)(this._StrengthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AgilityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._IntellectUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CharismaUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DefenseUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ConstUpDown)).EndInit();
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
        private System.Windows.Forms.Button _SaveButton;
        private System.Windows.Forms.Button _CancelButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource characterBindingSource;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown _StrengthUpDown;
        private System.Windows.Forms.NumericUpDown _AgilityUpDown;
        private System.Windows.Forms.NumericUpDown _IntellectUpDown;
        private System.Windows.Forms.NumericUpDown _CharismaUpDown;
        private System.Windows.Forms.NumericUpDown _DefenseUpDown;
        private System.Windows.Forms.NumericUpDown _ConstUpDown;
        private System.Windows.Forms.Label FreePointLabel;
    }
}