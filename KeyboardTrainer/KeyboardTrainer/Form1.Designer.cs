﻿namespace KeyboardTrainer
{
    partial class Form1
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
            title = new Label();
            inputNamelbl = new Label();
            username = new TextBox();
            login = new Button();
            panelUserInput = new Panel();
            panelTraining = new Panel();
            textBox1 = new TextBox();
            keyboard1 = new Keyboard();
            label1 = new Label();
            label2 = new Label();
            panelUserInput.SuspendLayout();
            panelTraining.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(178, 36);
            title.Name = "title";
            title.Size = new Size(376, 52);
            title.TabIndex = 0;
            title.Text = "Клавиатурный тренажер";
            title.TextAlign = ContentAlignment.TopCenter;
            // 
            // inputNamelbl
            // 
            inputNamelbl.AutoSize = true;
            inputNamelbl.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            inputNamelbl.Location = new Point(299, 123);
            inputNamelbl.Name = "inputNamelbl";
            inputNamelbl.Size = new Size(242, 38);
            inputNamelbl.TabIndex = 1;
            inputNamelbl.Text = "Введите ваше имя";
            // 
            // username
            // 
            username.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(232, 180);
            username.Name = "username";
            username.Size = new Size(376, 42);
            username.TabIndex = 2;
            // 
            // login
            // 
            login.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            login.Location = new Point(325, 228);
            login.Name = "login";
            login.Size = new Size(189, 54);
            login.TabIndex = 3;
            login.Text = "НАЧАТЬ";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // panelUserInput
            // 
            panelUserInput.Controls.Add(login);
            panelUserInput.Controls.Add(title);
            panelUserInput.Controls.Add(username);
            panelUserInput.Controls.Add(inputNamelbl);
            panelUserInput.Dock = DockStyle.Fill;
            panelUserInput.Location = new Point(0, 0);
            panelUserInput.Name = "panelUserInput";
            panelUserInput.Size = new Size(1292, 747);
            panelUserInput.TabIndex = 4;
            // 
            // panelTraining
            // 
            panelTraining.Controls.Add(label2);
            panelTraining.Controls.Add(label1);
            panelTraining.Controls.Add(textBox1);
            panelTraining.Controls.Add(keyboard1);
            panelTraining.Dock = DockStyle.Fill;
            panelTraining.Location = new Point(0, 0);
            panelTraining.Name = "panelTraining";
            panelTraining.Size = new Size(1292, 747);
            panelTraining.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 306);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1268, 35);
            textBox1.TabIndex = 1;
            // 
            // keyboard1
            // 
            keyboard1.BackgroundImageLayout = ImageLayout.Stretch;
            keyboard1.Location = new Point(5, 347);
            keyboard1.Name = "keyboard1";
            keyboard1.Size = new Size(1284, 400);
            keyboard1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(173, 32);
            label1.TabIndex = 2;
            label1.Text = "Пользователь:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(191, 9);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 747);
            Controls.Add(panelTraining);
            Controls.Add(panelUserInput);
            Name = "Form1";
            Text = "Form1";
            Resize += Form1_Resize;
            panelUserInput.ResumeLayout(false);
            panelUserInput.PerformLayout();
            panelTraining.ResumeLayout(false);
            panelTraining.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label title;
        private Label inputNamelbl;
        private TextBox username;
        private Button login;
        private Panel panelUserInput;
        private Panel panelTraining;
        private Keyboard keyboard1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}
