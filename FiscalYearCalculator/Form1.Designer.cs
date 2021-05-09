
namespace FiscalYearCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tDate = new System.Windows.Forms.TextBox();
            this.bCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lfyear = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lfdoy = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lfwoy = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lfpoy = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lfwini = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tDate
            // 
            this.tDate.Location = new System.Drawing.Point(100, 49);
            this.tDate.Name = "tDate";
            this.tDate.Size = new System.Drawing.Size(125, 27);
            this.tDate.TabIndex = 0;
            // 
            // bCalculate
            // 
            this.bCalculate.Location = new System.Drawing.Point(244, 49);
            this.bCalculate.Name = "bCalculate";
            this.bCalculate.Size = new System.Drawing.Size(94, 29);
            this.bCalculate.TabIndex = 1;
            this.bCalculate.Text = "Calculate";
            this.bCalculate.UseVisualStyleBackColor = true;
            this.bCalculate.Click += new System.EventHandler(this.bCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "fyear";
            // 
            // lfyear
            // 
            this.lfyear.AutoSize = true;
            this.lfyear.Location = new System.Drawing.Point(171, 112);
            this.lfyear.Name = "lfyear";
            this.lfyear.Size = new System.Drawing.Size(0, 20);
            this.lfyear.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "fdoy";
            // 
            // lfdoy
            // 
            this.lfdoy.AutoSize = true;
            this.lfdoy.Location = new System.Drawing.Point(171, 143);
            this.lfdoy.Name = "lfdoy";
            this.lfdoy.Size = new System.Drawing.Size(0, 20);
            this.lfdoy.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "fwoy";
            // 
            // lfwoy
            // 
            this.lfwoy.AutoSize = true;
            this.lfwoy.Location = new System.Drawing.Point(171, 174);
            this.lfwoy.Name = "lfwoy";
            this.lfwoy.Size = new System.Drawing.Size(0, 20);
            this.lfwoy.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "fpoy";
            // 
            // lfpoy
            // 
            this.lfpoy.AutoSize = true;
            this.lfpoy.Location = new System.Drawing.Point(171, 206);
            this.lfpoy.Name = "lfpoy";
            this.lfpoy.Size = new System.Drawing.Size(0, 20);
            this.lfpoy.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(106, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "fwini";
            // 
            // lfwini
            // 
            this.lfwini.AutoSize = true;
            this.lfwini.Location = new System.Drawing.Point(171, 239);
            this.lfwini.Name = "lfwini";
            this.lfwini.Size = new System.Drawing.Size(0, 20);
            this.lfwini.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lfwini);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lfpoy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lfwoy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lfdoy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lfyear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCalculate);
            this.Controls.Add(this.tDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tDate;
        private System.Windows.Forms.Button bCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lfyear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lfdoy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lfwoy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lfpoy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lfwini;
    }
}

