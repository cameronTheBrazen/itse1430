namespace MovieLibrary.WinHost
{
    partial class MovieForm
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
            this._saveButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this._comboBoxGenre = new System.Windows.Forms.ComboBox();
            this._textBoxDescription = new System.Windows.Forms.TextBox();
            this._textBoxTitle = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this._textBoxReleaseYear = new System.Windows.Forms.TextBox();
            this._textBoxLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _saveButton
            // 
            this._saveButton.Location = new System.Drawing.Point(436, 267);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(75, 23);
            this._saveButton.TabIndex = 1;
            this._saveButton.Text = "Save";
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this.OnSave);
            // 
            // _cancelButton
            // 
            this._cancelButton.Location = new System.Drawing.Point(585, 267);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 2;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            this._cancelButton.Click += new System.EventHandler(this.OnCancel);
            // 
            // _comboBoxGenre
            // 
            this._comboBoxGenre.FormattingEnabled = true;
            this._comboBoxGenre.Items.AddRange(new object[] {
            "Comedy",
            "Romance",
            "Romantic Comedy",
            "Anime",
            "Drama",
            "Action",
            "Thriller",
            "Tragedy",
            "Documentary"});
            this._comboBoxGenre.Location = new System.Drawing.Point(435, 144);
            this._comboBoxGenre.Name = "_comboBoxGenre";
            this._comboBoxGenre.Size = new System.Drawing.Size(225, 23);
            this._comboBoxGenre.TabIndex = 3;
            this._comboBoxGenre.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // _textBoxDescription
            // 
            this._textBoxDescription.Location = new System.Drawing.Point(435, 194);
            this._textBoxDescription.Name = "_textBoxDescription";
            this._textBoxDescription.Size = new System.Drawing.Size(225, 23);
            this._textBoxDescription.TabIndex = 5;
            // 
            // _textBoxTitle
            // 
            this._textBoxTitle.Location = new System.Drawing.Point(431, 29);
            this._textBoxTitle.Name = "_textBoxTitle";
            this._textBoxTitle.Size = new System.Drawing.Size(225, 23);
            this._textBoxTitle.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(679, 33);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 19);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Black And White";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // _textBoxReleaseYear
            // 
            this._textBoxReleaseYear.Location = new System.Drawing.Point(578, 86);
            this._textBoxReleaseYear.Name = "_textBoxReleaseYear";
            this._textBoxReleaseYear.Size = new System.Drawing.Size(82, 23);
            this._textBoxReleaseYear.TabIndex = 8;
            // 
            // _textBoxLength
            // 
            this._textBoxLength.Location = new System.Drawing.Point(504, 86);
            this._textBoxLength.Name = "_textBoxLength";
            this._textBoxLength.Size = new System.Drawing.Size(68, 23);
            this._textBoxLength.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Rating";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Run Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(578, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Release year";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "G",
            "PG",
            "PG-13",
            "R"});
            this.comboBox2.Location = new System.Drawing.Point(431, 87);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(58, 23);
            this.comboBox2.TabIndex = 16;
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._textBoxLength);
            this.Controls.Add(this._textBoxReleaseYear);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this._textBoxTitle);
            this.Controls.Add(this._textBoxDescription);
            this.Controls.Add(this._comboBoxGenre);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._saveButton);
            this.Name = "MovieForm";
            this.Text = "Add Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button _saveButton;
        private Button _cancelButton;
        private ComboBox _comboBoxGenre;
        private TextBox _textBoxDescription;
        private TextBox _textBoxTitle;
        private CheckBox checkBox1;
        private TextBox _textBoxReleaseYear;
        private TextBox _textBoxLength;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox2;
    }
}