namespace Demo_
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
            this.Id_Text = new System.Windows.Forms.TextBox();
            this.Name_Text = new System.Windows.Forms.TextBox();
            this.Address_Text = new System.Windows.Forms.TextBox();
            this.Age_Text = new System.Windows.Forms.TextBox();
            this.Id_Label = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.Address_Label = new System.Windows.Forms.Label();
            this.Age_Label = new System.Windows.Forms.Label();
            this.Insert_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Read_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Deleteparent_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Id_Text
            // 
            this.Id_Text.Location = new System.Drawing.Point(265, 38);
            this.Id_Text.Name = "Id_Text";
            this.Id_Text.Size = new System.Drawing.Size(100, 22);
            this.Id_Text.TabIndex = 0;
            // 
            // Name_Text
            // 
            this.Name_Text.Location = new System.Drawing.Point(265, 75);
            this.Name_Text.Name = "Name_Text";
            this.Name_Text.Size = new System.Drawing.Size(100, 22);
            this.Name_Text.TabIndex = 1;
            // 
            // Address_Text
            // 
            this.Address_Text.Location = new System.Drawing.Point(265, 103);
            this.Address_Text.Name = "Address_Text";
            this.Address_Text.Size = new System.Drawing.Size(100, 22);
            this.Address_Text.TabIndex = 3;
            // 
            // Age_Text
            // 
            this.Age_Text.Location = new System.Drawing.Point(265, 130);
            this.Age_Text.Name = "Age_Text";
            this.Age_Text.Size = new System.Drawing.Size(100, 22);
            this.Age_Text.TabIndex = 2;
            // 
            // Id_Label
            // 
            this.Id_Label.AutoSize = true;
            this.Id_Label.Location = new System.Drawing.Point(161, 38);
            this.Id_Label.Name = "Id_Label";
            this.Id_Label.Size = new System.Drawing.Size(21, 17);
            this.Id_Label.TabIndex = 4;
            this.Id_Label.Text = "ID";
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Location = new System.Drawing.Point(161, 75);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(45, 17);
            this.Name_label.TabIndex = 5;
            this.Name_label.Text = "Name";
            // 
            // Address_Label
            // 
            this.Address_Label.AutoSize = true;
            this.Address_Label.Location = new System.Drawing.Point(161, 103);
            this.Address_Label.Name = "Address_Label";
            this.Address_Label.Size = new System.Drawing.Size(60, 17);
            this.Address_Label.TabIndex = 6;
            this.Address_Label.Text = "Address";
            // 
            // Age_Label
            // 
            this.Age_Label.AutoSize = true;
            this.Age_Label.Location = new System.Drawing.Point(161, 130);
            this.Age_Label.Name = "Age_Label";
            this.Age_Label.Size = new System.Drawing.Size(33, 17);
            this.Age_Label.TabIndex = 7;
            this.Age_Label.Text = "Age";
            // 
            // Insert_button
            // 
            this.Insert_button.Location = new System.Drawing.Point(119, 175);
            this.Insert_button.Name = "Insert_button";
            this.Insert_button.Size = new System.Drawing.Size(75, 41);
            this.Insert_button.TabIndex = 8;
            this.Insert_button.Text = "Insert";
            this.Insert_button.UseVisualStyleBackColor = true;
            this.Insert_button.Click += new System.EventHandler(this.Insert_Button_Click);
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(337, 175);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(75, 41);
            this.Update_button.TabIndex = 9;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Read_button
            // 
            this.Read_button.Location = new System.Drawing.Point(228, 175);
            this.Read_button.Name = "Read_button";
            this.Read_button.Size = new System.Drawing.Size(75, 41);
            this.Read_button.TabIndex = 10;
            this.Read_button.Text = "Read";
            this.Read_button.UseVisualStyleBackColor = true;
            this.Read_button.Click += new System.EventHandler(this.Read_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(446, 175);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(75, 41);
            this.Delete_button.TabIndex = 11;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Deleteparent_button
            // 
            this.Deleteparent_button.Location = new System.Drawing.Point(337, 222);
            this.Deleteparent_button.Name = "Deleteparent_button";
            this.Deleteparent_button.Size = new System.Drawing.Size(184, 41);
            this.Deleteparent_button.TabIndex = 12;
            this.Deleteparent_button.Text = "Delete Parent";
            this.Deleteparent_button.UseVisualStyleBackColor = true;
            this.Deleteparent_button.Click += new System.EventHandler(this.Deleteparent_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Deleteparent_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Read_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Insert_button);
            this.Controls.Add(this.Age_Label);
            this.Controls.Add(this.Address_Label);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.Id_Label);
            this.Controls.Add(this.Address_Text);
            this.Controls.Add(this.Age_Text);
            this.Controls.Add(this.Name_Text);
            this.Controls.Add(this.Id_Text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Id_Text;
        private System.Windows.Forms.TextBox Name_Text;
        private System.Windows.Forms.TextBox Address_Text;
        private System.Windows.Forms.TextBox Age_Text;
        private System.Windows.Forms.Label Id_Label;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label Address_Label;
        private System.Windows.Forms.Label Age_Label;
        private System.Windows.Forms.Button Insert_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Read_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Deleteparent_button;
    }
}

