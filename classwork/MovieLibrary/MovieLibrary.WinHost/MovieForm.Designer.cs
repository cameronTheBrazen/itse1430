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
            this._ratingBox = new System.Windows.Forms.ComboBox();
            this._genreBox = new System.Windows.Forms.TextBox();
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
            _textBoxTitle.Location=new Point(800, 62);
            _textBoxTitle.Margin=new Padding(6, 6, 6, 6);
            _textBoxTitle.Name="_textBoxTitle";
            _textBoxTitle.Size=new Size(414, 39);
            _textBoxTitle.TabIndex=6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize=true;
            checkBox1.Location=new Point(1261, 70);
            checkBox1.Margin=new Padding(6, 6, 6, 6);
            checkBox1.Name="checkBox1";
            checkBox1.Size=new Size(221, 36);
            checkBox1.TabIndex=7;
            checkBox1.Text="Black And White";
            checkBox1.UseVisualStyleBackColor=true;
            // 
            // _textBoxReleaseYear
            // 
            _textBoxReleaseYear.Location=new Point(1073, 183);
            _textBoxReleaseYear.Margin=new Padding(6, 6, 6, 6);
            _textBoxReleaseYear.Name="_textBoxReleaseYear";
            _textBoxReleaseYear.Size=new Size(149, 39);
            _textBoxReleaseYear.TabIndex=8;
            // 
            // _textBoxLength
            // 
            _textBoxLength.Location=new Point(936, 183);
            _textBoxLength.Margin=new Padding(6, 6, 6, 6);
            _textBoxLength.Name="_textBoxLength";
            _textBoxLength.Size=new Size(123, 39);
            _textBoxLength.TabIndex=9;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(945, 23);
            label1.Margin=new Padding(6, 0, 6, 0);
            label1.Name="label1";
            label1.Size=new Size(60, 32);
            label1.TabIndex=10;
            label1.Text="Title";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(810, 130);
            label2.Margin=new Padding(6, 0, 6, 0);
            label2.Name="label2";
            label2.Size=new Size(82, 32);
            label2.TabIndex=11;
            label2.Text="Rating";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(936, 130);
            label3.Margin=new Padding(6, 0, 6, 0);
            label3.Name="label3";
            label3.Size=new Size(137, 32);
            label3.TabIndex=12;
            label3.Text="Run Length";
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
            label6.AutoSize=true;
            label6.Location=new Point(1073, 130);
            label6.Margin=new Padding(6, 0, 6, 0);
            label6.Name="label6";
            label6.Size=new Size(146, 32);
            label6.TabIndex=15;
            label6.Text="Release year";
            // 
            // _ratingBox
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
        private ComboBox _ratingBox;
        private TextBox _genreBox;
    }
}