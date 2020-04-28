namespace Calculator
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
            this.add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.substract = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.memoryTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.topText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 419);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 30);
            this.add.TabIndex = 0;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.operatorsClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.numbersClicked);
            // 
            // substract
            // 
            this.substract.Location = new System.Drawing.Point(224, 419);
            this.substract.Name = "substract";
            this.substract.Size = new System.Drawing.Size(100, 30);
            this.substract.TabIndex = 2;
            this.substract.Text = "-";
            this.substract.UseVisualStyleBackColor = true;
            this.substract.Click += new System.EventHandler(this.operatorsClicked);
            // 
            // buttonOne
            // 
            this.buttonOne.Location = new System.Drawing.Point(12, 383);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(100, 30);
            this.buttonOne.TabIndex = 3;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.numbersClicked);
            // 
            // buttonTwo
            // 
            this.buttonTwo.Location = new System.Drawing.Point(118, 383);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(100, 30);
            this.buttonTwo.TabIndex = 4;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = true;
            this.buttonTwo.Click += new System.EventHandler(this.numbersClicked);
            // 
            // buttonThree
            // 
            this.buttonThree.Location = new System.Drawing.Point(224, 383);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(100, 30);
            this.buttonThree.TabIndex = 5;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = true;
            this.buttonThree.Click += new System.EventHandler(this.numbersClicked);
            // 
            // buttonFour
            // 
            this.buttonFour.Location = new System.Drawing.Point(12, 347);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(100, 30);
            this.buttonFour.TabIndex = 6;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = true;
            this.buttonFour.Click += new System.EventHandler(this.numbersClicked);
            // 
            // buttonFive
            // 
            this.buttonFive.Location = new System.Drawing.Point(118, 347);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(100, 30);
            this.buttonFive.TabIndex = 7;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = true;
            this.buttonFive.Click += new System.EventHandler(this.numbersClicked);
            // 
            // buttonSix
            // 
            this.buttonSix.Location = new System.Drawing.Point(224, 347);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(100, 30);
            this.buttonSix.TabIndex = 8;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = true;
            this.buttonSix.Click += new System.EventHandler(this.numbersClicked);
            // 
            // buttonSeven
            // 
            this.buttonSeven.Location = new System.Drawing.Point(12, 311);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(100, 30);
            this.buttonSeven.TabIndex = 9;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = true;
            this.buttonSeven.Click += new System.EventHandler(this.numbersClicked);
            // 
            // buttonEight
            // 
            this.buttonEight.Location = new System.Drawing.Point(118, 311);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(100, 30);
            this.buttonEight.TabIndex = 10;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = true;
            this.buttonEight.Click += new System.EventHandler(this.numbersClicked);
            // 
            // buttonNine
            // 
            this.buttonNine.Location = new System.Drawing.Point(224, 311);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(100, 30);
            this.buttonNine.TabIndex = 11;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = true;
            this.buttonNine.Click += new System.EventHandler(this.numbersClicked);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(12, 275);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(100, 30);
            this.clear.TabIndex = 16;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clearsClicked);
            // 
            // clearAll
            // 
            this.clearAll.Location = new System.Drawing.Point(118, 275);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(100, 30);
            this.clearAll.TabIndex = 17;
            this.clearAll.Text = "CE";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.clearsClicked);
            // 
            // backspace
            // 
            this.backspace.Location = new System.Drawing.Point(224, 275);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(100, 30);
            this.backspace.TabIndex = 18;
            this.backspace.Text = "X";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.clearsClicked);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(12, 240);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(312, 30);
            this.calculate.TabIndex = 19;
            this.calculate.Text = "=";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.operatorsClicked);
            // 
            // memoryTextBox
            // 
            this.memoryTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.memoryTextBox.Location = new System.Drawing.Point(330, 37);
            this.memoryTextBox.Name = "memoryTextBox";
            this.memoryTextBox.Size = new System.Drawing.Size(253, 423);
            this.memoryTextBox.TabIndex = 21;
            this.memoryTextBox.Text = "";
            this.memoryTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Memory";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 189);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 45);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // topText
            // 
            this.topText.AutoSize = true;
            this.topText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topText.Location = new System.Drawing.Point(133, 93);
            this.topText.Name = "topText";
            this.topText.Size = new System.Drawing.Size(0, 25);
            this.topText.TabIndex = 24;
            this.topText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.topText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.memoryTextBox);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonSeven);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.substract);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button substract;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.RichTextBox memoryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label topText;
    }
}

