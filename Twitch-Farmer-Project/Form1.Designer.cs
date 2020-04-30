namespace Twitch_Farmer_Project
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
            this.Start_Button = new System.Windows.Forms.Button();
            this.Stop_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Green_Box = new System.Windows.Forms.CheckBox();
            this.Red_Box = new System.Windows.Forms.CheckBox();
            this.none_box = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Start_Button
            // 
            this.Start_Button.Location = new System.Drawing.Point(12, 12);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(75, 23);
            this.Start_Button.TabIndex = 0;
            this.Start_Button.Text = "Start";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Stop_Button
            // 
            this.Stop_Button.Location = new System.Drawing.Point(12, 41);
            this.Stop_Button.Name = "Stop_Button";
            this.Stop_Button.Size = new System.Drawing.Size(75, 23);
            this.Stop_Button.TabIndex = 1;
            this.Stop_Button.Text = "Stop";
            this.Stop_Button.UseVisualStyleBackColor = true;
            this.Stop_Button.Click += new System.EventHandler(this.Stop_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(12, 70);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(75, 23);
            this.Exit_Button.TabIndex = 2;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Green_Box
            // 
            this.Green_Box.AutoSize = true;
            this.Green_Box.Location = new System.Drawing.Point(93, 16);
            this.Green_Box.Name = "Green_Box";
            this.Green_Box.Size = new System.Drawing.Size(55, 17);
            this.Green_Box.TabIndex = 3;
            this.Green_Box.Text = "Green";
            this.Green_Box.UseVisualStyleBackColor = true;
            this.Green_Box.CheckedChanged += new System.EventHandler(this.Green_Box_CheckedChanged);
            // 
            // Red_Box
            // 
            this.Red_Box.AutoSize = true;
            this.Red_Box.Location = new System.Drawing.Point(93, 45);
            this.Red_Box.Name = "Red_Box";
            this.Red_Box.Size = new System.Drawing.Size(46, 17);
            this.Red_Box.TabIndex = 4;
            this.Red_Box.Text = "Red";
            this.Red_Box.UseVisualStyleBackColor = true;
            this.Red_Box.CheckedChanged += new System.EventHandler(this.Red_Box_CheckedChanged);
            // 
            // none_box
            // 
            this.none_box.AutoSize = true;
            this.none_box.Location = new System.Drawing.Point(93, 74);
            this.none_box.Name = "none_box";
            this.none_box.Size = new System.Drawing.Size(131, 17);
            this.none_box.TabIndex = 5;
            this.none_box.Text = "None (auto stops app)";
            this.none_box.UseVisualStyleBackColor = true;
            this.none_box.CheckedChanged += new System.EventHandler(this.none_box_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 106);
            this.Controls.Add(this.none_box);
            this.Controls.Add(this.Red_Box);
            this.Controls.Add(this.Green_Box);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Stop_Button);
            this.Controls.Add(this.Start_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Twitch Farmer Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Button Stop_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.CheckBox Green_Box;
        private System.Windows.Forms.CheckBox Red_Box;
        private System.Windows.Forms.CheckBox none_box;
    }
}

