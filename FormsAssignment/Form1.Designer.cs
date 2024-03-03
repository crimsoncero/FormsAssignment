namespace FormsAssignment
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
            this.Operator = new System.Windows.Forms.ComboBox();
            this.leftBox = new System.Windows.Forms.TextBox();
            this.rightBox = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Operator
            // 
            this.Operator.FormattingEnabled = true;
            this.Operator.Items.AddRange(new object[] {
            "Add",
            "Subtract",
            "Multiply",
            "Divide",
            "Power",
            "Log"});
            this.Operator.Location = new System.Drawing.Point(311, 192);
            this.Operator.Name = "Operator";
            this.Operator.Size = new System.Drawing.Size(121, 21);
            this.Operator.TabIndex = 0;
            this.Operator.TextChanged += new System.EventHandler(this.Operator_TextChanged);
            // 
            // leftBox
            // 
            this.leftBox.Location = new System.Drawing.Point(233, 166);
            this.leftBox.Name = "leftBox";
            this.leftBox.Size = new System.Drawing.Size(100, 20);
            this.leftBox.TabIndex = 1;
            this.leftBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.leftBox.TextChanged += new System.EventHandler(this.leftBox_TextChanged);
            // 
            // rightBox
            // 
            this.rightBox.Location = new System.Drawing.Point(408, 166);
            this.rightBox.Name = "rightBox";
            this.rightBox.Size = new System.Drawing.Size(100, 20);
            this.rightBox.TabIndex = 2;
            this.rightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rightBox.TextChanged += new System.EventHandler(this.rightBox_TextChanged);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(334, 219);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 3;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(357, 276);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 13);
            this.Result.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.rightBox);
            this.Controls.Add(this.leftBox);
            this.Controls.Add(this.Operator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Operator;
        private System.Windows.Forms.TextBox leftBox;
        private System.Windows.Forms.TextBox rightBox;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label Result;
    }
}

