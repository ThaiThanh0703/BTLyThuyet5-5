namespace MailForm
{
    partial class DieuHuong
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
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReceive
            // 
            this.btnReceive.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceive.Location = new System.Drawing.Point(252, 49);
            this.btnReceive.Margin = new System.Windows.Forms.Padding(4);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(184, 55);
            this.btnReceive.TabIndex = 1;
            this.btnReceive.Text = "Receive Mail";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(30, 49);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(180, 55);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send Mail";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // DieuHuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 154);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.btnSend);
            this.Name = "DieuHuong";
            this.Text = "DieuHuong";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Button btnSend;
    }
}