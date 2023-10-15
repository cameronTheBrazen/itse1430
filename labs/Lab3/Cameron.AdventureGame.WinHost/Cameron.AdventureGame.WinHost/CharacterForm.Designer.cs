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
            this._StrengthStatGrid = new System.Windows.Forms.DataGridView();
            this.IntelligenceStatGrid = new System.Windows.Forms.DataGridView();
            this._DefenseStatGrid = new System.Windows.Forms.DataGridView();
            this._ConstitutionStatGrid = new System.Windows.Forms.DataGridView();
            this._AgilityStatGrid = new System.Windows.Forms.DataGridView();
            this._CharismaStatGrid = new System.Windows.Forms.DataGridView();
            this._RandomToonButton = new System.Windows.Forms.Button();
            this._SaveButton = new System.Windows.Forms.Button();
            this._CancelButton = new System.Windows.Forms.Button();
            this.charismaDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agilityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constitutionDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defenseDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intelligenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._StrengthStatGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntelligenceStatGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DefenseStatGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ConstitutionStatGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AgilityStatGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CharismaStatGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource1)).BeginInit();
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
            this._RaceComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.characterBindingSource, "SelectedRace", true));
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
            // _StrengthStatGrid
            // 
            this._StrengthStatGrid.AllowUserToAddRows = false;
            this._StrengthStatGrid.AllowUserToDeleteRows = false;
            this._StrengthStatGrid.AutoGenerateColumns = false;
            this._StrengthStatGrid.ColumnHeadersHeight = 32;
            this._StrengthStatGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._StrengthStatGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.strengthDataGridViewTextBoxColumn});
            this._StrengthStatGrid.DataSource = this.characterBindingSource1;
            this._StrengthStatGrid.Location = new System.Drawing.Point(60, 99);
            this._StrengthStatGrid.Name = "_StrengthStatGrid";
            this._StrengthStatGrid.ReadOnly = true;
            this._StrengthStatGrid.RowHeadersWidth = 82;
            this._StrengthStatGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this._StrengthStatGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DimGray;
            this._StrengthStatGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._StrengthStatGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this._StrengthStatGrid.RowTemplate.Height = 33;
            this._StrengthStatGrid.Size = new System.Drawing.Size(284, 69);
            this._StrengthStatGrid.TabIndex = 6;
            // 
            // IntelligenceStatGrid
            // 
            this.IntelligenceStatGrid.AllowUserToAddRows = false;
            this.IntelligenceStatGrid.AllowUserToDeleteRows = false;
            this.IntelligenceStatGrid.AutoGenerateColumns = false;
            this.IntelligenceStatGrid.ColumnHeadersHeight = 32;
            this.IntelligenceStatGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.IntelligenceStatGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intelligenceDataGridViewTextBoxColumn});
            this.IntelligenceStatGrid.DataSource = this.characterBindingSource;
            this.IntelligenceStatGrid.Location = new System.Drawing.Point(60, 242);
            this.IntelligenceStatGrid.Name = "IntelligenceStatGrid";
            this.IntelligenceStatGrid.ReadOnly = true;
            this.IntelligenceStatGrid.RowHeadersWidth = 82;
            this.IntelligenceStatGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.IntelligenceStatGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DimGray;
            this.IntelligenceStatGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntelligenceStatGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.IntelligenceStatGrid.RowTemplate.Height = 33;
            this.IntelligenceStatGrid.Size = new System.Drawing.Size(284, 65);
            this.IntelligenceStatGrid.TabIndex = 7;
            // 
            // _DefenseStatGrid
            // 
            this._DefenseStatGrid.AllowUserToAddRows = false;
            this._DefenseStatGrid.AllowUserToDeleteRows = false;
            this._DefenseStatGrid.AutoGenerateColumns = false;
            this._DefenseStatGrid.ColumnHeadersHeight = 32;
            this._DefenseStatGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._DefenseStatGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.defenseDataGridViewTextBoxColumn2});
            this._DefenseStatGrid.DataSource = this.characterBindingSource;
            this._DefenseStatGrid.Location = new System.Drawing.Point(347, 132);
            this._DefenseStatGrid.Name = "_DefenseStatGrid";
            this._DefenseStatGrid.ReadOnly = true;
            this._DefenseStatGrid.RowHeadersWidth = 82;
            this._DefenseStatGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this._DefenseStatGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DimGray;
            this._DefenseStatGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._DefenseStatGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this._DefenseStatGrid.RowTemplate.Height = 33;
            this._DefenseStatGrid.Size = new System.Drawing.Size(282, 108);
            this._DefenseStatGrid.TabIndex = 8;
            // 
            // _ConstitutionStatGrid
            // 
            this._ConstitutionStatGrid.AllowUserToAddRows = false;
            this._ConstitutionStatGrid.AllowUserToDeleteRows = false;
            this._ConstitutionStatGrid.AutoGenerateColumns = false;
            this._ConstitutionStatGrid.ColumnHeadersHeight = 32;
            this._ConstitutionStatGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._ConstitutionStatGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.constitutionDataGridViewTextBoxColumn3});
            this._ConstitutionStatGrid.DataSource = this.characterBindingSource;
            this._ConstitutionStatGrid.Location = new System.Drawing.Point(347, 272);
            this._ConstitutionStatGrid.Name = "_ConstitutionStatGrid";
            this._ConstitutionStatGrid.ReadOnly = true;
            this._ConstitutionStatGrid.RowHeadersWidth = 82;
            this._ConstitutionStatGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this._ConstitutionStatGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DimGray;
            this._ConstitutionStatGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ConstitutionStatGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this._ConstitutionStatGrid.RowTemplate.Height = 33;
            this._ConstitutionStatGrid.Size = new System.Drawing.Size(282, 65);
            this._ConstitutionStatGrid.TabIndex = 9;
            // 
            // _AgilityStatGrid
            // 
            this._AgilityStatGrid.AllowUserToAddRows = false;
            this._AgilityStatGrid.AllowUserToDeleteRows = false;
            this._AgilityStatGrid.AutoGenerateColumns = false;
            this._AgilityStatGrid.ColumnHeadersHeight = 32;
            this._AgilityStatGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._AgilityStatGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agilityDataGridViewTextBoxColumn1});
            this._AgilityStatGrid.DataSource = this.characterBindingSource;
            this._AgilityStatGrid.Location = new System.Drawing.Point(60, 174);
            this._AgilityStatGrid.Name = "_AgilityStatGrid";
            this._AgilityStatGrid.ReadOnly = true;
            this._AgilityStatGrid.RowHeadersWidth = 82;
            this._AgilityStatGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this._AgilityStatGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DimGray;
            this._AgilityStatGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._AgilityStatGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this._AgilityStatGrid.RowTemplate.Height = 33;
            this._AgilityStatGrid.Size = new System.Drawing.Size(284, 66);
            this._AgilityStatGrid.TabIndex = 10;
            // 
            // _CharismaStatGrid
            // 
            this._CharismaStatGrid.AllowUserToAddRows = false;
            this._CharismaStatGrid.AllowUserToDeleteRows = false;
            this._CharismaStatGrid.AutoGenerateColumns = false;
            this._CharismaStatGrid.ColumnHeadersHeight = 32;
            this._CharismaStatGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._CharismaStatGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.charismaDataGridViewTextBoxColumn4});
            this._CharismaStatGrid.DataSource = this.characterBindingSource;
            this._CharismaStatGrid.Location = new System.Drawing.Point(62, 307);
            this._CharismaStatGrid.Name = "_CharismaStatGrid";
            this._CharismaStatGrid.ReadOnly = true;
            this._CharismaStatGrid.RowHeadersWidth = 82;
            this._CharismaStatGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this._CharismaStatGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DimGray;
            this._CharismaStatGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._CharismaStatGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this._CharismaStatGrid.RowTemplate.Height = 33;
            this._CharismaStatGrid.Size = new System.Drawing.Size(282, 66);
            this._CharismaStatGrid.TabIndex = 11;
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
            // charismaDataGridViewTextBoxColumn4
            // 
            this.charismaDataGridViewTextBoxColumn4.DataPropertyName = "Charisma";
            this.charismaDataGridViewTextBoxColumn4.HeaderText = "Charisma";
            this.charismaDataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.charismaDataGridViewTextBoxColumn4.Name = "charismaDataGridViewTextBoxColumn4";
            this.charismaDataGridViewTextBoxColumn4.ReadOnly = true;
            this.charismaDataGridViewTextBoxColumn4.Width = 200;
            // 
            // characterBindingSource
            // 
            this.characterBindingSource.DataSource = typeof(Cameron.AdventureGame.Character);
            // 
            // agilityDataGridViewTextBoxColumn1
            // 
            this.agilityDataGridViewTextBoxColumn1.DataPropertyName = "Agility";
            this.agilityDataGridViewTextBoxColumn1.HeaderText = "Agility";
            this.agilityDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.agilityDataGridViewTextBoxColumn1.Name = "agilityDataGridViewTextBoxColumn1";
            this.agilityDataGridViewTextBoxColumn1.ReadOnly = true;
            this.agilityDataGridViewTextBoxColumn1.Width = 200;
            // 
            // constitutionDataGridViewTextBoxColumn3
            // 
            this.constitutionDataGridViewTextBoxColumn3.DataPropertyName = "Constitution";
            this.constitutionDataGridViewTextBoxColumn3.HeaderText = "Constitution";
            this.constitutionDataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.constitutionDataGridViewTextBoxColumn3.Name = "constitutionDataGridViewTextBoxColumn3";
            this.constitutionDataGridViewTextBoxColumn3.ReadOnly = true;
            this.constitutionDataGridViewTextBoxColumn3.Width = 200;
            // 
            // defenseDataGridViewTextBoxColumn2
            // 
            this.defenseDataGridViewTextBoxColumn2.DataPropertyName = "Defense";
            this.defenseDataGridViewTextBoxColumn2.FillWeight = 15F;
            this.defenseDataGridViewTextBoxColumn2.HeaderText = "Defense";
            this.defenseDataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.defenseDataGridViewTextBoxColumn2.Name = "defenseDataGridViewTextBoxColumn2";
            this.defenseDataGridViewTextBoxColumn2.ReadOnly = true;
            this.defenseDataGridViewTextBoxColumn2.Width = 200;
            // 
            // intelligenceDataGridViewTextBoxColumn
            // 
            this.intelligenceDataGridViewTextBoxColumn.DataPropertyName = "Intelligence";
            this.intelligenceDataGridViewTextBoxColumn.HeaderText = "Intelligence";
            this.intelligenceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.intelligenceDataGridViewTextBoxColumn.Name = "intelligenceDataGridViewTextBoxColumn";
            this.intelligenceDataGridViewTextBoxColumn.ReadOnly = true;
            this.intelligenceDataGridViewTextBoxColumn.Width = 200;
            // 
            // strengthDataGridViewTextBoxColumn
            // 
            this.strengthDataGridViewTextBoxColumn.DataPropertyName = "Strength";
            this.strengthDataGridViewTextBoxColumn.FillWeight = 10F;
            this.strengthDataGridViewTextBoxColumn.HeaderText = "Strength";
            this.strengthDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.strengthDataGridViewTextBoxColumn.Name = "strengthDataGridViewTextBoxColumn";
            this.strengthDataGridViewTextBoxColumn.ReadOnly = true;
            this.strengthDataGridViewTextBoxColumn.Width = 200;
            // 
            // characterBindingSource1
            // 
            this.characterBindingSource1.DataSource = typeof(Cameron.AdventureGame.Character);
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 476);
            this.Controls.Add(this._CancelButton);
            this.Controls.Add(this._SaveButton);
            this.Controls.Add(this._RandomToonButton);
            this.Controls.Add(this._CharismaStatGrid);
            this.Controls.Add(this._AgilityStatGrid);
            this.Controls.Add(this._ConstitutionStatGrid);
            this.Controls.Add(this._DefenseStatGrid);
            this.Controls.Add(this.IntelligenceStatGrid);
            this.Controls.Add(this._StrengthStatGrid);
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
            ((System.ComponentModel.ISupportInitialize)(this._StrengthStatGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntelligenceStatGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DefenseStatGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ConstitutionStatGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AgilityStatGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CharismaStatGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource1)).EndInit();
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
        private System.Windows.Forms.DataGridView _StrengthStatGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn strengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource characterBindingSource;
        private System.Windows.Forms.DataGridView IntelligenceStatGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn intelligenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView _DefenseStatGrid;
        private System.Windows.Forms.DataGridView _ConstitutionStatGrid;
        private System.Windows.Forms.DataGridView _AgilityStatGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn agilityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView _CharismaStatGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn constitutionDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn charismaDataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource characterBindingSource1;
        private System.Windows.Forms.Button _RandomToonButton;
        private System.Windows.Forms.Button _SaveButton;
        private System.Windows.Forms.Button _CancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn defenseDataGridViewTextBoxColumn2;
    }
}