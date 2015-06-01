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
    partial class AddContract : Form
    {
        private Form1 mainForm;
        public AddContract(Form1 _mainForm)
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
            this.dateDrawingContract_textBox = new System.Windows.Forms.TextBox();
            this.expiryDateLease_textBox = new System.Windows.Forms.TextBox();
            this.notes_textBox = new System.Windows.Forms.TextBox();
            this.consultantID_textBox = new System.Windows.Forms.TextBox();
            this.carID_textBox = new System.Windows.Forms.TextBox();
            this.customerID_textBox = new System.Windows.Forms.TextBox();
            this.dateDrawingContract_label = new System.Windows.Forms.Label();
            this.expiryDateLease_label = new System.Windows.Forms.Label();
            this.notes_label = new System.Windows.Forms.Label();
            this.consultantID_label = new System.Windows.Forms.Label();
            this.carID_label = new System.Windows.Forms.Label();
            this.customerID_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ErrorBox_label
            // 
            this.ErrorBox_label.AutoSize = true;
            this.ErrorBox_label.Location = new System.Drawing.Point(125, 216);
            this.ErrorBox_label.Name = "ErrorBox_label";
            this.ErrorBox_label.Size = new System.Drawing.Size(0, 13);
            this.ErrorBox_label.TabIndex = 29;
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(239, 263);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(95, 39);
            this.cancel_button.TabIndex = 28;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(111, 263);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(93, 39);
            this.ok_button.TabIndex = 27;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // dateDrawingContract_textBox
            // 
            this.dateDrawingContract_textBox.Location = new System.Drawing.Point(194, 184);
            this.dateDrawingContract_textBox.Name = "dateDrawingContract_textBox";
            this.dateDrawingContract_textBox.Size = new System.Drawing.Size(278, 20);
            this.dateDrawingContract_textBox.TabIndex = 26;
            // 
            // expiryDateLease_textBox
            // 
            this.expiryDateLease_textBox.Location = new System.Drawing.Point(194, 151);
            this.expiryDateLease_textBox.Name = "expiryDateLease_textBox";
            this.expiryDateLease_textBox.Size = new System.Drawing.Size(278, 20);
            this.expiryDateLease_textBox.TabIndex = 25;
            // 
            // notes_textBox
            // 
            this.notes_textBox.Location = new System.Drawing.Point(194, 118);
            this.notes_textBox.Name = "notes_textBox";
            this.notes_textBox.Size = new System.Drawing.Size(278, 20);
            this.notes_textBox.TabIndex = 24;
            // 
            // consultantID_textBox
            // 
            this.consultantID_textBox.Location = new System.Drawing.Point(194, 88);
            this.consultantID_textBox.Name = "consultantID_textBox";
            this.consultantID_textBox.Size = new System.Drawing.Size(278, 20);
            this.consultantID_textBox.TabIndex = 23;
            // 
            // carID_textBox
            // 
            this.carID_textBox.Location = new System.Drawing.Point(194, 59);
            this.carID_textBox.Name = "carID_textBox";
            this.carID_textBox.Size = new System.Drawing.Size(278, 20);
            this.carID_textBox.TabIndex = 22;
            // 
            // customerID_textBox
            // 
            this.customerID_textBox.Location = new System.Drawing.Point(194, 27);
            this.customerID_textBox.Name = "customerID_textBox";
            this.customerID_textBox.Size = new System.Drawing.Size(278, 20);
            this.customerID_textBox.TabIndex = 21;
            // 
            // dateDrawingContract_label
            // 
            this.dateDrawingContract_label.AutoSize = true;
            this.dateDrawingContract_label.Location = new System.Drawing.Point(13, 187);
            this.dateDrawingContract_label.Name = "dateDrawingContract_label";
            this.dateDrawingContract_label.Size = new System.Drawing.Size(151, 13);
            this.dateDrawingContract_label.TabIndex = 20;
            this.dateDrawingContract_label.Text = "Дата подписания контракта";
            // 
            // expiryDateLease_label
            // 
            this.expiryDateLease_label.AutoSize = true;
            this.expiryDateLease_label.Location = new System.Drawing.Point(13, 154);
            this.expiryDateLease_label.Name = "expiryDateLease_label";
            this.expiryDateLease_label.Size = new System.Drawing.Size(130, 13);
            this.expiryDateLease_label.TabIndex = 19;
            this.expiryDateLease_label.Text = "Дата окончания аренды";
            // 
            // notes_label
            // 
            this.notes_label.AutoSize = true;
            this.notes_label.Location = new System.Drawing.Point(12, 121);
            this.notes_label.Name = "notes_label";
            this.notes_label.Size = new System.Drawing.Size(51, 13);
            this.notes_label.TabIndex = 18;
            this.notes_label.Text = "Заметки";
            // 
            // consultantID_label
            // 
            this.consultantID_label.AutoSize = true;
            this.consultantID_label.Location = new System.Drawing.Point(12, 91);
            this.consultantID_label.Name = "consultantID_label";
            this.consultantID_label.Size = new System.Drawing.Size(113, 13);
            this.consultantID_label.TabIndex = 17;
            this.consultantID_label.Text = "Номер консультанта";
            // 
            // carID_label
            // 
            this.carID_label.AutoSize = true;
            this.carID_label.Location = new System.Drawing.Point(12, 62);
            this.carID_label.Name = "carID_label";
            this.carID_label.Size = new System.Drawing.Size(105, 13);
            this.carID_label.TabIndex = 16;
            this.carID_label.Text = "Номер автомобиля";
            // 
            // customerID_label
            // 
            this.customerID_label.AutoSize = true;
            this.customerID_label.Location = new System.Drawing.Point(12, 30);
            this.customerID_label.Name = "customerID_label";
            this.customerID_label.Size = new System.Drawing.Size(85, 13);
            this.customerID_label.TabIndex = 15;
            this.customerID_label.Text = "Номер клиента";
            // 
            // AddContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.ErrorBox_label);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.dateDrawingContract_textBox);
            this.Controls.Add(this.expiryDateLease_textBox);
            this.Controls.Add(this.notes_textBox);
            this.Controls.Add(this.consultantID_textBox);
            this.Controls.Add(this.carID_textBox);
            this.Controls.Add(this.customerID_textBox);
            this.Controls.Add(this.dateDrawingContract_label);
            this.Controls.Add(this.expiryDateLease_label);
            this.Controls.Add(this.notes_label);
            this.Controls.Add(this.consultantID_label);
            this.Controls.Add(this.carID_label);
            this.Controls.Add(this.customerID_label);
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "AddContract";
            this.Text = "AddContract";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ErrorBox_label;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.TextBox dateDrawingContract_textBox;
        private System.Windows.Forms.TextBox expiryDateLease_textBox;
        private System.Windows.Forms.TextBox notes_textBox;
        private System.Windows.Forms.TextBox consultantID_textBox;
        private System.Windows.Forms.TextBox carID_textBox;
        private System.Windows.Forms.TextBox customerID_textBox;
        private System.Windows.Forms.Label dateDrawingContract_label;
        private System.Windows.Forms.Label expiryDateLease_label;
        private System.Windows.Forms.Label notes_label;
        private System.Windows.Forms.Label consultantID_label;
        private System.Windows.Forms.Label carID_label;
        private System.Windows.Forms.Label customerID_label;
    }
}