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
            this._StrengthUpDown = new System.Windows.Forms.NumericUpDown();
            this._AgilityUpDown = new System.Windows.Forms.NumericUpDown();
            this._IntellectUpDown = new System.Windows.Forms.NumericUpDown();
            this._CharismaUpDown = new System.Windows.Forms.NumericUpDown();
            this._DefenseUpDown = new System.Windows.Forms.NumericUpDown();
            this._ConstUpDown = new System.Windows.Forms.NumericUpDown();
            this.FreePointLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.characterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._StrengthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AgilityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._IntellectUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CharismaUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DefenseUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ConstUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).BeginInit();
           this.SuspendLayout();
            // 
            // _CharacterNameTxtBox
            // 
            this.errorProvider1.SetError(this._CharacterNameTxtBox, "Name Required");
            this._CharacterNameTxtBox.Location = new System.Drawing.Point(6, 21);
            this._CharacterNameTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._CharacterNameTxtBox.Name = "_CharacterNameTxtBox";
            this._CharacterNameTxtBox.Size = new System.Drawing.Size(140, 20);
            this._CharacterNameTxtBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Character Name";
            // 
            // _RaceComboBox
            // 
            this._RaceComboBox.FormattingEnabled = true;
            this._RaceComboBox.Location = new System.Drawing.Point(154, 20);
            this._RaceComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._RaceComboBox.Name = "_RaceComboBox";
            this._RaceComboBox.Size = new System.Drawing.Size(94, 21);
            this._RaceComboBox.TabIndex = 2;
            this._RaceComboBox.SelectedIndexChanged += new System.EventHandler(this.OnRaceChoice);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
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
            this._ClassComboBox.Location = new System.Drawing.Point(265, 20);
            this._ClassComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._ClassComboBox.Name = "_ClassComboBox";
            this._ClassComboBox.Size = new System.Drawing.Size(124, 21);
            this._ClassComboBox.TabIndex = 4;
            this._ClassComboBox.SelectedIndexChanged += new System.EventHandler(this.OnClassChoice);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Class/Profession";
            // 
            // _SaveButton
            // 
            this._SaveButton.Location = new System.Drawing.Point(294, 105);
            this._SaveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._SaveButton.Name = "_SaveButton";
            this._SaveButton.Size = new System.Drawing.Size(62, 22);
            this._SaveButton.TabIndex = 13;
            this._SaveButton.Text = "Save";
            this._SaveButton.UseVisualStyleBackColor = true;
            this._SaveButton.Click += new System.EventHandler(this.OnSave);
            // 
            // _CancelButton
            // 
            this._CancelButton.Location = new System.Drawing.Point(294, 144);
            this._CancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._CancelButton.Name = "_CancelButton";
            this._CancelButton.Size = new System.Drawing.Size(64, 22);
            this._CancelButton.TabIndex = 14;
            this._CancelButton.Text = "Cancel";
            this._CancelButton.UseVisualStyleBackColor = true;
            this._CancelButton.Click += new System.EventHandler(this.OnCancel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Strength";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Agility";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Intellect";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Charisma";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Defense";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(133, 129);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Constitution";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(181, 214);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Available Status Points";
            // 
            // _StrengthUpDown
            // 
            this._StrengthUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.characterBindingSource, "Strength", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
            this._StrengthUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.characterBindingSource, "Strength", true));
            this._StrengthUpDown.Location = new System.Drawing.Point(30, 74);
            this._StrengthUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._StrengthUpDown.Name = "_StrengthUpDown";
            this._StrengthUpDown.Size = new System.Drawing.Size(60, 20);
            this._StrengthUpDown.TabIndex = 30;
            this._StrengthUpDown.ValueChanged += new System.EventHandler(this._StrengthUpDown_ValueChanged);
            // 
            // _AgilityUpDown
            // 
            this._AgilityUpDown.Location = new System.Drawing.Point(30, 111);
            this._AgilityUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._AgilityUpDown.Name = "_AgilityUpDown";
            this._AgilityUpDown.Size = new System.Drawing.Size(60, 20);
            this._AgilityUpDown.TabIndex = 31;
            this._AgilityUpDown.ValueChanged += new System.EventHandler(this._AgilityUpDown_ValueChanged);
            // 
            // _IntellectUpDown
            // 
            this._IntellectUpDown.Location = new System.Drawing.Point(30, 153);
            this._IntellectUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._IntellectUpDown.Name = "_IntellectUpDown";
            this._IntellectUpDown.Size = new System.Drawing.Size(60, 20);
            this._IntellectUpDown.TabIndex = 32;
            this._IntellectUpDown.ValueChanged += new System.EventHandler(this._IntellectUpDown_ValueChanged);
            // 
            // _CharismaUpDown
            // 
            this._CharismaUpDown.Location = new System.Drawing.Point(30, 195);
            this._CharismaUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._CharismaUpDown.Name = "_CharismaUpDown";
            this._CharismaUpDown.Size = new System.Drawing.Size(60, 20);
            this._CharismaUpDown.TabIndex = 33;
            this._CharismaUpDown.ValueChanged += new System.EventHandler(this._CharismaUpDown_ValueChanged);
            // 
            // _DefenseUpDown
            // 
            this._DefenseUpDown.Location = new System.Drawing.Point(136, 97);
            this._DefenseUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._DefenseUpDown.Name = "_DefenseUpDown";
            this._DefenseUpDown.Size = new System.Drawing.Size(60, 20);
            this._DefenseUpDown.TabIndex = 34;
            this._DefenseUpDown.ValueChanged += new System.EventHandler(this._DefenseUpDown_ValueChanged);
            // 
            // _ConstUpDown
            // 
            this._ConstUpDown.Location = new System.Drawing.Point(136, 149);
            this._ConstUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._ConstUpDown.Name = "_ConstUpDown";
            this._ConstUpDown.Size = new System.Drawing.Size(60, 20);
            this._ConstUpDown.TabIndex = 35;
            this._ConstUpDown.ValueChanged += new System.EventHandler(this._ConstUpDown_ValueChanged);
            // 
            // FreePointLabel
            // 
            this.FreePointLabel.AutoSize = true;
            this.FreePointLabel.Location = new System.Drawing.Point(218, 195);
            this.FreePointLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FreePointLabel.Name = "FreePointLabel";
            this.FreePointLabel.Size = new System.Drawing.Size(13, 13);
            this.FreePointLabel.TabIndex = 36;
            this.FreePointLabel.Text = "0";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 248);
            this.Controls.Add(this.FreePointLabel);
            this.Controls.Add(this._ConstUpDown);
            this.Controls.Add(this._DefenseUpDown);
            this.Controls.Add(this._CharismaUpDown);
            this.Controls.Add(this._IntellectUpDown);
            this.Controls.Add(this._AgilityUpDown);
            this.Controls.Add(this._StrengthUpDown);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.NumericUpDown _StrengthUpDown;
        private System.Windows.Forms.NumericUpDown _AgilityUpDown;
        private System.Windows.Forms.NumericUpDown _IntellectUpDown;
        private System.Windows.Forms.NumericUpDown _CharismaUpDown;
        private System.Windows.Forms.NumericUpDown _DefenseUpDown;
        private System.Windows.Forms.NumericUpDown _ConstUpDown;
        private System.Windows.Forms.Label FreePointLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}