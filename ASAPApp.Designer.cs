namespace ASAPApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.title = new System.Windows.Forms.Label();
            this.questionOne = new System.Windows.Forms.Label();
            this.questionTwo = new System.Windows.Forms.Label();
            this.questionThree = new System.Windows.Forms.Label();
            this.questionFour = new System.Windows.Forms.Label();
            this.questionFive = new System.Windows.Forms.Label();
            this.questionSix = new System.Windows.Forms.Label();
            this.q1 = new System.Windows.Forms.TextBox();
            this.q3 = new System.Windows.Forms.TextBox();
            this.q4 = new System.Windows.Forms.TextBox();
            this.q5 = new System.Windows.Forms.TextBox();
            this.bttnCalculate = new System.Windows.Forms.Button();
            this.displayWRPRIndex = new System.Windows.Forms.Label();
            this.bttnReset = new System.Windows.Forms.Button();
            this.q6 = new System.Windows.Forms.TextBox();
            this.q2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(51, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(717, 30);
            this.title.TabIndex = 0;
            this.title.Text = "Daily \"Worth Index Regarding Plastic Recycling\" Calculator";
            // 
            // questionOne
            // 
            this.questionOne.AutoSize = true;
            this.questionOne.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionOne.Location = new System.Drawing.Point(53, 59);
            this.questionOne.Name = "questionOne";
            this.questionOne.Size = new System.Drawing.Size(303, 18);
            this.questionOne.TabIndex = 1;
            this.questionOne.Text = "#1 How many plastic bags did I bought today?";
            this.questionOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // questionTwo
            // 
            this.questionTwo.AutoSize = true;
            this.questionTwo.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTwo.Location = new System.Drawing.Point(53, 106);
            this.questionTwo.Name = "questionTwo";
            this.questionTwo.Size = new System.Drawing.Size(555, 18);
            this.questionTwo.TabIndex = 2;
            this.questionTwo.Text = "#2 When I was at shopping did I bring a bag with me from home? (n for No, y for Y" +
    "es)";
            this.questionTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // questionThree
            // 
            this.questionThree.AutoSize = true;
            this.questionThree.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionThree.Location = new System.Drawing.Point(53, 152);
            this.questionThree.Name = "questionThree";
            this.questionThree.Size = new System.Drawing.Size(370, 18);
            this.questionThree.TabIndex = 3;
            this.questionThree.Text = "#3 How many plastic items did I throw at garbage today?";
            this.questionThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // questionFour
            // 
            this.questionFour.AutoSize = true;
            this.questionFour.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionFour.Location = new System.Drawing.Point(53, 198);
            this.questionFour.Name = "questionFour";
            this.questionFour.Size = new System.Drawing.Size(317, 18);
            this.questionFour.TabIndex = 4;
            this.questionFour.Text = "#4 How many plastic items did I recycled today?";
            this.questionFour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // questionFive
            // 
            this.questionFive.AutoSize = true;
            this.questionFive.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionFive.Location = new System.Drawing.Point(53, 248);
            this.questionFive.Name = "questionFive";
            this.questionFive.Size = new System.Drawing.Size(448, 18);
            this.questionFive.TabIndex = 5;
            this.questionFive.Text = "#5 How many plastic items I reused today instead of using new ones?";
            this.questionFive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // questionSix
            // 
            this.questionSix.AutoSize = true;
            this.questionSix.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionSix.Location = new System.Drawing.Point(53, 298);
            this.questionSix.Name = "questionSix";
            this.questionSix.Size = new System.Drawing.Size(446, 18);
            this.questionSix.TabIndex = 6;
            this.questionSix.Text = "#6 Did my facts altered other people behaviors? (n for No, y for Yes)";
            this.questionSix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // q1
            // 
            this.q1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1.Location = new System.Drawing.Point(638, 59);
            this.q1.Name = "q1";
            this.q1.Size = new System.Drawing.Size(100, 25);
            this.q1.TabIndex = 7;
            this.q1.TextChanged += new System.EventHandler(this.q1_TextChanged);
            // 
            // q3
            // 
            this.q3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q3.Location = new System.Drawing.Point(638, 152);
            this.q3.Name = "q3";
            this.q3.Size = new System.Drawing.Size(100, 25);
            this.q3.TabIndex = 9;
            this.q3.TextChanged += new System.EventHandler(this.q3_TextChanged);
            // 
            // q4
            // 
            this.q4.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q4.Location = new System.Drawing.Point(638, 198);
            this.q4.Name = "q4";
            this.q4.Size = new System.Drawing.Size(100, 25);
            this.q4.TabIndex = 10;
            this.q4.TextChanged += new System.EventHandler(this.q4_TextChanged);
            // 
            // q5
            // 
            this.q5.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q5.Location = new System.Drawing.Point(638, 248);
            this.q5.Name = "q5";
            this.q5.Size = new System.Drawing.Size(100, 25);
            this.q5.TabIndex = 11;
            this.q5.TextChanged += new System.EventHandler(this.q5_TextChanged);
            // 
            // bttnCalculate
            // 
            this.bttnCalculate.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCalculate.Location = new System.Drawing.Point(56, 342);
            this.bttnCalculate.Name = "bttnCalculate";
            this.bttnCalculate.Size = new System.Drawing.Size(440, 96);
            this.bttnCalculate.TabIndex = 13;
            this.bttnCalculate.Text = "Calculate the \"worth index regarding plastic recycling\" NOW!";
            this.bttnCalculate.UseVisualStyleBackColor = true;
            this.bttnCalculate.Click += new System.EventHandler(this.bttnCalculate_Click);
            // 
            // displayWRPRIndex
            // 
            this.displayWRPRIndex.AutoSize = true;
            this.displayWRPRIndex.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayWRPRIndex.Location = new System.Drawing.Point(555, 342);
            this.displayWRPRIndex.Name = "displayWRPRIndex";
            this.displayWRPRIndex.Size = new System.Drawing.Size(0, 30);
            this.displayWRPRIndex.TabIndex = 14;
            this.displayWRPRIndex.Click += new System.EventHandler(this.displayWRPRIndex_Click);
            // 
            // bttnReset
            // 
            this.bttnReset.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnReset.Location = new System.Drawing.Point(560, 376);
            this.bttnReset.Name = "bttnReset";
            this.bttnReset.Size = new System.Drawing.Size(178, 62);
            this.bttnReset.TabIndex = 15;
            this.bttnReset.Text = "Reset entered values and recalibrate calculator!";
            this.bttnReset.UseVisualStyleBackColor = true;
            this.bttnReset.Click += new System.EventHandler(this.bttnReset_Click);
            // 
            // q6
            // 
            this.q6.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q6.Location = new System.Drawing.Point(638, 298);
            this.q6.Name = "q6";
            this.q6.Size = new System.Drawing.Size(100, 25);
            this.q6.TabIndex = 12;
            this.q6.TextChanged += new System.EventHandler(this.q6_TextChanged);
            // 
            // q2
            // 
            this.q2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q2.Location = new System.Drawing.Point(638, 106);
            this.q2.Name = "q2";
            this.q2.Size = new System.Drawing.Size(100, 25);
            this.q2.TabIndex = 8;
            this.q2.TextChanged += new System.EventHandler(this.q2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnReset);
            this.Controls.Add(this.displayWRPRIndex);
            this.Controls.Add(this.bttnCalculate);
            this.Controls.Add(this.q6);
            this.Controls.Add(this.q5);
            this.Controls.Add(this.q4);
            this.Controls.Add(this.q3);
            this.Controls.Add(this.q2);
            this.Controls.Add(this.q1);
            this.Controls.Add(this.questionSix);
            this.Controls.Add(this.questionFive);
            this.Controls.Add(this.questionFour);
            this.Controls.Add(this.questionThree);
            this.Controls.Add(this.questionTwo);
            this.Controls.Add(this.questionOne);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASAP APP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label questionOne;
        private System.Windows.Forms.Label questionTwo;
        private System.Windows.Forms.Label questionThree;
        private System.Windows.Forms.Label questionFour;
        private System.Windows.Forms.Label questionFive;
        private System.Windows.Forms.Label questionSix;
        private System.Windows.Forms.TextBox q1;
        private System.Windows.Forms.TextBox q3;
        private System.Windows.Forms.TextBox q4;
        private System.Windows.Forms.TextBox q5;
        private System.Windows.Forms.Button bttnCalculate;
        private System.Windows.Forms.Label displayWRPRIndex;
        private System.Windows.Forms.Button bttnReset;
        private System.Windows.Forms.TextBox q6;
        private System.Windows.Forms.TextBox q2;
    }
}

