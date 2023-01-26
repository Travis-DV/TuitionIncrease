namespace TuitionIncrease8
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
            this.startingLB = new System.Windows.Forms.Label();
            this.year1LB = new System.Windows.Forms.Label();
            this.year2LB = new System.Windows.Forms.Label();
            this.year3LB = new System.Windows.Forms.Label();
            this.year4LB = new System.Windows.Forms.Label();
            this.year5LB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startingLB
            // 
            this.startingLB.AutoSize = true;
            this.startingLB.Location = new System.Drawing.Point(25, 9);
            this.startingLB.Name = "startingLB";
            this.startingLB.Size = new System.Drawing.Size(125, 13);
            this.startingLB.TabIndex = 0;
            this.startingLB.Text = "Starting Cost was $6,000";
            // 
            // year1LB
            // 
            this.year1LB.AutoSize = true;
            this.year1LB.Location = new System.Drawing.Point(25, 35);
            this.year1LB.Name = "year1LB";
            this.year1LB.Size = new System.Drawing.Size(93, 13);
            this.year1LB.TabIndex = 1;
            this.year1LB.Text = "Year 1 Cost was $";
            // 
            // year2LB
            // 
            this.year2LB.AutoSize = true;
            this.year2LB.Location = new System.Drawing.Point(25, 61);
            this.year2LB.Name = "year2LB";
            this.year2LB.Size = new System.Drawing.Size(93, 13);
            this.year2LB.TabIndex = 2;
            this.year2LB.Text = "Year 2 Cost was $";
            // 
            // year3LB
            // 
            this.year3LB.AutoSize = true;
            this.year3LB.Location = new System.Drawing.Point(25, 88);
            this.year3LB.Name = "year3LB";
            this.year3LB.Size = new System.Drawing.Size(93, 13);
            this.year3LB.TabIndex = 3;
            this.year3LB.Text = "Year 3 Cost was $";
            // 
            // year4LB
            // 
            this.year4LB.AutoSize = true;
            this.year4LB.Location = new System.Drawing.Point(25, 113);
            this.year4LB.Name = "year4LB";
            this.year4LB.Size = new System.Drawing.Size(93, 13);
            this.year4LB.TabIndex = 4;
            this.year4LB.Text = "Year 4 Cost was $";
            // 
            // year5LB
            // 
            this.year5LB.AutoSize = true;
            this.year5LB.Location = new System.Drawing.Point(25, 139);
            this.year5LB.Name = "year5LB";
            this.year5LB.Size = new System.Drawing.Size(93, 13);
            this.year5LB.TabIndex = 5;
            this.year5LB.Text = "Year 5 Cost was $";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 201);
            this.Controls.Add(this.year5LB);
            this.Controls.Add(this.year4LB);
            this.Controls.Add(this.year3LB);
            this.Controls.Add(this.year2LB);
            this.Controls.Add(this.year1LB);
            this.Controls.Add(this.startingLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startingLB;
        private System.Windows.Forms.Label year1LB;
        private System.Windows.Forms.Label year2LB;
        private System.Windows.Forms.Label year3LB;
        private System.Windows.Forms.Label year4LB;
        private System.Windows.Forms.Label year5LB;
    }
}

