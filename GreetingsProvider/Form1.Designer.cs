namespace GreetingsProvider
{
    partial class mainForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.timeOfDayGroupBox = new System.Windows.Forms.GroupBox();
            this.afternoonRadioButton = new System.Windows.Forms.RadioButton();
            this.morningRadioButton = new System.Windows.Forms.RadioButton();
            this.nameLabel = new System.Windows.Forms.Label();
            this.mainLabel = new System.Windows.Forms.Label();
            this.previewButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.displayRichTextBox = new System.Windows.Forms.RichTextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ticketTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fisrtPartOfTextLabel = new System.Windows.Forms.Label();
            this.secondPartOfTextLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.timeOfDayGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(678, 400);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(163, 400);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 5;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // timeOfDayGroupBox
            // 
            this.timeOfDayGroupBox.Controls.Add(this.afternoonRadioButton);
            this.timeOfDayGroupBox.Controls.Add(this.morningRadioButton);
            this.timeOfDayGroupBox.Location = new System.Drawing.Point(317, 56);
            this.timeOfDayGroupBox.Name = "timeOfDayGroupBox";
            this.timeOfDayGroupBox.Size = new System.Drawing.Size(110, 100);
            this.timeOfDayGroupBox.TabIndex = 2;
            this.timeOfDayGroupBox.TabStop = false;
            this.timeOfDayGroupBox.Text = "Time of the day";
            // 
            // afternoonRadioButton
            // 
            this.afternoonRadioButton.AutoSize = true;
            this.afternoonRadioButton.Location = new System.Drawing.Point(21, 56);
            this.afternoonRadioButton.Name = "afternoonRadioButton";
            this.afternoonRadioButton.Size = new System.Drawing.Size(71, 17);
            this.afternoonRadioButton.TabIndex = 1;
            this.afternoonRadioButton.Text = "Afternoon";
            this.afternoonRadioButton.UseVisualStyleBackColor = true;
            // 
            // morningRadioButton
            // 
            this.morningRadioButton.AutoSize = true;
            this.morningRadioButton.Checked = true;
            this.morningRadioButton.Location = new System.Drawing.Point(21, 32);
            this.morningRadioButton.Name = "morningRadioButton";
            this.morningRadioButton.Size = new System.Drawing.Size(63, 17);
            this.morningRadioButton.TabIndex = 2;
            this.morningRadioButton.TabStop = true;
            this.morningRadioButton.Text = "Morning";
            this.morningRadioButton.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(54, 66);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name:";
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(155, -1);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(689, 39);
            this.mainLabel.TabIndex = 4;
            this.mainLabel.Text = "Fill the information to generate a greeting";
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(57, 400);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(75, 23);
            this.previewButton.TabIndex = 4;
            this.previewButton.Text = "Preview";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ticket URL: ";
            // 
            // displayRichTextBox
            // 
            this.displayRichTextBox.Location = new System.Drawing.Point(57, 181);
            this.displayRichTextBox.Name = "displayRichTextBox";
            this.displayRichTextBox.Size = new System.Drawing.Size(370, 174);
            this.displayRichTextBox.TabIndex = 3;
            this.displayRichTextBox.Text = "";
            this.displayRichTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.displayRichTextBox_KeyDown);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(122, 67);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(152, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // ticketTextBox
            // 
            this.ticketTextBox.Location = new System.Drawing.Point(122, 99);
            this.ticketTextBox.Name = "ticketTextBox";
            this.ticketTextBox.Size = new System.Drawing.Size(152, 20);
            this.ticketTextBox.TabIndex = 1;
            //this.ticketTextBox.TextChanged += new System.EventHandler(this.ticketTextBox_TextChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(569, 400);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ticket URL: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Is the issue persisting?",
            "Equipment to send?",
            "Received Equipment?",
            "Resolved, waiting for confirmation. ",
            "Onboarding message for letter. ",
            "Custom fields."});
            this.comboBox1.Location = new System.Drawing.Point(886, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "Select an option";
            // 
            // fisrtPartOfTextLabel
            // 
            this.fisrtPartOfTextLabel.AutoSize = true;
            this.fisrtPartOfTextLabel.Location = new System.Drawing.Point(512, 181);
            this.fisrtPartOfTextLabel.Name = "fisrtPartOfTextLabel";
            this.fisrtPartOfTextLabel.Size = new System.Drawing.Size(90, 13);
            this.fisrtPartOfTextLabel.TabIndex = 11;
            this.fisrtPartOfTextLabel.Text = "First Part of Text: ";
            // 
            // secondPartOfTextLabel
            // 
            this.secondPartOfTextLabel.AutoSize = true;
            this.secondPartOfTextLabel.Location = new System.Drawing.Point(865, 184);
            this.secondPartOfTextLabel.Name = "secondPartOfTextLabel";
            this.secondPartOfTextLabel.Size = new System.Drawing.Size(108, 13);
            this.secondPartOfTextLabel.TabIndex = 12;
            this.secondPartOfTextLabel.Text = "Second Part of Text: ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(472, 212);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(300, 143);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(829, 212);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(300, 143);
            this.richTextBox2.TabIndex = 14;
            this.richTextBox2.Text = "";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 450);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.secondPartOfTextLabel);
            this.Controls.Add(this.fisrtPartOfTextLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.ticketTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.displayRichTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.timeOfDayGroupBox);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.exitButton);
            this.Name = "mainForm";
            this.Text = "Create a Greeting";
            this.timeOfDayGroupBox.ResumeLayout(false);
            this.timeOfDayGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.GroupBox timeOfDayGroupBox;
        private System.Windows.Forms.RadioButton afternoonRadioButton;
        private System.Windows.Forms.RadioButton morningRadioButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox displayRichTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox ticketTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label fisrtPartOfTextLabel;
        private System.Windows.Forms.Label secondPartOfTextLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

