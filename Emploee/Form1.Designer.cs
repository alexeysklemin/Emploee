
namespace Emploee
{
    partial class Form1
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
            this.userlbn = new System.Windows.Forms.Label();
            this.pswdlbn = new System.Windows.Forms.Label();
            this.pswdBox = new System.Windows.Forms.TextBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.sinupBtn = new System.Windows.Forms.Button();
            this.emloeesDataSet1 = new Emploee.emloeesDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.emloeesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // userlbn
            // 
            this.userlbn.AutoSize = true;
            this.userlbn.Location = new System.Drawing.Point(100, 127);
            this.userlbn.Name = "userlbn";
            this.userlbn.Size = new System.Drawing.Size(36, 17);
            this.userlbn.TabIndex = 0;
            this.userlbn.Text = "user";
            // 
            // pswdlbn
            // 
            this.pswdlbn.AutoSize = true;
            this.pswdlbn.Location = new System.Drawing.Point(100, 193);
            this.pswdlbn.Name = "pswdlbn";
            this.pswdlbn.Size = new System.Drawing.Size(68, 17);
            this.pswdlbn.TabIndex = 1;
            this.pswdlbn.Text = "password";
            // 
            // pswdBox
            // 
            this.pswdBox.Location = new System.Drawing.Point(205, 188);
            this.pswdBox.Name = "pswdBox";
            this.pswdBox.Size = new System.Drawing.Size(100, 22);
            this.pswdBox.TabIndex = 2;
            this.pswdBox.UseSystemPasswordChar = true;
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(205, 122);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(100, 22);
            this.userBox.TabIndex = 3;
            // 
            // sinupBtn
            // 
            this.sinupBtn.Location = new System.Drawing.Point(388, 366);
            this.sinupBtn.Name = "sinupBtn";
            this.sinupBtn.Size = new System.Drawing.Size(75, 23);
            this.sinupBtn.TabIndex = 4;
            this.sinupBtn.Text = "OK";
            this.sinupBtn.UseVisualStyleBackColor = true;
            this.sinupBtn.Click += new System.EventHandler(this.sinupBtn_Click);
            // 
            // emloeesDataSet1
            // 
            this.emloeesDataSet1.DataSetName = "emloeesDataSet";
            this.emloeesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sinupBtn);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.pswdBox);
            this.Controls.Add(this.pswdlbn);
            this.Controls.Add(this.userlbn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.emloeesDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userlbn;
        private System.Windows.Forms.Label pswdlbn;
        private System.Windows.Forms.TextBox pswdBox;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Button sinupBtn;
        private emloeesDataSet emloeesDataSet1;
    }
}

