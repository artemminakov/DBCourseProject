using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBCourseProject
{
    partial class AddConsultant : Form
    {

        private Form1 mainForm;
        public AddConsultant(Form1 _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
        }
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
            this.ErrorBox_label = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.merit_textBox = new System.Windows.Forms.TextBox();
            this.experience_textBox = new System.Windows.Forms.TextBox();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.numberTel_textBox = new System.Windows.Forms.TextBox();
            this.consultantName_textBox = new System.Windows.Forms.TextBox();
            this.merit_label = new System.Windows.Forms.Label();
            this.experience_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.numberTel_label = new System.Windows.Forms.Label();
            this.consultantName_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ErrorBox_label
            // 
            this.ErrorBox_label.AutoSize = true;
            this.ErrorBox_label.Location = new System.Drawing.Point(125, 202);
            this.ErrorBox_label.Name = "ErrorBox_label";
            this.ErrorBox_label.Size = new System.Drawing.Size(0, 13);
            this.ErrorBox_label.TabIndex = 29;
            this.ErrorBox_label.Click += new System.EventHandler(this.ErrorBox_label_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(239, 262);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(95, 39);
            this.cancel_button.TabIndex = 28;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(111, 262);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(93, 39);
            this.ok_button.TabIndex = 27;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // merit_textBox
            // 
            this.merit_textBox.Location = new System.Drawing.Point(194, 150);
            this.merit_textBox.Name = "merit_textBox";
            this.merit_textBox.Size = new System.Drawing.Size(278, 20);
            this.merit_textBox.TabIndex = 25;
            this.merit_textBox.TextChanged += new System.EventHandler(this.rentalFees_textBox_TextChanged);
            // 
            // experience_textBox
            // 
            this.experience_textBox.Location = new System.Drawing.Point(194, 117);
            this.experience_textBox.Name = "experience_textBox";
            this.experience_textBox.Size = new System.Drawing.Size(278, 20);
            this.experience_textBox.TabIndex = 24;
            this.experience_textBox.TextChanged += new System.EventHandler(this.mileage_textBox_TextChanged);
            // 
            // address_textBox
            // 
            this.address_textBox.Location = new System.Drawing.Point(194, 87);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(278, 20);
            this.address_textBox.TabIndex = 23;
            this.address_textBox.TextChanged += new System.EventHandler(this.color_textBox_TextChanged);
            // 
            // numberTel_textBox
            // 
            this.numberTel_textBox.Location = new System.Drawing.Point(194, 58);
            this.numberTel_textBox.Name = "numberTel_textBox";
            this.numberTel_textBox.Size = new System.Drawing.Size(278, 20);
            this.numberTel_textBox.TabIndex = 22;
            this.numberTel_textBox.TextChanged += new System.EventHandler(this.model_textBox_TextChanged);
            // 
            // consultantName_textBox
            // 
            this.consultantName_textBox.Location = new System.Drawing.Point(194, 26);
            this.consultantName_textBox.Name = "consultantName_textBox";
            this.consultantName_textBox.Size = new System.Drawing.Size(278, 20);
            this.consultantName_textBox.TabIndex = 21;
            this.consultantName_textBox.TextChanged += new System.EventHandler(this.carName_textBox_TextChanged);
            // 
            // merit_label
            // 
            this.merit_label.AutoSize = true;
            this.merit_label.Location = new System.Drawing.Point(13, 153);
            this.merit_label.Name = "merit_label";
            this.merit_label.Size = new System.Drawing.Size(48, 13);
            this.merit_label.TabIndex = 19;
            this.merit_label.Text = "Заслуги";
            this.merit_label.Click += new System.EventHandler(this.rentalFees_label_Click);
            // 
            // experience_label
            // 
            this.experience_label.AutoSize = true;
            this.experience_label.Location = new System.Drawing.Point(12, 120);
            this.experience_label.Name = "experience_label";
            this.experience_label.Size = new System.Drawing.Size(33, 13);
            this.experience_label.TabIndex = 18;
            this.experience_label.Text = "Стаж";
            this.experience_label.Click += new System.EventHandler(this.mileage_label_Click);
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(12, 90);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(38, 13);
            this.address_label.TabIndex = 17;
            this.address_label.Text = "Адрес";
            this.address_label.Click += new System.EventHandler(this.color_label_Click);
            // 
            // numberTel_label
            // 
            this.numberTel_label.AutoSize = true;
            this.numberTel_label.Location = new System.Drawing.Point(12, 61);
            this.numberTel_label.Name = "numberTel_label";
            this.numberTel_label.Size = new System.Drawing.Size(93, 13);
            this.numberTel_label.TabIndex = 16;
            this.numberTel_label.Text = "Номер телефона";
            this.numberTel_label.Click += new System.EventHandler(this.model_label_Click);
            // 
            // consultantName_label
            // 
            this.consultantName_label.AutoSize = true;
            this.consultantName_label.Location = new System.Drawing.Point(12, 29);
            this.consultantName_label.Name = "consultantName_label";
            this.consultantName_label.Size = new System.Drawing.Size(101, 13);
            this.consultantName_label.TabIndex = 15;
            this.consultantName_label.Text = "Имя консультанта";
            this.consultantName_label.Click += new System.EventHandler(this.carName_label_Click);
            // 
            // AddConsultant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.ErrorBox_label);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.merit_textBox);
            this.Controls.Add(this.experience_textBox);
            this.Controls.Add(this.address_textBox);
            this.Controls.Add(this.numberTel_textBox);
            this.Controls.Add(this.consultantName_textBox);
            this.Controls.Add(this.merit_label);
            this.Controls.Add(this.experience_label);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.numberTel_label);
            this.Controls.Add(this.consultantName_label);
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "AddConsultant";
            this.Text = "AddConsultant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ErrorBox_label;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.TextBox merit_textBox;
        private System.Windows.Forms.TextBox experience_textBox;
        private System.Windows.Forms.TextBox address_textBox;
        private System.Windows.Forms.TextBox numberTel_textBox;
        private System.Windows.Forms.TextBox consultantName_textBox;
        private System.Windows.Forms.Label merit_label;
        private System.Windows.Forms.Label experience_label;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label numberTel_label;
        private System.Windows.Forms.Label consultantName_label;

    }
}