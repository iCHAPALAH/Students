using System;

namespace Vosh_7
{
    partial class Form2
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
            this.labelFIO = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.labelCourse = new System.Windows.Forms.Label();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelForm = new System.Windows.Forms.Label();
            this.comboBoxForm = new System.Windows.Forms.ComboBox();
            this.comboBoxSessions = new System.Windows.Forms.ComboBox();
            this.labelSessions = new System.Windows.Forms.Label();
            this.panelSession = new System.Windows.Forms.Panel();
            this.textBoxSubject5 = new System.Windows.Forms.TextBox();
            this.textBoxSubject4 = new System.Windows.Forms.TextBox();
            this.textBoxSubject3 = new System.Windows.Forms.TextBox();
            this.textBoxSubject2 = new System.Windows.Forms.TextBox();
            this.comboBoxMark5 = new System.Windows.Forms.ComboBox();
            this.comboBoxMark4 = new System.Windows.Forms.ComboBox();
            this.comboBoxMark3 = new System.Windows.Forms.ComboBox();
            this.comboBoxMark2 = new System.Windows.Forms.ComboBox();
            this.comboBoxMark1 = new System.Windows.Forms.ComboBox();
            this.textBoxSubject1 = new System.Windows.Forms.TextBox();
            this.labelMarks = new System.Windows.Forms.Label();
            this.labelSubjects = new System.Windows.Forms.Label();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelSession.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelFIO.Location = new System.Drawing.Point(12, 9);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(42, 17);
            this.labelFIO.TabIndex = 0;
            this.labelFIO.Text = "ФИО";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxFIO.Location = new System.Drawing.Point(15, 29);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(250, 23);
            this.textBoxFIO.TabIndex = 1;
            this.textBoxFIO.TabStop = false;
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCourse.Location = new System.Drawing.Point(12, 55);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(39, 17);
            this.labelCourse.TabIndex = 2;
            this.labelCourse.Text = "Курс";
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.ItemHeight = 16;
            this.comboBoxCourse.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxCourse.Location = new System.Drawing.Point(15, 75);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(55, 24);
            this.comboBoxCourse.TabIndex = 3;
            this.comboBoxCourse.TabStop = false;
            this.comboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourse_SelectedIndexChanged);
            this.comboBoxCourse.Tag = "";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelGroup.Location = new System.Drawing.Point(73, 55);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(55, 17);
            this.labelGroup.TabIndex = 4;
            this.labelGroup.Text = "Группа";
            // 
            // labelForm
            // 
            this.labelForm.AutoSize = true;
            this.labelForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelForm.Location = new System.Drawing.Point(134, 55);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(121, 17);
            this.labelForm.TabIndex = 6;
            this.labelForm.Text = "Форма обучения";
            // 
            // comboBoxForm
            // 
            this.comboBoxForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxForm.FormattingEnabled = true;
            this.comboBoxForm.Items.AddRange(new object[] {
            "Бюджет",
            "Договор"});
            this.comboBoxForm.Location = new System.Drawing.Point(137, 75);
            this.comboBoxForm.Name = "comboBoxForm";
            this.comboBoxForm.Size = new System.Drawing.Size(128, 24);
            this.comboBoxForm.TabIndex = 7;
            this.comboBoxForm.TabStop = false;
            
            // 
            // comboBoxSessions
            // 
            this.comboBoxSessions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxSessions.FormattingEnabled = true;
            this.comboBoxSessions.Location = new System.Drawing.Point(15, 122);
            this.comboBoxSessions.Name = "comboBoxSessions";
            this.comboBoxSessions.Size = new System.Drawing.Size(250, 24);
            this.comboBoxSessions.TabIndex = 8;
            this.comboBoxSessions.TabStop = false;
            this.comboBoxSessions.SelectedIndexChanged += new System.EventHandler(this.comboBoxSessions_SelectedIndexChanged);

            // 
            // labelSessions
            // 
            this.labelSessions.AutoSize = true;
            this.labelSessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSessions.Location = new System.Drawing.Point(12, 102);
            this.labelSessions.Name = "labelSessions";
            this.labelSessions.Size = new System.Drawing.Size(101, 17);
            this.labelSessions.TabIndex = 9;
            this.labelSessions.Text = "Успеваемость";
            // 
            // panelSession
            // 
            this.panelSession.Controls.Add(this.textBoxSubject5);
            this.panelSession.Controls.Add(this.textBoxSubject4);
            this.panelSession.Controls.Add(this.textBoxSubject3);
            this.panelSession.Controls.Add(this.textBoxSubject2);
            this.panelSession.Controls.Add(this.comboBoxMark5);
            this.panelSession.Controls.Add(this.comboBoxMark4);
            this.panelSession.Controls.Add(this.comboBoxMark3);
            this.panelSession.Controls.Add(this.comboBoxMark2);
            this.panelSession.Controls.Add(this.comboBoxMark1);
            this.panelSession.Controls.Add(this.textBoxSubject1);
            this.panelSession.Controls.Add(this.labelMarks);
            this.panelSession.Controls.Add(this.labelSubjects);
            this.panelSession.Enabled = false;
            this.panelSession.Location = new System.Drawing.Point(15, 152);
            this.panelSession.Name = "panelSession";
            this.panelSession.Size = new System.Drawing.Size(250, 151);
            this.panelSession.TabIndex = 10;
            // 
            // textBoxSubject5
            // 
            this.textBoxSubject5.Location = new System.Drawing.Point(0, 129);
            this.textBoxSubject5.Name = "textBoxSubject5";
            this.textBoxSubject5.Size = new System.Drawing.Size(189, 20);
            this.textBoxSubject5.TabIndex = 22;
            this.textBoxSubject5.TabStop = false;
            
            // 
            // textBoxSubject4
            // 
            this.textBoxSubject4.Location = new System.Drawing.Point(0, 102);
            this.textBoxSubject4.Name = "textBoxSubject4";
            this.textBoxSubject4.Size = new System.Drawing.Size(189, 20);
            this.textBoxSubject4.TabIndex = 21;
            this.textBoxSubject4.TabStop = false;
            
            // 
            // textBoxSubject3
            // 
            this.textBoxSubject3.Location = new System.Drawing.Point(0, 75);
            this.textBoxSubject3.Name = "textBoxSubject3";
            this.textBoxSubject3.Size = new System.Drawing.Size(189, 20);
            this.textBoxSubject3.TabIndex = 20;
            this.textBoxSubject3.TabStop = false;
            
            // 
            // textBoxSubject2
            // 
            this.textBoxSubject2.Location = new System.Drawing.Point(0, 48);
            this.textBoxSubject2.Name = "textBoxSubject2";
            this.textBoxSubject2.Size = new System.Drawing.Size(189, 20);
            this.textBoxSubject2.TabIndex = 19;
            this.textBoxSubject2.TabStop = false;
            
            // 
            // comboBoxMark5
            // 
            this.comboBoxMark5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMark5.FormattingEnabled = true;
            this.comboBoxMark5.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxMark5.Location = new System.Drawing.Point(195, 128);
            this.comboBoxMark5.Name = "comboBoxMark5";
            this.comboBoxMark5.Size = new System.Drawing.Size(55, 21);
            this.comboBoxMark5.TabIndex = 18;
            this.comboBoxMark5.TabStop = false;
            
            // 
            // comboBoxMark4
            // 
            this.comboBoxMark4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMark4.FormattingEnabled = true;
            this.comboBoxMark4.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxMark4.Location = new System.Drawing.Point(195, 101);
            this.comboBoxMark4.Name = "comboBoxMark4";
            this.comboBoxMark4.Size = new System.Drawing.Size(55, 21);
            this.comboBoxMark4.TabIndex = 17;
            this.comboBoxMark4.TabStop = false;
            
            // 
            // comboBoxMark3
            // 
            this.comboBoxMark3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMark3.FormattingEnabled = true;
            this.comboBoxMark3.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxMark3.Location = new System.Drawing.Point(195, 74);
            this.comboBoxMark3.Name = "comboBoxMark3";
            this.comboBoxMark3.Size = new System.Drawing.Size(55, 21);
            this.comboBoxMark3.TabIndex = 16;
            this.comboBoxMark3.TabStop = false;
            
            // 
            // comboBoxMark2
            // 
            this.comboBoxMark2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMark2.FormattingEnabled = true;
            this.comboBoxMark2.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxMark2.Location = new System.Drawing.Point(195, 47);
            this.comboBoxMark2.Name = "comboBoxMark2";
            this.comboBoxMark2.Size = new System.Drawing.Size(55, 21);
            this.comboBoxMark2.TabIndex = 15;
            this.comboBoxMark2.TabStop = false;
            
            // 
            // comboBoxMark1
            // 
            this.comboBoxMark1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMark1.FormattingEnabled = true;
            this.comboBoxMark1.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxMark1.Location = new System.Drawing.Point(195, 20);
            this.comboBoxMark1.Name = "comboBoxMark1";
            this.comboBoxMark1.Size = new System.Drawing.Size(55, 21);
            this.comboBoxMark1.TabIndex = 14;
            this.comboBoxMark1.TabStop = false;
            
            // 
            // textBoxSubject1
            // 
            this.textBoxSubject1.Location = new System.Drawing.Point(0, 20);
            this.textBoxSubject1.Name = "textBoxSubject1";
            this.textBoxSubject1.Size = new System.Drawing.Size(189, 20);
            this.textBoxSubject1.TabIndex = 13;
            this.textBoxSubject1.TabStop = false;
            
            // 
            // labelMarks
            // 
            this.labelMarks.AutoSize = true;
            this.labelMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMarks.Location = new System.Drawing.Point(192, 0);
            this.labelMarks.Name = "labelMarks";
            this.labelMarks.Size = new System.Drawing.Size(58, 17);
            this.labelMarks.TabIndex = 11;
            this.labelMarks.Text = "Оценки";
            // 
            // labelSubjects
            // 
            this.labelSubjects.AutoSize = true;
            this.labelSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSubjects.Location = new System.Drawing.Point(-3, 0);
            this.labelSubjects.Name = "labelSubjects";
            this.labelSubjects.Size = new System.Drawing.Size(76, 17);
            this.labelSubjects.TabIndex = 0;
            this.labelSubjects.Text = "Предметы";
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxGroup.Location = new System.Drawing.Point(76, 76);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(55, 23);
            this.textBoxGroup.TabIndex = 12;
            this.textBoxGroup.TabStop = false;
            
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonOk.Location = new System.Drawing.Point(15, 309);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(100, 30);
            this.buttonOk.TabIndex = 13;
            this.buttonOk.TabStop = false;
            this.buttonOk.Text = "Сохранить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCancel.Location = new System.Drawing.Point(165, 309);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 30);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.TabStop = false;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 351);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxGroup);
            this.Controls.Add(this.panelSession);
            this.Controls.Add(this.labelSessions);
            this.Controls.Add(this.comboBoxSessions);
            this.Controls.Add(this.comboBoxForm);
            this.Controls.Add(this.labelForm);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.labelFIO);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelSession.ResumeLayout(false);
            this.panelSession.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.Label labelForm;
        private System.Windows.Forms.ComboBox comboBoxForm;
        private System.Windows.Forms.Label labelSessions;
        private System.Windows.Forms.ComboBox comboBoxSessions;
        private System.Windows.Forms.Panel panelSession;
        private System.Windows.Forms.Label labelSubjects;
        private System.Windows.Forms.Label labelMarks;
        private System.Windows.Forms.ComboBox comboBoxMark1;
        private System.Windows.Forms.ComboBox comboBoxMark2;
        private System.Windows.Forms.ComboBox comboBoxMark3;
        private System.Windows.Forms.ComboBox comboBoxMark4;
        private System.Windows.Forms.ComboBox comboBoxMark5;
        private System.Windows.Forms.TextBox textBoxSubject1;
        private System.Windows.Forms.TextBox textBoxSubject2;
        private System.Windows.Forms.TextBox textBoxSubject3;
        private System.Windows.Forms.TextBox textBoxSubject4;
        private System.Windows.Forms.TextBox textBoxSubject5;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}