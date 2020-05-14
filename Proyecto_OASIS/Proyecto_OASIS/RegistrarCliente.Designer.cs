namespace Proyecto_OASIS
{
    partial class Registrar_Cliente
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
            this.lbhora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.register_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.client_textbox = new System.Windows.Forms.TextBox();
            this.tel_textbox = new System.Windows.Forms.TextBox();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbhora
            // 
            this.lbhora.AutoSize = true;
            this.lbhora.BackColor = System.Drawing.Color.Transparent;
            this.lbhora.Font = new System.Drawing.Font("BigNoodleTitling", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(194)))), ((int)(((byte)(149)))));
            this.lbhora.Location = new System.Drawing.Point(1313, 11);
            this.lbhora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbhora.Name = "lbhora";
            this.lbhora.Size = new System.Drawing.Size(162, 87);
            this.lbhora.TabIndex = 27;
            this.lbhora.Text = "HORA";
            this.lbhora.Click += new System.EventHandler(this.Lbhora_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // register_button
            // 
            this.register_button.BackColor = System.Drawing.Color.Yellow;
            this.register_button.Font = new System.Drawing.Font("BigNoodleTitling", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.register_button.Location = new System.Drawing.Point(1239, 786);
            this.register_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(529, 137);
            this.register_button.TabIndex = 35;
            this.register_button.Text = "Registrar";
            this.register_button.UseVisualStyleBackColor = false;
            this.register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Yellow;
            this.back_button.Font = new System.Drawing.Font("BigNoodleTitling", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.back_button.Location = new System.Drawing.Point(337, 786);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(485, 137);
            this.back_button.TabIndex = 34;
            this.back_button.Text = "REGRESAR";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("BigNoodleTitling", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.label2.Location = new System.Drawing.Point(145, 583);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 130);
            this.label2.TabIndex = 33;
            this.label2.Text = "TELEFONO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("BigNoodleTitling", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(249, 394);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 130);
            this.label1.TabIndex = 32;
            this.label1.Text = "E-MAIL:";
            // 
            // client_textbox
            // 
            this.client_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.client_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.client_textbox.Font = new System.Drawing.Font("BigNoodleTitling", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.client_textbox.Location = new System.Drawing.Point(611, 224);
            this.client_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.client_textbox.Multiline = true;
            this.client_textbox.Name = "client_textbox";
            this.client_textbox.Size = new System.Drawing.Size(1171, 135);
            this.client_textbox.TabIndex = 31;
            // 
            // tel_textbox
            // 
            this.tel_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.tel_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tel_textbox.Font = new System.Drawing.Font("BigNoodleTitling", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tel_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.tel_textbox.Location = new System.Drawing.Point(597, 576);
            this.tel_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tel_textbox.Multiline = true;
            this.tel_textbox.Name = "tel_textbox";
            this.tel_textbox.Size = new System.Drawing.Size(1171, 135);
            this.tel_textbox.TabIndex = 30;
            this.tel_textbox.TextChanged += new System.EventHandler(this.tel_textbox_TextChanged);
            this.tel_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tel_textbox_KeyPress);
            // 
            // email_textbox
            // 
            this.email_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.email_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_textbox.Font = new System.Drawing.Font("BigNoodleTitling", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.email_textbox.Location = new System.Drawing.Point(611, 386);
            this.email_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.email_textbox.Multiline = true;
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(1171, 135);
            this.email_textbox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("BigNoodleTitling", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.label3.Location = new System.Drawing.Point(217, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 130);
            this.label3.TabIndex = 28;
            this.label3.Text = "CLIENTE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("BigNoodleTitling", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(194)))), ((int)(((byte)(149)))));
            this.label4.Location = new System.Drawing.Point(-5, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 87);
            this.label4.TabIndex = 36;
            this.label4.Text = "SNACK OASIS";
            // 
            // Registrar_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_OASIS.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(2072, 1060);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.client_textbox);
            this.Controls.Add(this.tel_textbox);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbhora);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Registrar_Cliente";
            this.Text = "Registrar_Cliente";
            this.Load += new System.EventHandler(this.Registrar_Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbhora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox client_textbox;
        private System.Windows.Forms.TextBox tel_textbox;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        }
    }