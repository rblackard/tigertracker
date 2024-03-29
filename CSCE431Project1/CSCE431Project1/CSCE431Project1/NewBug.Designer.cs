﻿namespace CSCE431Project1
{
    partial class NewBug
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
            this.ownersAddButton = new System.Windows.Forms.Button();
            this.watchersAddButton = new System.Windows.Forms.Button();
            this.watchersListBox = new System.Windows.Forms.ListBox();
            this.ownersListBox = new System.Windows.Forms.ListBox();
            this.watchersComboBox = new System.Windows.Forms.ComboBox();
            this.ownersComboBox = new System.Windows.Forms.ComboBox();
            this.requirementsListBox = new System.Windows.Forms.ListBox();
            this.releaseComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addBugButton = new System.Windows.Forms.Button();
            this.newDescText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.newPriorityCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newTitleText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxReqs = new System.Windows.Forms.ComboBox();
            this.buttonReqs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ownersAddButton
            // 
            this.ownersAddButton.Location = new System.Drawing.Point(569, 62);
            this.ownersAddButton.Name = "ownersAddButton";
            this.ownersAddButton.Size = new System.Drawing.Size(27, 27);
            this.ownersAddButton.TabIndex = 42;
            this.ownersAddButton.Text = "Add";
            this.ownersAddButton.UseVisualStyleBackColor = true;
            this.ownersAddButton.Click += new System.EventHandler(this.ownersAddButton_Click_1);
            // 
            // watchersAddButton
            // 
            this.watchersAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.watchersAddButton.Location = new System.Drawing.Point(569, 176);
            this.watchersAddButton.Name = "watchersAddButton";
            this.watchersAddButton.Size = new System.Drawing.Size(27, 27);
            this.watchersAddButton.TabIndex = 41;
            this.watchersAddButton.Text = "Watch";
            this.watchersAddButton.UseVisualStyleBackColor = true;
            this.watchersAddButton.Click += new System.EventHandler(this.watchersAddButton_Click_1);
            // 
            // watchersListBox
            // 
            this.watchersListBox.FormattingEnabled = true;
            this.watchersListBox.Location = new System.Drawing.Point(321, 207);
            this.watchersListBox.Name = "watchersListBox";
            this.watchersListBox.Size = new System.Drawing.Size(275, 82);
            this.watchersListBox.TabIndex = 40;
            this.watchersListBox.DoubleClick += new System.EventHandler(this.watchersListBox_DoubleClick);
            // 
            // ownersListBox
            // 
            this.ownersListBox.FormattingEnabled = true;
            this.ownersListBox.Location = new System.Drawing.Point(321, 93);
            this.ownersListBox.Name = "ownersListBox";
            this.ownersListBox.Size = new System.Drawing.Size(275, 82);
            this.ownersListBox.TabIndex = 39;
            this.ownersListBox.SelectedIndexChanged += new System.EventHandler(this.ownersListBox_SelectedIndexChanged);
            this.ownersListBox.DoubleClick += new System.EventHandler(this.ownersListBox_DoubleClick);
            // 
            // watchersComboBox
            // 
            this.watchersComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.watchersComboBox.FormattingEnabled = true;
            this.watchersComboBox.Location = new System.Drawing.Point(380, 180);
            this.watchersComboBox.Name = "watchersComboBox";
            this.watchersComboBox.Size = new System.Drawing.Size(183, 21);
            this.watchersComboBox.TabIndex = 38;
            // 
            // ownersComboBox
            // 
            this.ownersComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ownersComboBox.FormattingEnabled = true;
            this.ownersComboBox.Location = new System.Drawing.Point(380, 65);
            this.ownersComboBox.Name = "ownersComboBox";
            this.ownersComboBox.Size = new System.Drawing.Size(183, 21);
            this.ownersComboBox.TabIndex = 37;
            // 
            // requirementsListBox
            // 
            this.requirementsListBox.FormattingEnabled = true;
            this.requirementsListBox.Location = new System.Drawing.Point(25, 176);
            this.requirementsListBox.Name = "requirementsListBox";
            this.requirementsListBox.Size = new System.Drawing.Size(275, 56);
            this.requirementsListBox.TabIndex = 36;
            // 
            // releaseComboBox
            // 
            this.releaseComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.releaseComboBox.FormattingEnabled = true;
            this.releaseComboBox.Location = new System.Drawing.Point(111, 103);
            this.releaseComboBox.Name = "releaseComboBox";
            this.releaseComboBox.Size = new System.Drawing.Size(189, 21);
            this.releaseComboBox.TabIndex = 35;
            this.releaseComboBox.SelectedIndexChanged += new System.EventHandler(this.releaseComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(243, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 31);
            this.label7.TabIndex = 34;
            this.label7.Text = "New Bug";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(476, 453);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(120, 23);
            this.cancelButton.TabIndex = 33;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addBugButton
            // 
            this.addBugButton.Location = new System.Drawing.Point(339, 453);
            this.addBugButton.Name = "addBugButton";
            this.addBugButton.Size = new System.Drawing.Size(120, 23);
            this.addBugButton.TabIndex = 32;
            this.addBugButton.Text = "Submit Bug";
            this.addBugButton.UseVisualStyleBackColor = true;
            this.addBugButton.Click += new System.EventHandler(this.addBugButton_Click);
            // 
            // newDescText
            // 
            this.newDescText.Location = new System.Drawing.Point(92, 304);
            this.newDescText.Multiline = true;
            this.newDescText.Name = "newDescText";
            this.newDescText.Size = new System.Drawing.Size(504, 128);
            this.newDescText.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Description";
            // 
            // newPriorityCombo
            // 
            this.newPriorityCombo.FormattingEnabled = true;
            this.newPriorityCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.newPriorityCombo.Location = new System.Drawing.Point(98, 256);
            this.newPriorityCombo.Name = "newPriorityCombo";
            this.newPriorityCombo.Size = new System.Drawing.Size(145, 21);
            this.newPriorityCombo.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Priority";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Watchers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Owners";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Release(s)";
            // 
            // newTitleText
            // 
            this.newTitleText.Location = new System.Drawing.Point(111, 66);
            this.newTitleText.Name = "newTitleText";
            this.newTitleText.Size = new System.Drawing.Size(189, 20);
            this.newTitleText.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Title";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Requirements(s)";
            // 
            // comboBoxReqs
            // 
            this.comboBoxReqs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxReqs.FormattingEnabled = true;
            this.comboBoxReqs.Location = new System.Drawing.Point(111, 136);
            this.comboBoxReqs.Name = "comboBoxReqs";
            this.comboBoxReqs.Size = new System.Drawing.Size(147, 21);
            this.comboBoxReqs.TabIndex = 44;
            // 
            // buttonReqs
            // 
            this.buttonReqs.Location = new System.Drawing.Point(273, 136);
            this.buttonReqs.Name = "buttonReqs";
            this.buttonReqs.Size = new System.Drawing.Size(27, 27);
            this.buttonReqs.TabIndex = 45;
            this.buttonReqs.Text = "Add";
            this.buttonReqs.UseVisualStyleBackColor = true;
            this.buttonReqs.Click += new System.EventHandler(this.buttonReqs_Click);
            // 
            // NewBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 488);
            this.Controls.Add(this.buttonReqs);
            this.Controls.Add(this.comboBoxReqs);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ownersAddButton);
            this.Controls.Add(this.watchersAddButton);
            this.Controls.Add(this.watchersListBox);
            this.Controls.Add(this.ownersListBox);
            this.Controls.Add(this.watchersComboBox);
            this.Controls.Add(this.ownersComboBox);
            this.Controls.Add(this.requirementsListBox);
            this.Controls.Add(this.releaseComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addBugButton);
            this.Controls.Add(this.newDescText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.newPriorityCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newTitleText);
            this.Controls.Add(this.label1);
            this.Name = "NewBug";
            this.Text = "NewBug";
            this.Load += new System.EventHandler(this.NewBug_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ownersAddButton;
        private System.Windows.Forms.Button watchersAddButton;
        private System.Windows.Forms.ListBox watchersListBox;
        private System.Windows.Forms.ListBox ownersListBox;
        private System.Windows.Forms.ComboBox watchersComboBox;
        private System.Windows.Forms.ComboBox ownersComboBox;
        private System.Windows.Forms.ListBox requirementsListBox;
        private System.Windows.Forms.ComboBox releaseComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addBugButton;
        private System.Windows.Forms.TextBox newDescText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox newPriorityCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newTitleText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxReqs;
        private System.Windows.Forms.Button buttonReqs;

    }
}