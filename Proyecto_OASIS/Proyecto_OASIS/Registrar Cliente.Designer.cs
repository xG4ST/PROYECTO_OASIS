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
            this.registerpassword_textbox = new System.Windows.Forms.TextBox();
            this.registeruser_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
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
            this.lbhora.Location = new System.Drawing.Point(655, -1);
            this.lbhora.Name = "lbhora";
            this.lbhora.Size = new System.Drawing.Size(130, 70);
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
            this.register_button.Location = new System.Drawing.Point(929, 639);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(397, 111);
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
            this.back_button.Location = new System.Drawing.Point(253, 639);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(364, 111);
            this.back_button.TabIndex = 34;
            this.back_button.Text = "REGRESAR";
            this.back_button.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("BigNoodleTitling", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.label2.Location = new System.Drawing.Point(109, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 104);
            this.label2.TabIndex = 33;
            this.label2.Text = "TELEFONO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("BigNoodleTitling", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(187, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 104);
            this.label1.TabIndex = 32;
            this.label1.Text = "E-MAIL:";
            // 
            // registerpassword_textbox
            // 
            this.registerpassword_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.registerpassword_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerpassword_textbox.Font = new System.Drawing.Font("BigNoodleTitling", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerpassword_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.registerpassword_textbox.Location = new System.Drawing.Point(458, 182);
            this.registerpassword_textbox.Multiline = true;
            this.registerpassword_textbox.Name = "registerpassword_textbox";
            this.registerpassword_textbox.PasswordChar = '*';
            this.registerpassword_textbox.Size = new System.Drawing.Size(878, 110);
            this.registerpassword_textbox.TabIndex = 31;
            // 
            // registeruser_textbox
            // 
            this.registeruser_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.registeruser_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registeruser_textbox.Font = new System.Drawing.Font("BigNoodleTitling", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registeruser_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.registeruser_textbox.Location = new System.Drawing.Point(448, 468);
            this.registeruser_textbox.Multiline = true;
            this.registeruser_textbox.Name = "registeruser_textbox";
            this.registeruser_textbox.Size = new System.Drawing.Size(878, 110);
            this.registeruser_textbox.TabIndex = 30;
            // 
            // name_textbox
            // 
            this.name_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.name_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_textbox.Font = new System.Drawing.Font("BigNoodleTitling", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.name_textbox.Location = new System.Drawing.Point(458, 314);
            this.name_textbox.Multiline = true;
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(878, 110);
            this.name_textbox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("BigNoodleTitling", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(109)))));
            this.label3.Location = new System.Drawing.Point(163, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 104);
            this.label3.TabIndex = 28;
            this.label3.Text = "CLIENTE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("BigNoodleTitling", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(194)))), ((int)(((byte)(149)))));
            this.label4.Location = new System.Drawing.Point(-4, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 70);
            this.label4.TabIndex = 36;
            this.label4.Text = "SNACK OASIS";
            // 
            // Registrar_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_OASIS.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerpassword_textbox);
            this.Controls.Add(this.registeruser_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbhora);
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
        private System.Windows.Forms.TextBox registerpassword_textbox;
        private System.Windows.Forms.TextBox registeruser_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}