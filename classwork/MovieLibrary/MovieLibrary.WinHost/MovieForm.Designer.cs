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
            _saveButton=new Button();
            _cancelButton=new Button();
            _comboBoxGenre=new ComboBox();
            _textBoxDescription=new TextBox();
            _textBoxTitle=new TextBox();
            checkBox1=new CheckBox();
            _textBoxReleaseYear=new TextBox();
            _textBoxLength=new TextBox();
            label1=new Label();
            label2=new Label();
            label3=new Label();
            label4=new Label();
            label5=new Label();
            label6=new Label();
            comboBox2=new ComboBox();
            SuspendLayout();
            // 
            // _saveButton
            // 
            _saveButton.Location=new Point(810, 570);
            _saveButton.Margin=new Padding(6, 6, 6, 6);
            _saveButton.Name="_saveButton";
            _saveButton.Size=new Size(139, 49);
            _saveButton.TabIndex=1;
            _saveButton.Text="Save";
            _saveButton.UseVisualStyleBackColor=true;
            _saveButton.Click+=OnSave;
            // 
            // _cancelButton
            // 
            _cancelButton.Location=new Point(1086, 570);
            _cancelButton.Margin=new Padding(6, 6, 6, 6);
            _cancelButton.Name="_cancelButton";
            _cancelButton.Size=new Size(139, 49);
            _cancelButton.TabIndex=2;
            _cancelButton.Text="Cancel";
            _cancelButton.UseVisualStyleBackColor=true;
            _cancelButton.Click+=OnCancel;
            // 
            // _comboBoxGenre
            // 
            _comboBoxGenre.FormattingEnabled=true;
            _comboBoxGenre.Items.AddRange(new object[] { "Comedy", "Romance", "Romantic Comedy", "Anime", "Drama", "Action", "Thriller", "Tragedy", "Documentary" });
            _comboBoxGenre.Location=new Point(808, 307);
            _comboBoxGenre.Margin=new Padding(6, 6, 6, 6);
            _comboBoxGenre.Name="_comboBoxGenre";
            _comboBoxGenre.Size=new Size(414, 40);
            _comboBoxGenre.TabIndex=3;
            _comboBoxGenre.SelectedIndexChanged+=ComboBox1_SelectedIndexChanged;
            // 
            // _textBoxDescription
            // 
            _textBoxDescription.Location=new Point(808, 414);
            _textBoxDescription.Margin=new Padding(6, 6, 6, 6);
            _textBoxDescription.Multiline=true;
            _textBoxDescription.Name="_textBoxDescription";
            _textBoxDescription.Size=new Size(414, 144);
            _textBoxDescription.TabIndex=5;
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
            label4.AutoSize=true;
            label4.Location=new Point(945, 269);
            label4.Margin=new Padding(6, 0, 6, 0);
            label4.Name="label4";
            label4.Size=new Size(78, 32);
            label4.TabIndex=13;
            label4.Text="Genre";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(921, 375);
            label5.Margin=new Padding(6, 0, 6, 0);
            label5.Name="label5";
            label5.Size=new Size(135, 32);
            label5.TabIndex=14;
            label5.Text="Description";
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
            // comboBox2
            // 
            comboBox2.FormattingEnabled=true;
            comboBox2.Items.AddRange(new object[] { "G", "PG", "PG-13", "R" });
            comboBox2.Location=new Point(800, 186);
            comboBox2.Margin=new Padding(6, 6, 6, 6);
            comboBox2.Name="comboBox2";
            comboBox2.Size=new Size(104, 40);
            comboBox2.TabIndex=16;
            // 
            // MovieForm
            // 
            AutoScaleDimensions=new SizeF(13F, 32F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1486, 960);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(_textBoxLength);
            Controls.Add(_textBoxReleaseYear);
            Controls.Add(checkBox1);
            Controls.Add(_textBoxTitle);
            Controls.Add(_textBoxDescription);
            Controls.Add(_comboBoxGenre);
            Controls.Add(_cancelButton);
            Controls.Add(_saveButton);
            Margin=new Padding(6, 6, 6, 6);
            Name="MovieForm";
            Text="Add Movie";
            ResumeLayout(false);
            PerformLayout();
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