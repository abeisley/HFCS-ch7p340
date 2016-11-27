namespace ch7p340_github
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
            this.description = new System.Windows.Forms.TextBox();
            this.goThoughTheDoor = new System.Windows.Forms.Button();
            this.goHere = new System.Windows.Forms.Button();
            this.exits = new System.Windows.Forms.ComboBox();
            this.check = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(13, 13);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(422, 221);
            this.description.TabIndex = 0;
            // 
            // goThoughTheDoor
            // 
            this.goThoughTheDoor.Location = new System.Drawing.Point(13, 269);
            this.goThoughTheDoor.Name = "goThoughTheDoor";
            this.goThoughTheDoor.Size = new System.Drawing.Size(422, 23);
            this.goThoughTheDoor.TabIndex = 1;
            this.goThoughTheDoor.Text = "Go through the door";
            this.goThoughTheDoor.UseVisualStyleBackColor = true;
            this.goThoughTheDoor.Click += new System.EventHandler(this.goThoughTheDoor_Click);
            // 
            // goHere
            // 
            this.goHere.Location = new System.Drawing.Point(13, 240);
            this.goHere.Name = "goHere";
            this.goHere.Size = new System.Drawing.Size(107, 23);
            this.goHere.TabIndex = 2;
            this.goHere.Text = "Go Here:";
            this.goHere.UseVisualStyleBackColor = true;
            this.goHere.Click += new System.EventHandler(this.goHere_Click);
            // 
            // exits
            // 
            this.exits.FormattingEnabled = true;
            this.exits.Location = new System.Drawing.Point(127, 242);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(308, 21);
            this.exits.TabIndex = 3;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(12, 298);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(422, 23);
            this.check.TabIndex = 4;
            this.check.Text = "check";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // hide
            // 
            this.hide.Location = new System.Drawing.Point(13, 327);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(422, 23);
            this.hide.TabIndex = 5;
            this.hide.Text = "Hide!";
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 361);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.check);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.goHere);
            this.Controls.Add(this.goThoughTheDoor);
            this.Controls.Add(this.description);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Explore the House";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Button goThoughTheDoor;
        private System.Windows.Forms.Button goHere;
        private System.Windows.Forms.ComboBox exits;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button hide;
    }
}