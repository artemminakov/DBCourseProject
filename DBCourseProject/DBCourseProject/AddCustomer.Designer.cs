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
    partial class AddCustomer : Form
    {

        private Form1 mainForm;
        public AddCustomer(Form1 _mainForm)
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
            this.characteristics_textBox = new System.Windows.Forms.TextBox();
            this.issuanceRights_textBox = new System.Windows.Forms.TextBox();
            this.creditCard_textBox = new System.Windows.Forms.TextBox();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.numberTel_textBox = new System.Windows.Forms.TextBox();
            this.customerName_textBox = new System.Windows.Forms.TextBox();
            this.characteristics_label = new System.Windows.Forms.Label();
            this.issuanceRights_label = new System.Windows.Forms.Label();
            this.creditCard_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.numberTel_label = new System.Windows.Forms.Label();
            this.customerName_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ErrorBox_label
            // 
            this.ErrorBox_label.AutoSize = true;
            this.ErrorBox_label.Location = new System.Drawing.Point(125, 210);
            this.ErrorBox_label.Name = "ErrorBox_label";
            this.ErrorBox_label.Size = new System.Drawing.Size(0, 13);
            this.ErrorBox_label.TabIndex = 29;
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(239, 257);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(95, 39);
            this.cancel_button.TabIndex = 28;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(111, 257);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(93, 39);
            this.ok_button.TabIndex = 27;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // characteristics_textBox
            // 
            this.characteristics_textBox.Location = new System.Drawing.Point(194, 178);
            this.characteristics_textBox.Name = "characteristics_textBox";
            this.characteristics_textBox.Size = new System.Drawing.Size(278, 20);
            this.characteristics_textBox.TabIndex = 26;
            // 
            // issuanceRights_textBox
            // 
            this.issuanceRights_textBox.Location = new System.Drawing.Point(194, 145);
            this.issuanceRights_textBox.Name = "issuanceRights_textBox";
            this.issuanceRights_textBox.Size = new System.Drawing.Size(278, 20);
            this.issuanceRights_textBox.TabIndex = 25;
            // 
            // creditCard_textBox
            // 
            this.creditCard_textBox.Location = new System.Drawing.Point(194, 112);
            this.creditCard_textBox.Name = "creditCard_textBox";
            this.creditCard_textBox.Size = new System.Drawing.Size(278, 20);
            this.creditCard_textBox.TabIndex = 24;
            // 
            // address_textBox
            // 
            this.address_textBox.Location = new System.Drawing.Point(194, 82);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(278, 20);
            this.address_textBox.TabIndex = 23;
            // 
            // numberTel_textBox
            // 
            this.numberTel_textBox.Location = new System.Drawing.Point(194, 53);
            this.numberTel_textBox.Name = "numberTel_textBox";
            this.numberTel_textBox.Size = new System.Drawing.Size(278, 20);
            this.numberTel_textBox.TabIndex = 22;
            // 
            // customerName_textBox
            // 
            this.customerName_textBox.Location = new System.Drawing.Point(194, 21);
            this.customerName_textBox.Name = "customerName_textBox";
            this.customerName_textBox.Size = new System.Drawing.Size(278, 20);
            this.customerName_textBox.TabIndex = 21;
            // 
            // characteristics_label
            // 
            this.characteristics_label.AutoSize = true;
            this.characteristics_label.Location = new System.Drawing.Point(13, 181);
            this.characteristics_label.Name = "characteristics_label";
            this.characteristics_label.Size = new System.Drawing.Size(90, 13);
            this.characteristics_label.TabIndex = 20;
            this.characteristics_label.Text = "Характеристика";
            // 
            // issuanceRights_label
            // 
            this.issuanceRights_label.AutoSize = true;
            this.issuanceRights_label.Location = new System.Drawing.Point(13, 148);
            this.issuanceRights_label.Name = "issuanceRights_label";
            this.issuanceRights_label.Size = new System.Drawing.Size(116, 13);
            this.issuanceRights_label.TabIndex = 19;
            this.issuanceRights_label.Text = "Дата окончания прав";
            // 
            // creditCard_label
            // 
            this.creditCard_label.AutoSize = true;
            this.creditCard_label.Location = new System.Drawing.Point(12, 115);
            this.creditCard_label.Name = "creditCard_label";
            this.creditCard_label.Size = new System.Drawing.Size(131, 13);
            this.creditCard_label.TabIndex = 18;
            this.creditCard_label.Text = "Номер кредитной карты";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(12, 85);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(38, 13);
            this.address_label.TabIndex = 17;
            this.address_label.Text = "Адрес";
            // 
            // numberTel_label
            // 
            this.numberTel_label.AutoSize = true;
            this.numberTel_label.Location = new System.Drawing.Point(12, 56);
            this.numberTel_label.Name = "numberTel_label";
            this.numberTel_label.Size = new System.Drawing.Size(93, 13);
            this.numberTel_label.TabIndex = 16;
            this.numberTel_label.Text = "Номер телефона";
            // 
            // customerName_label
            // 
            this.customerName_label.AutoSize = true;
            this.customerName_label.Location = new System.Drawing.Point(12, 24);
            this.customerName_label.Name = "customerName_label";
            this.customerName_label.Size = new System.Drawing.Size(73, 13);
            this.customerName_label.TabIndex = 15;
            this.customerName_label.Text = "Имя клиента";
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.ErrorBox_label);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.characteristics_textBox);
            this.Controls.Add(this.issuanceRights_textBox);
            this.Controls.Add(this.creditCard_textBox);
            this.Controls.Add(this.address_textBox);
            this.Controls.Add(this.numberTel_textBox);
            this.Controls.Add(this.customerName_textBox);
            this.Controls.Add(this.characteristics_label);
            this.Controls.Add(this.issuanceRights_label);
            this.Controls.Add(this.creditCard_label);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.numberTel_label);
            this.Controls.Add(this.customerName_label);
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ErrorBox_label;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.TextBox characteristics_textBox;
        private System.Windows.Forms.TextBox issuanceRights_textBox;
        private System.Windows.Forms.TextBox creditCard_textBox;
        private System.Windows.Forms.TextBox address_textBox;
        private System.Windows.Forms.TextBox numberTel_textBox;
        private System.Windows.Forms.TextBox customerName_textBox;
        private System.Windows.Forms.Label characteristics_label;
        private System.Windows.Forms.Label issuanceRights_label;
        private System.Windows.Forms.Label creditCard_label;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label numberTel_label;
        private System.Windows.Forms.Label customerName_label;
    }
}