
namespace GUIApp
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
            this.tbxUserInput = new System.Windows.Forms.TextBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnMoveWord = new System.Windows.Forms.Button();
            this.lblEnterWord = new System.Windows.Forms.Label();
            this.nudNumberInput = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberInput)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxUserInput
            // 
            this.tbxUserInput.Location = new System.Drawing.Point(80, 113);
            this.tbxUserInput.Name = "tbxUserInput";
            this.tbxUserInput.Size = new System.Drawing.Size(553, 20);
            this.tbxUserInput.TabIndex = 4;
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(121, 159);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.Size = new System.Drawing.Size(253, 183);
            this.rtbOutput.TabIndex = 5;
            this.rtbOutput.Text = "";
            // 
            // btnMoveWord
            // 
            this.btnMoveWord.Location = new System.Drawing.Point(659, 113);
            this.btnMoveWord.Name = "btnMoveWord";
            this.btnMoveWord.Size = new System.Drawing.Size(75, 23);
            this.btnMoveWord.TabIndex = 6;
            this.btnMoveWord.Text = "Move Word";
            this.btnMoveWord.UseVisualStyleBackColor = true;
            this.btnMoveWord.Click += new System.EventHandler(this.btnMoveWord_Click);
            // 
            // lblEnterWord
            // 
            this.lblEnterWord.AutoSize = true;
            this.lblEnterWord.Location = new System.Drawing.Point(80, 78);
            this.lblEnterWord.Name = "lblEnterWord";
            this.lblEnterWord.Size = new System.Drawing.Size(98, 13);
            this.lblEnterWord.TabIndex = 7;
            this.lblEnterWord.Text = "Enter a word below";
            // 
            // nudNumberInput
            // 
            this.nudNumberInput.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumberInput.Location = new System.Drawing.Point(452, 191);
            this.nudNumberInput.Name = "nudNumberInput";
            this.nudNumberInput.Size = new System.Drawing.Size(165, 20);
            this.nudNumberInput.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(452, 274);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(452, 298);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(452, 322);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(569, 274);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(569, 298);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.nudNumberInput);
            this.Controls.Add(this.lblEnterWord);
            this.Controls.Add(this.btnMoveWord);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.tbxUserInput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxUserInput;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnMoveWord;
        private System.Windows.Forms.Label lblEnterWord;
        private System.Windows.Forms.NumericUpDown nudNumberInput;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

