﻿namespace WindowsFormsApp6
{
    partial class FormAddActivity
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAddActivity = new System.Windows.Forms.Button();
            this.buttonAddJuri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.eventPlanIDComboBox = new System.Windows.Forms.ComboBox();
            this.ModeratorComboBox = new System.Windows.Forms.ComboBox();
            this.juriComboBox = new System.Windows.Forms.ComboBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(11, 31);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(110, 40);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAddActivity
            // 
            this.buttonAddActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddActivity.Location = new System.Drawing.Point(176, 391);
            this.buttonAddActivity.Name = "buttonAddActivity";
            this.buttonAddActivity.Size = new System.Drawing.Size(247, 39);
            this.buttonAddActivity.TabIndex = 1;
            this.buttonAddActivity.Text = "Add new activity";
            this.buttonAddActivity.UseVisualStyleBackColor = true;
            this.buttonAddActivity.Click += new System.EventHandler(this.buttonAddActivity_Click);
            // 
            // buttonAddJuri
            // 
            this.buttonAddJuri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddJuri.Location = new System.Drawing.Point(458, 340);
            this.buttonAddJuri.Name = "buttonAddJuri";
            this.buttonAddJuri.Size = new System.Drawing.Size(103, 24);
            this.buttonAddJuri.TabIndex = 2;
            this.buttonAddJuri.Text = "Add";
            this.buttonAddJuri.UseVisualStyleBackColor = true;
            this.buttonAddJuri.Click += new System.EventHandler(this.buttonAddJuri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(242, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add new activity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Event plan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(25, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(25, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "The start";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Moderator";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(25, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Juri";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(167, 109);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(267, 20);
            this.titleTextBox.TabIndex = 10;
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(167, 203);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(267, 20);
            this.dayTextBox.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(167, 252);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(267, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // eventPlanIDComboBox
            // 
            this.eventPlanIDComboBox.DataSource = this.eventBindingSource;
            this.eventPlanIDComboBox.DisplayMember = "Title";
            this.eventPlanIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventPlanIDComboBox.FormattingEnabled = true;
            this.eventPlanIDComboBox.Location = new System.Drawing.Point(167, 158);
            this.eventPlanIDComboBox.Name = "eventPlanIDComboBox";
            this.eventPlanIDComboBox.Size = new System.Drawing.Size(267, 21);
            this.eventPlanIDComboBox.TabIndex = 13;
            this.eventPlanIDComboBox.ValueMember = "ID";
            // 
            // ModeratorComboBox
            // 
            this.ModeratorComboBox.DataSource = this.usersBindingSource;
            this.ModeratorComboBox.DisplayMember = "Surname";
            this.ModeratorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeratorComboBox.FormattingEnabled = true;
            this.ModeratorComboBox.Location = new System.Drawing.Point(167, 298);
            this.ModeratorComboBox.Name = "ModeratorComboBox";
            this.ModeratorComboBox.Size = new System.Drawing.Size(267, 21);
            this.ModeratorComboBox.TabIndex = 14;
            this.ModeratorComboBox.ValueMember = "ID";
            // 
            // juriComboBox
            // 
            this.juriComboBox.DataSource = this.usersBindingSource2;
            this.juriComboBox.DisplayMember = "Surname";
            this.juriComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.juriComboBox.FormattingEnabled = true;
            this.juriComboBox.Location = new System.Drawing.Point(167, 338);
            this.juriComboBox.Name = "juriComboBox";
            this.juriComboBox.Size = new System.Drawing.Size(267, 21);
            this.juriComboBox.TabIndex = 15;
            this.juriComboBox.ValueMember = "ID";
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(WindowsFormsApp6.DBCon.Event);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(WindowsFormsApp6.DBCon.User);
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataSource = typeof(WindowsFormsApp6.DBCon.User);
            // 
            // FormAddActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 442);
            this.Controls.Add(this.juriComboBox);
            this.Controls.Add(this.ModeratorComboBox);
            this.Controls.Add(this.eventPlanIDComboBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddJuri);
            this.Controls.Add(this.buttonAddActivity);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormAddActivity";
            this.Text = "FormAddActivity";
            this.Load += new System.EventHandler(this.FormAddActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAddActivity;
        private System.Windows.Forms.Button buttonAddJuri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox eventPlanIDComboBox;
        private System.Windows.Forms.ComboBox ModeratorComboBox;
        private System.Windows.Forms.ComboBox juriComboBox;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource2;
    }
}