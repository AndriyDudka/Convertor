namespace Convertor
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox_In = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Out = new System.Windows.Forms.RichTextBox();
            this.groupBox_In = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton_Json_in = new System.Windows.Forms.RadioButton();
            this.radioButton_Xml_In = new System.Windows.Forms.RadioButton();
            this.groupBox_Out = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton_Json_Out = new System.Windows.Forms.RadioButton();
            this.radioButton_Xml_Out = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox_In.SuspendLayout();
            this.groupBox_Out.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox_In
            // 
            this.richTextBox_In.Location = new System.Drawing.Point(12, 12);
            this.richTextBox_In.Name = "richTextBox_In";
            this.richTextBox_In.Size = new System.Drawing.Size(364, 283);
            this.richTextBox_In.TabIndex = 0;
            this.richTextBox_In.Text = "";
            // 
            // richTextBox_Out
            // 
            this.richTextBox_Out.Location = new System.Drawing.Point(545, 15);
            this.richTextBox_Out.Name = "richTextBox_Out";
            this.richTextBox_Out.Size = new System.Drawing.Size(364, 283);
            this.richTextBox_Out.TabIndex = 2;
            this.richTextBox_Out.Text = "";
            // 
            // groupBox_In
            // 
            this.groupBox_In.Controls.Add(this.radioButton3);
            this.groupBox_In.Controls.Add(this.radioButton_Json_in);
            this.groupBox_In.Controls.Add(this.radioButton_Xml_In);
            this.groupBox_In.Location = new System.Drawing.Point(382, 15);
            this.groupBox_In.Name = "groupBox_In";
            this.groupBox_In.Size = new System.Drawing.Size(157, 100);
            this.groupBox_In.TabIndex = 6;
            this.groupBox_In.TabStop = false;
            this.groupBox_In.Text = "Text_Format_In";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton_Json_in
            // 
            this.radioButton_Json_in.AutoSize = true;
            this.radioButton_Json_in.Location = new System.Drawing.Point(6, 42);
            this.radioButton_Json_in.Name = "radioButton_Json_in";
            this.radioButton_Json_in.Size = new System.Drawing.Size(47, 17);
            this.radioButton_Json_in.TabIndex = 1;
            this.radioButton_Json_in.TabStop = true;
            this.radioButton_Json_in.Text = "Json";
            this.radioButton_Json_in.UseVisualStyleBackColor = true;
            // 
            // radioButton_Xml_In
            // 
            this.radioButton_Xml_In.AutoSize = true;
            this.radioButton_Xml_In.Location = new System.Drawing.Point(6, 19);
            this.radioButton_Xml_In.Name = "radioButton_Xml_In";
            this.radioButton_Xml_In.Size = new System.Drawing.Size(42, 17);
            this.radioButton_Xml_In.TabIndex = 0;
            this.radioButton_Xml_In.TabStop = true;
            this.radioButton_Xml_In.Text = "Xml";
            this.radioButton_Xml_In.UseVisualStyleBackColor = true;
            // 
            // groupBox_Out
            // 
            this.groupBox_Out.Controls.Add(this.radioButton6);
            this.groupBox_Out.Controls.Add(this.radioButton_Json_Out);
            this.groupBox_Out.Controls.Add(this.radioButton_Xml_Out);
            this.groupBox_Out.Location = new System.Drawing.Point(382, 182);
            this.groupBox_Out.Name = "groupBox_Out";
            this.groupBox_Out.Size = new System.Drawing.Size(157, 100);
            this.groupBox_Out.TabIndex = 7;
            this.groupBox_Out.TabStop = false;
            this.groupBox_Out.Text = "Text_Format_Out";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 65);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(85, 17);
            this.radioButton6.TabIndex = 4;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "radioButton6";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton_Json_Out
            // 
            this.radioButton_Json_Out.AutoSize = true;
            this.radioButton_Json_Out.Location = new System.Drawing.Point(6, 42);
            this.radioButton_Json_Out.Name = "radioButton_Json_Out";
            this.radioButton_Json_Out.Size = new System.Drawing.Size(47, 17);
            this.radioButton_Json_Out.TabIndex = 3;
            this.radioButton_Json_Out.TabStop = true;
            this.radioButton_Json_Out.Text = "Json";
            this.radioButton_Json_Out.UseVisualStyleBackColor = true;
            // 
            // radioButton_Xml_Out
            // 
            this.radioButton_Xml_Out.AutoSize = true;
            this.radioButton_Xml_Out.Location = new System.Drawing.Point(6, 19);
            this.radioButton_Xml_Out.Name = "radioButton_Xml_Out";
            this.radioButton_Xml_Out.Size = new System.Drawing.Size(42, 17);
            this.radioButton_Xml_Out.TabIndex = 2;
            this.radioButton_Xml_Out.TabStop = true;
            this.radioButton_Xml_Out.Text = "Xml";
            this.radioButton_Xml_Out.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Convert_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox.Location = new System.Drawing.Point(12, 304);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(897, 48);
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.TickEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(923, 366);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox_Out);
            this.Controls.Add(this.groupBox_In);
            this.Controls.Add(this.richTextBox_Out);
            this.Controls.Add(this.richTextBox_In);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_In.ResumeLayout(false);
            this.groupBox_In.PerformLayout();
            this.groupBox_Out.ResumeLayout(false);
            this.groupBox_Out.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_In;
        private System.Windows.Forms.RichTextBox richTextBox_Out;
        private System.Windows.Forms.GroupBox groupBox_In;
        private System.Windows.Forms.GroupBox groupBox_Out;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton_Json_in;
        private System.Windows.Forms.RadioButton radioButton_Xml_In;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton_Json_Out;
        private System.Windows.Forms.RadioButton radioButton_Xml_Out;
        protected System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Timer timer;
    }
}

