
namespace BMI
{
    partial class BMI_Calculator
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
            this.weight = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.Label();
            this.results = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.radKg = new System.Windows.Forms.RadioButton();
            this.radLb = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Location = new System.Drawing.Point(25, 34);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(45, 15);
            this.weight.TabIndex = 0;
            this.weight.Text = "Weight";
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Location = new System.Drawing.Point(25, 130);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(65, 15);
            this.height.TabIndex = 1;
            this.height.Text = "Height (m)";
            // 
            // results
            // 
            this.results.AutoSize = true;
            this.results.Location = new System.Drawing.Point(25, 184);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(44, 15);
            this.results.TabIndex = 2;
            this.results.Text = "Results";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(96, 31);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(151, 23);
            this.txtWeight.TabIndex = 3;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(111, 127);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(136, 23);
            this.txtHeight.TabIndex = 4;
            // 
            // radKg
            // 
            this.radKg.AutoSize = true;
            this.radKg.Location = new System.Drawing.Point(27, 75);
            this.radKg.Name = "radKg";
            this.radKg.Size = new System.Drawing.Size(73, 19);
            this.radKg.TabIndex = 6;
            this.radKg.TabStop = true;
            this.radKg.Text = "Kilogram";
            this.radKg.UseVisualStyleBackColor = true;
            // 
            // radLb
            // 
            this.radLb.AutoSize = true;
            this.radLb.Location = new System.Drawing.Point(172, 75);
            this.radLb.Name = "radLb";
            this.radLb.Size = new System.Drawing.Size(60, 19);
            this.radLb.TabIndex = 7;
            this.radLb.TabStop = true;
            this.radLb.Text = "Pound";
            this.radLb.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(25, 242);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(222, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(25, 271);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(172, 271);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(25, 202);
            this.txtResult.MaximumSize = new System.Drawing.Size(280, 200);
            this.txtResult.MinimumSize = new System.Drawing.Size(4, 10);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(222, 23);
            this.txtResult.TabIndex = 11;
            // 
            // BMI_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(274, 306);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.radLb);
            this.Controls.Add(this.radKg);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.results);
            this.Controls.Add(this.height);
            this.Controls.Add(this.weight);
            this.Name = "BMI_Calculator";
            this.Text = "BMI";
            this.Load += new System.EventHandler(this.BMI_Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label results;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.RadioButton radKg;
        private System.Windows.Forms.RadioButton radLb;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtResult;
    }
}

