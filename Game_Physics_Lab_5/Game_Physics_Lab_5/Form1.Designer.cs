namespace Game_Physics_Lab_5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.vxTextBox = new System.Windows.Forms.TextBox();
            this.vyTextBox = new System.Windows.Forms.TextBox();
            this.vzTextBox = new System.Windows.Forms.TextBox();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.axesComboBox = new System.Windows.Forms.ComboBox();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.massTextBox = new System.Windows.Forms.TextBox();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.cdTextBox = new System.Windows.Forms.TextBox();
            this.densityTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial x-velocity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Initial y-velocity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Initial z-velocity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Distance to hole, m";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "View Axes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Fire";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // vxTextBox
            // 
            this.vxTextBox.Location = new System.Drawing.Point(185, 16);
            this.vxTextBox.Name = "vxTextBox";
            this.vxTextBox.Size = new System.Drawing.Size(100, 22);
            this.vxTextBox.TabIndex = 7;
            // 
            // vyTextBox
            // 
            this.vyTextBox.Location = new System.Drawing.Point(185, 44);
            this.vyTextBox.Name = "vyTextBox";
            this.vyTextBox.Size = new System.Drawing.Size(100, 22);
            this.vyTextBox.TabIndex = 8;
            // 
            // vzTextBox
            // 
            this.vzTextBox.Location = new System.Drawing.Point(185, 72);
            this.vzTextBox.Name = "vzTextBox";
            this.vzTextBox.Size = new System.Drawing.Size(100, 22);
            this.vzTextBox.TabIndex = 9;
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(185, 102);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(100, 22);
            this.distanceTextBox.TabIndex = 10;
            // 
            // axesComboBox
            // 
            this.axesComboBox.FormattingEnabled = true;
            this.axesComboBox.Location = new System.Drawing.Point(164, 130);
            this.axesComboBox.Name = "axesComboBox";
            this.axesComboBox.Size = new System.Drawing.Size(121, 24);
            this.axesComboBox.TabIndex = 11;
            // 
            // drawingPanel
            // 
            this.drawingPanel.Location = new System.Drawing.Point(29, 264);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(501, 201);
            this.drawingPanel.TabIndex = 12;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 50;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // massTextBox
            // 
            this.massTextBox.Location = new System.Drawing.Point(422, 16);
            this.massTextBox.Name = "massTextBox";
            this.massTextBox.Size = new System.Drawing.Size(100, 22);
            this.massTextBox.TabIndex = 13;
            // 
            // areaTextBox
            // 
            this.areaTextBox.Location = new System.Drawing.Point(422, 44);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(100, 22);
            this.areaTextBox.TabIndex = 14;
            // 
            // cdTextBox
            // 
            this.cdTextBox.Location = new System.Drawing.Point(422, 75);
            this.cdTextBox.Name = "cdTextBox";
            this.cdTextBox.Size = new System.Drawing.Size(100, 22);
            this.cdTextBox.TabIndex = 15;
            // 
            // densityTextBox
            // 
            this.densityTextBox.Location = new System.Drawing.Point(422, 102);
            this.densityTextBox.Name = "densityTextBox";
            this.densityTextBox.Size = new System.Drawing.Size(100, 22);
            this.densityTextBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Mass";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Area";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(304, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Drag Confficient";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Density";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 480);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.densityTextBox);
            this.Controls.Add(this.cdTextBox);
            this.Controls.Add(this.areaTextBox);
            this.Controls.Add(this.massTextBox);
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.axesComboBox);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.vzTextBox);
            this.Controls.Add(this.vyTextBox);
            this.Controls.Add(this.vxTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox vxTextBox;
        private System.Windows.Forms.TextBox vyTextBox;
        private System.Windows.Forms.TextBox vzTextBox;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.ComboBox axesComboBox;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.TextBox massTextBox;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.TextBox cdTextBox;
        private System.Windows.Forms.TextBox densityTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

