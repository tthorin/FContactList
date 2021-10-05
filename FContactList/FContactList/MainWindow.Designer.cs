namespace FContactList
{

    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addPersonBtn = new System.Windows.Forms.Button();
            this.firstNameCombo = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lastNameCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.blockedPicture = new System.Windows.Forms.PictureBox();
            this.ghostPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blockedPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // nameListBox
            // 
            this.nameListBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.ItemHeight = 18;
            this.nameListBox.Location = new System.Drawing.Point(7, 78);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(157, 292);
            this.nameListBox.TabIndex = 0;
            this.nameListBox.SelectedIndexChanged += new System.EventHandler(this.nameListBox_SelectedIndexChanged);
            this.nameListBox.DoubleClick += new System.EventHandler(this.nameListBox_DoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(170, 78);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(179, 298);
            this.textBox1.TabIndex = 1;
            // 
            // addPersonBtn
            // 
            this.addPersonBtn.Location = new System.Drawing.Point(145, 382);
            this.addPersonBtn.Name = "addPersonBtn";
            this.addPersonBtn.Size = new System.Drawing.Size(75, 23);
            this.addPersonBtn.TabIndex = 2;
            this.addPersonBtn.Text = "Lägg till";
            this.addPersonBtn.UseVisualStyleBackColor = true;
            this.addPersonBtn.Click += new System.EventHandler(this.addPersonBtn_Click);
            // 
            // firstNameCombo
            // 
            this.firstNameCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.firstNameCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.firstNameCombo.FormattingEnabled = true;
            this.firstNameCombo.Location = new System.Drawing.Point(6, 20);
            this.firstNameCombo.Name = "firstNameCombo";
            this.firstNameCombo.Size = new System.Drawing.Size(157, 22);
            this.firstNameCombo.TabIndex = 5;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.nameListBox.Controls;
            // 
            // lastNameCombo
            // 
            this.lastNameCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lastNameCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lastNameCombo.FormattingEnabled = true;
            this.lastNameCombo.Location = new System.Drawing.Point(7, 49);
            this.lastNameCombo.Name = "lastNameCombo";
            this.lastNameCombo.Size = new System.Drawing.Size(156, 22);
            this.lastNameCombo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(170, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sök förnamn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(170, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sök efternamn";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.editButton);
            this.groupBox1.Controls.Add(this.nameListBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.addPersonBtn);
            this.groupBox1.Controls.Add(this.firstNameCombo);
            this.groupBox1.Controls.Add(this.lastNameCombo);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 414);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kontakter";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(226, 382);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Ta bort";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(64, 382);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 10;
            this.editButton.Text = "Ändra";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(412, 203);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(306, 185);
            this.textBox2.TabIndex = 12;
            // 
            // blockedPicture
            // 
            this.blockedPicture.BackColor = System.Drawing.Color.Transparent;
            this.blockedPicture.Enabled = false;
            this.blockedPicture.Image = ((System.Drawing.Image)(resources.GetObject("blockedPicture.Image")));
            this.blockedPicture.Location = new System.Drawing.Point(383, 113);
            this.blockedPicture.Name = "blockedPicture";
            this.blockedPicture.Size = new System.Drawing.Size(75, 75);
            this.blockedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blockedPicture.TabIndex = 13;
            this.blockedPicture.TabStop = false;
            // 
            // ghostPicture
            // 
            this.ghostPicture.BackColor = System.Drawing.Color.Transparent;
            this.ghostPicture.Enabled = false;
            this.ghostPicture.Image = ((System.Drawing.Image)(resources.GetObject("ghostPicture.Image")));
            this.ghostPicture.Location = new System.Drawing.Point(383, 32);
            this.ghostPicture.Name = "ghostPicture";
            this.ghostPicture.Size = new System.Drawing.Size(75, 75);
            this.ghostPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ghostPicture.TabIndex = 14;
            this.ghostPicture.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 434);
            this.Controls.Add(this.ghostPicture);
            this.Controls.Add(this.blockedPicture);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(746, 473);
            this.MinimumSize = new System.Drawing.Size(746, 473);
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "F Contacts";
            this.Activated += new System.EventHandler(this.MainWindow_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blockedPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox nameListBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addPersonBtn;
        private System.Windows.Forms.ComboBox firstNameCombo;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox lastNameCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox blockedPicture;
        private System.Windows.Forms.PictureBox ghostPicture;
    }
}

