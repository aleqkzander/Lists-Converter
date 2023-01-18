
namespace List_Converter
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
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.ClearInitialListBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StringTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ConvertedTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.Location = new System.Drawing.Point(12, 12);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(75, 23);
            this.ConvertBtn.TabIndex = 3;
            this.ConvertBtn.Text = "Convert";
            this.ConvertBtn.UseVisualStyleBackColor = true;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // ClearInitialListBtn
            // 
            this.ClearInitialListBtn.Location = new System.Drawing.Point(93, 12);
            this.ClearInitialListBtn.Name = "ClearInitialListBtn";
            this.ClearInitialListBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearInitialListBtn.TabIndex = 2;
            this.ClearInitialListBtn.Text = "Clear";
            this.ClearInitialListBtn.UseVisualStyleBackColor = true;
            this.ClearInitialListBtn.Click += new System.EventHandler(this.ClearInitialListBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StringTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 170);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "String Data";
            // 
            // StringTextBox
            // 
            this.StringTextBox.Location = new System.Drawing.Point(6, 19);
            this.StringTextBox.Name = "StringTextBox";
            this.StringTextBox.Size = new System.Drawing.Size(643, 142);
            this.StringTextBox.TabIndex = 1;
            this.StringTextBox.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ConvertedTextBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(655, 167);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Converted data";
            // 
            // ConvertedTextBox
            // 
            this.ConvertedTextBox.Location = new System.Drawing.Point(6, 19);
            this.ConvertedTextBox.Name = "ConvertedTextBox";
            this.ConvertedTextBox.Size = new System.Drawing.Size(643, 142);
            this.ConvertedTextBox.TabIndex = 0;
            this.ConvertedTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 395);
            this.Controls.Add(this.ClearInitialListBtn);
            this.Controls.Add(this.ConvertBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "List Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ClearInitialListBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ConvertBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox ConvertedTextBox;
        private System.Windows.Forms.RichTextBox StringTextBox;
    }
}

