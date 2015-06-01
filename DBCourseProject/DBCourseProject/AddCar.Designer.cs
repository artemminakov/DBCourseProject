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
    partial class AddCar : Form
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
            this.carName_label = new System.Windows.Forms.Label();
            this.model_label = new System.Windows.Forms.Label();
            this.color_label = new System.Windows.Forms.Label();
            this.mileage_label = new System.Windows.Forms.Label();
            this.rentalFees_label = new System.Windows.Forms.Label();
            this.capacity_label = new System.Windows.Forms.Label();
            this.carName_textBox = new System.Windows.Forms.TextBox();
            this.model_textBox = new System.Windows.Forms.TextBox();
            this.color_textBox = new System.Windows.Forms.TextBox();
            this.mileage_textBox = new System.Windows.Forms.TextBox();
            this.rentalFees_textBox = new System.Windows.Forms.TextBox();
            this.capacity_textBox = new System.Windows.Forms.TextBox();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.ErrorBox_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // carName_label
            // 
            this.carName_label.AutoSize = true;
            this.carName_label.Location = new System.Drawing.Point(12, 15);
            this.carName_label.Name = "carName_label";
            this.carName_label.Size = new System.Drawing.Size(40, 13);
            this.carName_label.TabIndex = 0;
            this.carName_label.Text = "Марка";
            // 
            // model_label
            // 
            this.model_label.AutoSize = true;
            this.model_label.Location = new System.Drawing.Point(12, 47);
            this.model_label.Name = "model_label";
            this.model_label.Size = new System.Drawing.Size(46, 13);
            this.model_label.TabIndex = 1;
            this.model_label.Text = "Модель";
            // 
            // color_label
            // 
            this.color_label.AutoSize = true;
            this.color_label.Location = new System.Drawing.Point(12, 76);
            this.color_label.Name = "color_label";
            this.color_label.Size = new System.Drawing.Size(32, 13);
            this.color_label.TabIndex = 2;
            this.color_label.Text = "Цвет";
            // 
            // mileage_label
            // 
            this.mileage_label.AutoSize = true;
            this.mileage_label.Location = new System.Drawing.Point(12, 106);
            this.mileage_label.Name = "mileage_label";
            this.mileage_label.Size = new System.Drawing.Size(44, 13);
            this.mileage_label.TabIndex = 3;
            this.mileage_label.Text = "Пробег";
            // 
            // rentalFees_label
            // 
            this.rentalFees_label.AutoSize = true;
            this.rentalFees_label.Location = new System.Drawing.Point(13, 139);
            this.rentalFees_label.Name = "rentalFees_label";
            this.rentalFees_label.Size = new System.Drawing.Size(106, 13);
            this.rentalFees_label.TabIndex = 4;
            this.rentalFees_label.Text = "Стоимость проката";
            // 
            // capacity_label
            // 
            this.capacity_label.AutoSize = true;
            this.capacity_label.Location = new System.Drawing.Point(13, 172);
            this.capacity_label.Name = "capacity_label";
            this.capacity_label.Size = new System.Drawing.Size(76, 13);
            this.capacity_label.TabIndex = 5;
            this.capacity_label.Text = "Вместимость";
            // 
            // carName_textBox
            // 
            this.carName_textBox.Location = new System.Drawing.Point(194, 12);
            this.carName_textBox.Name = "carName_textBox";
            this.carName_textBox.Size = new System.Drawing.Size(278, 20);
            this.carName_textBox.TabIndex = 6;
            // 
            // model_textBox
            // 
            this.model_textBox.Location = new System.Drawing.Point(194, 44);
            this.model_textBox.Name = "model_textBox";
            this.model_textBox.Size = new System.Drawing.Size(278, 20);
            this.model_textBox.TabIndex = 7;
            // 
            // color_textBox
            // 
            this.color_textBox.Location = new System.Drawing.Point(194, 73);
            this.color_textBox.Name = "color_textBox";
            this.color_textBox.Size = new System.Drawing.Size(278, 20);
            this.color_textBox.TabIndex = 8;
            // 
            // mileage_textBox
            // 
            this.mileage_textBox.Location = new System.Drawing.Point(194, 103);
            this.mileage_textBox.Name = "mileage_textBox";
            this.mileage_textBox.Size = new System.Drawing.Size(278, 20);
            this.mileage_textBox.TabIndex = 9;
            // 
            // rentalFees_textBox
            // 
            this.rentalFees_textBox.Location = new System.Drawing.Point(194, 136);
            this.rentalFees_textBox.Name = "rentalFees_textBox";
            this.rentalFees_textBox.Size = new System.Drawing.Size(278, 20);
            this.rentalFees_textBox.TabIndex = 10;
            // 
            // capacity_textBox
            // 
            this.capacity_textBox.Location = new System.Drawing.Point(194, 169);
            this.capacity_textBox.Name = "capacity_textBox";
            this.capacity_textBox.Size = new System.Drawing.Size(278, 20);
            this.capacity_textBox.TabIndex = 11;
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(111, 248);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(93, 39);
            this.ok_button.TabIndex = 12;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(239, 248);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(95, 39);
            this.cancel_button.TabIndex = 13;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // ErrorBox_label
            // 
            this.ErrorBox_label.AutoSize = true;
            this.ErrorBox_label.Location = new System.Drawing.Point(125, 201);
            this.ErrorBox_label.Name = "ErrorBox_label";
            this.ErrorBox_label.Size = new System.Drawing.Size(0, 13);
            this.ErrorBox_label.TabIndex = 14;
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.ErrorBox_label);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.capacity_textBox);
            this.Controls.Add(this.rentalFees_textBox);
            this.Controls.Add(this.mileage_textBox);
            this.Controls.Add(this.color_textBox);
            this.Controls.Add(this.model_textBox);
            this.Controls.Add(this.carName_textBox);
            this.Controls.Add(this.capacity_label);
            this.Controls.Add(this.rentalFees_label);
            this.Controls.Add(this.mileage_label);
            this.Controls.Add(this.color_label);
            this.Controls.Add(this.model_label);
            this.Controls.Add(this.carName_label);
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 0);
            this.Name = "AddCar";
            this.Text = "AddCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label carName_label;
        private Label model_label;
        private Label color_label;
        private Label mileage_label;
        private Label rentalFees_label;
        private Label capacity_label;
        private TextBox carName_textBox;
        private TextBox model_textBox;
        private TextBox color_textBox;
        private TextBox mileage_textBox;
        private TextBox rentalFees_textBox;
        private TextBox capacity_textBox;
        private Button ok_button;
        private Button cancel_button;
        private Label ErrorBox_label;
    }
}