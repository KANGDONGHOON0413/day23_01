
namespace day23_01
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PW_01 = new System.Windows.Forms.TextBox();
            this.ID_01 = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_FindID = new System.Windows.Forms.Button();
            this.btn_FindPW = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "PW";
            // 
            // PW_01
            // 
            this.PW_01.Location = new System.Drawing.Point(42, 61);
            this.PW_01.Name = "PW_01";
            this.PW_01.PasswordChar = '*';
            this.PW_01.Size = new System.Drawing.Size(125, 27);
            this.PW_01.TabIndex = 3;
            // 
            // ID_01
            // 
            this.ID_01.Location = new System.Drawing.Point(42, 21);
            this.ID_01.Name = "ID_01";
            this.ID_01.Size = new System.Drawing.Size(125, 27);
            this.ID_01.TabIndex = 4;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(182, 19);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(74, 69);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_FindID
            // 
            this.btn_FindID.Location = new System.Drawing.Point(12, 94);
            this.btn_FindID.Name = "btn_FindID";
            this.btn_FindID.Size = new System.Drawing.Size(115, 29);
            this.btn_FindID.TabIndex = 6;
            this.btn_FindID.Text = "Find ID";
            this.btn_FindID.UseVisualStyleBackColor = true;
            // 
            // btn_FindPW
            // 
            this.btn_FindPW.Location = new System.Drawing.Point(133, 94);
            this.btn_FindPW.Name = "btn_FindPW";
            this.btn_FindPW.Size = new System.Drawing.Size(123, 29);
            this.btn_FindPW.TabIndex = 7;
            this.btn_FindPW.Text = "Find PW";
            this.btn_FindPW.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_FindPW);
            this.Controls.Add(this.btn_FindID);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.ID_01);
            this.Controls.Add(this.PW_01);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PW_01;
        private System.Windows.Forms.TextBox ID_01;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_FindID;
        private System.Windows.Forms.Button btn_FindPW;
    }
}
