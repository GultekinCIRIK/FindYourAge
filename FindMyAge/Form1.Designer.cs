namespace FindMyAge
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
            this.dateTimePicker_age = new System.Windows.Forms.DateTimePicker();
            this.label_birtday = new System.Windows.Forms.Label();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.label_age = new System.Windows.Forms.Label();
            this.button_calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker_age
            // 
            this.dateTimePicker_age.Location = new System.Drawing.Point(15, 34);
            this.dateTimePicker_age.Name = "dateTimePicker_age";
            this.dateTimePicker_age.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_age.TabIndex = 0;
            // 
            // label_birtday
            // 
            this.label_birtday.AutoSize = true;
            this.label_birtday.Location = new System.Drawing.Point(12, 9);
            this.label_birtday.Name = "label_birtday";
            this.label_birtday.Size = new System.Drawing.Size(95, 13);
            this.label_birtday.TabIndex = 1;
            this.label_birtday.Text = "Enter your birthday";
            // 
            // textBox_age
            // 
            this.textBox_age.Location = new System.Drawing.Point(12, 117);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(200, 20);
            this.textBox_age.TabIndex = 2;
            this.textBox_age.Visible = false;
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Location = new System.Drawing.Point(12, 98);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(51, 13);
            this.label_age.TabIndex = 3;
            this.label_age.Text = "Your Age";
            this.label_age.Visible = false;
            // 
            // button_calculate
            // 
            this.button_calculate.Location = new System.Drawing.Point(15, 61);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(200, 23);
            this.button_calculate.TabIndex = 4;
            this.button_calculate.Text = "Calculate";
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 370);
            this.Controls.Add(this.button_calculate);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.textBox_age);
            this.Controls.Add(this.label_birtday);
            this.Controls.Add(this.dateTimePicker_age);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Find Your Age";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_age;
        private System.Windows.Forms.Label label_birtday;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Button button_calculate;
    }
}

