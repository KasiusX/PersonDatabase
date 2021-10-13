
namespace PersonDatabaseWinForms
{
    partial class mainForm
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
            this.personsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addPersonComboBox = new System.Windows.Forms.GroupBox();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.addPersonComboBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // personsListBox
            // 
            this.personsListBox.FormattingEnabled = true;
            this.personsListBox.ItemHeight = 33;
            this.personsListBox.Location = new System.Drawing.Point(584, 129);
            this.personsListBox.Name = "personsListBox";
            this.personsListBox.Size = new System.Drawing.Size(415, 301);
            this.personsListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Osoby:";
            // 
            // addPersonComboBox
            // 
            this.addPersonComboBox.Controls.Add(this.addPersonButton);
            this.addPersonComboBox.Controls.Add(this.lastNameTextBox);
            this.addPersonComboBox.Controls.Add(this.firstNameTextBox);
            this.addPersonComboBox.Controls.Add(this.label3);
            this.addPersonComboBox.Controls.Add(this.label2);
            this.addPersonComboBox.Location = new System.Drawing.Point(42, 115);
            this.addPersonComboBox.Name = "addPersonComboBox";
            this.addPersonComboBox.Size = new System.Drawing.Size(486, 315);
            this.addPersonComboBox.TabIndex = 2;
            this.addPersonComboBox.TabStop = false;
            this.addPersonComboBox.Text = "Přidat osobu";
            // 
            // addPersonButton
            // 
            this.addPersonButton.BackColor = System.Drawing.Color.White;
            this.addPersonButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addPersonButton.FlatAppearance.BorderSize = 2;
            this.addPersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPersonButton.Location = new System.Drawing.Point(231, 225);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(238, 55);
            this.addPersonButton.TabIndex = 4;
            this.addPersonButton.Text = "Přidat";
            this.addPersonButton.UseVisualStyleBackColor = false;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(231, 141);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(238, 42);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(231, 57);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(238, 42);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Příjmeni:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Křestní jméno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(364, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 48);
            this.label4.TabIndex = 1;
            this.label4.Text = "Databáze osob";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Location = new System.Drawing.Point(874, 99);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(125, 27);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Odstranit";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1042, 475);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.addPersonComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personsListBox);
            this.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximumSize = new System.Drawing.Size(1058, 514);
            this.MinimumSize = new System.Drawing.Size(1058, 514);
            this.Name = "mainForm";
            this.Text = "Databáze osob";
            this.addPersonComboBox.ResumeLayout(false);
            this.addPersonComboBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox personsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox addPersonComboBox;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

