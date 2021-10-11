﻿namespace FContactList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.selectedPersonInfoDisplay = new System.Windows.Forms.TextBox();
            this.addPersonBtn = new System.Windows.Forms.Button();
            this.firstNameCombo = new System.Windows.Forms.ComboBox();
            this.lastNameCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.radioSelectedInfoDisplayTextBox = new System.Windows.Forms.TextBox();
            this.blockedPicture = new System.Windows.Forms.PictureBox();
            this.ghostPicture = new System.Windows.Forms.PictureBox();
            this.bDayRadio = new System.Windows.Forms.RadioButton();
            this.blockedRadio = new System.Windows.Forms.RadioButton();
            this.ghostedRadio = new System.Windows.Forms.RadioButton();
            this.radioPanel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blockedPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostPicture)).BeginInit();
            this.radioPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameListBox
            // 
            this.nameListBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.ItemHeight = 23;
            this.nameListBox.Location = new System.Drawing.Point(8, 104);
            this.nameListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(179, 395);
            this.nameListBox.TabIndex = 5;
            this.nameListBox.SelectedIndexChanged += new System.EventHandler(this.nameListBox_SelectedIndexChanged);
            this.nameListBox.DoubleClick += new System.EventHandler(this.nameListBox_DoubleClick);
            // 
            // selectedPersonInfoDisplay
            // 
            this.selectedPersonInfoDisplay.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectedPersonInfoDisplay.Location = new System.Drawing.Point(194, 104);
            this.selectedPersonInfoDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectedPersonInfoDisplay.Multiline = true;
            this.selectedPersonInfoDisplay.Name = "selectedPersonInfoDisplay";
            this.selectedPersonInfoDisplay.ReadOnly = true;
            this.selectedPersonInfoDisplay.Size = new System.Drawing.Size(204, 395);
            this.selectedPersonInfoDisplay.TabIndex = 6;
            // 
            // addPersonBtn
            // 
            this.addPersonBtn.Location = new System.Drawing.Point(166, 509);
            this.addPersonBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addPersonBtn.Name = "addPersonBtn";
            this.addPersonBtn.Size = new System.Drawing.Size(86, 31);
            this.addPersonBtn.TabIndex = 8;
            this.addPersonBtn.Text = "Lägg till";
            this.addPersonBtn.UseVisualStyleBackColor = true;
            this.addPersonBtn.Click += new System.EventHandler(this.addPersonBtn_Click);
            // 
            // firstNameCombo
            // 
            this.firstNameCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.firstNameCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.firstNameCombo.FormattingEnabled = true;
            this.firstNameCombo.Location = new System.Drawing.Point(7, 27);
            this.firstNameCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstNameCombo.Name = "firstNameCombo";
            this.firstNameCombo.Size = new System.Drawing.Size(179, 26);
            this.firstNameCombo.TabIndex = 1;
            this.firstNameCombo.SelectedIndexChanged += new System.EventHandler(this.firstNameCombo_SelectedIndexChanged);
            // 
            // lastNameCombo
            // 
            this.lastNameCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lastNameCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lastNameCombo.FormattingEnabled = true;
            this.lastNameCombo.Location = new System.Drawing.Point(8, 65);
            this.lastNameCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastNameCombo.Name = "lastNameCombo";
            this.lastNameCombo.Size = new System.Drawing.Size(178, 26);
            this.lastNameCombo.TabIndex = 3;
            this.lastNameCombo.SelectedIndexChanged += new System.EventHandler(this.lastNameCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(194, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sök förnamn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(194, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sök efternamn";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.editButton);
            this.groupBox1.Controls.Add(this.nameListBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.selectedPersonInfoDisplay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.addPersonBtn);
            this.groupBox1.Controls.Add(this.firstNameCombo);
            this.groupBox1.Controls.Add(this.lastNameCombo);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(417, 552);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kontakter";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(258, 509);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(86, 31);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Ta bort";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(73, 509);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(86, 31);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Ändra";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // radioSelectedInfoDisplayTextBox
            // 
            this.radioSelectedInfoDisplayTextBox.Enabled = false;
            this.radioSelectedInfoDisplayTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioSelectedInfoDisplayTextBox.Location = new System.Drawing.Point(466, 388);
            this.radioSelectedInfoDisplayTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioSelectedInfoDisplayTextBox.Multiline = true;
            this.radioSelectedInfoDisplayTextBox.Name = "radioSelectedInfoDisplayTextBox";
            this.radioSelectedInfoDisplayTextBox.Size = new System.Drawing.Size(349, 168);
            this.radioSelectedInfoDisplayTextBox.TabIndex = 14;
            // 
            // blockedPicture
            // 
            this.blockedPicture.BackColor = System.Drawing.Color.Transparent;
            this.blockedPicture.Enabled = false;
            this.blockedPicture.Image = ((System.Drawing.Image)(resources.GetObject("blockedPicture.Image")));
            this.blockedPicture.Location = new System.Drawing.Point(438, 151);
            this.blockedPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.blockedPicture.Name = "blockedPicture";
            this.blockedPicture.Size = new System.Drawing.Size(86, 100);
            this.blockedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blockedPicture.TabIndex = 13;
            this.blockedPicture.TabStop = false;
            // 
            // ghostPicture
            // 
            this.ghostPicture.BackColor = System.Drawing.Color.Transparent;
            this.ghostPicture.Enabled = false;
            this.ghostPicture.Image = ((System.Drawing.Image)(resources.GetObject("ghostPicture.Image")));
            this.ghostPicture.Location = new System.Drawing.Point(438, 43);
            this.ghostPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ghostPicture.Name = "ghostPicture";
            this.ghostPicture.Size = new System.Drawing.Size(86, 100);
            this.ghostPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ghostPicture.TabIndex = 14;
            this.ghostPicture.TabStop = false;
            // 
            // bDayRadio
            // 
            this.bDayRadio.AutoSize = true;
            this.bDayRadio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bDayRadio.Checked = true;
            this.bDayRadio.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bDayRadio.Location = new System.Drawing.Point(7, 66);
            this.bDayRadio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bDayRadio.Name = "bDayRadio";
            this.bDayRadio.Size = new System.Drawing.Size(176, 22);
            this.bDayRadio.TabIndex = 13;
            this.bDayRadio.TabStop = true;
            this.bDayRadio.Text = "Månadens födelsadagar";
            this.bDayRadio.UseVisualStyleBackColor = true;
            this.bDayRadio.CheckedChanged += new System.EventHandler(this.bDayRadio_CheckedChanged);
            // 
            // blockedRadio
            // 
            this.blockedRadio.AutoSize = true;
            this.blockedRadio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.blockedRadio.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.blockedRadio.Location = new System.Drawing.Point(98, 4);
            this.blockedRadio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.blockedRadio.Name = "blockedRadio";
            this.blockedRadio.Size = new System.Drawing.Size(85, 22);
            this.blockedRadio.TabIndex = 11;
            this.blockedRadio.Text = "Blockade";
            this.blockedRadio.UseVisualStyleBackColor = true;
            this.blockedRadio.CheckedChanged += new System.EventHandler(this.blockedRadio_CheckedChanged);
            // 
            // ghostedRadio
            // 
            this.ghostedRadio.AutoSize = true;
            this.ghostedRadio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ghostedRadio.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ghostedRadio.Location = new System.Drawing.Point(95, 36);
            this.ghostedRadio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ghostedRadio.Name = "ghostedRadio";
            this.ghostedRadio.Size = new System.Drawing.Size(88, 22);
            this.ghostedRadio.TabIndex = 12;
            this.ghostedRadio.Text = "Ghostade";
            this.ghostedRadio.UseVisualStyleBackColor = true;
            this.ghostedRadio.CheckedChanged += new System.EventHandler(this.ghostedRadio_CheckedChanged);
            // 
            // radioPanel
            // 
            this.radioPanel.BackColor = System.Drawing.Color.Transparent;
            this.radioPanel.Controls.Add(this.bDayRadio);
            this.radioPanel.Controls.Add(this.blockedRadio);
            this.radioPanel.Controls.Add(this.ghostedRadio);
            this.radioPanel.Location = new System.Drawing.Point(629, 283);
            this.radioPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioPanel.Name = "radioPanel";
            this.radioPanel.Size = new System.Drawing.Size(187, 97);
            this.radioPanel.TabIndex = 10;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 563);
            this.Controls.Add(this.radioPanel);
            this.Controls.Add(this.ghostPicture);
            this.Controls.Add(this.blockedPicture);
            this.Controls.Add(this.radioSelectedInfoDisplayTextBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(849, 614);
            this.MinimumSize = new System.Drawing.Size(849, 614);
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "F Contacts";
            this.Activated += new System.EventHandler(this.MainWindow_Activated);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blockedPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostPicture)).EndInit();
            this.radioPanel.ResumeLayout(false);
            this.radioPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox nameListBox;
        private System.Windows.Forms.TextBox selectedPersonInfoDisplay;
        private System.Windows.Forms.Button addPersonBtn;
        private System.Windows.Forms.ComboBox firstNameCombo;
        private System.Windows.Forms.ComboBox lastNameCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox radioSelectedInfoDisplayTextBox;
        private System.Windows.Forms.PictureBox blockedPicture;
        private System.Windows.Forms.PictureBox ghostPicture;
        private System.Windows.Forms.RadioButton bDayRadio;
        private System.Windows.Forms.RadioButton blockedRadio;
        private System.Windows.Forms.RadioButton ghostedRadio;
        private System.Windows.Forms.Panel radioPanel;
    }
}

