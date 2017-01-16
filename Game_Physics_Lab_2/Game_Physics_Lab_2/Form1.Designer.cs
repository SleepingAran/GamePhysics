namespace Game_Physics_Lab_2
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
            this.canvas = new System.Windows.Forms.Panel();
            this.planet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.planet_combobox = new System.Windows.Forms.ComboBox();
            this.velocity = new System.Windows.Forms.TextBox();
            this.start_button = new System.Windows.Forms.Button();
            this.drop_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.canvas.Location = new System.Drawing.Point(12, 204);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(508, 187);
            this.canvas.TabIndex = 0;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // planet
            // 
            this.planet.AutoSize = true;
            this.planet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planet.Location = new System.Drawing.Point(12, 28);
            this.planet.Name = "planet";
            this.planet.Size = new System.Drawing.Size(66, 20);
            this.planet.TabIndex = 1;
            this.planet.Text = "Planet: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Box Velocity (m/s):";
            // 
            // planet_combobox
            // 
            this.planet_combobox.AllowDrop = true;
            this.planet_combobox.FormattingEnabled = true;
            this.planet_combobox.Items.AddRange(new object[] {
            "Earth",
            "Moon",
            "Jupiter"});
            this.planet_combobox.Location = new System.Drawing.Point(271, 24);
            this.planet_combobox.Name = "planet_combobox";
            this.planet_combobox.Size = new System.Drawing.Size(172, 24);
            this.planet_combobox.TabIndex = 3;
            // 
            // velocity
            // 
            this.velocity.Location = new System.Drawing.Point(271, 72);
            this.velocity.Name = "velocity";
            this.velocity.Size = new System.Drawing.Size(172, 22);
            this.velocity.TabIndex = 4;
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(16, 160);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 27);
            this.start_button.TabIndex = 5;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // drop_button
            // 
            this.drop_button.Location = new System.Drawing.Point(198, 156);
            this.drop_button.Name = "drop_button";
            this.drop_button.Size = new System.Drawing.Size(75, 31);
            this.drop_button.TabIndex = 6;
            this.drop_button.Text = "Drop";
            this.drop_button.UseVisualStyleBackColor = true;
            this.drop_button.Click += new System.EventHandler(this.drop_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(368, 160);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(75, 27);
            this.reset_button.TabIndex = 7;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Result";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(271, 113);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(249, 22);
            this.result.TabIndex = 9;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 50;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 403);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.drop_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.velocity);
            this.Controls.Add(this.planet_combobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.planet);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Gravity Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label planet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox planet_combobox;
        private System.Windows.Forms.TextBox velocity;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button drop_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Timer gameTimer;
    }
}

