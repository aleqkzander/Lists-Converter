
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
            this.InitialTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OpenInitialListBtn = new System.Windows.Forms.Button();
            this.ClearInitialListBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ConvertedTextBox = new System.Windows.Forms.RichTextBox();
            this.StringTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // InitialTextBox
            // 
            this.InitialTextBox.Location = new System.Drawing.Point(6, 49);
            this.InitialTextBox.Name = "InitialTextBox";
            this.InitialTextBox.Size = new System.Drawing.Size(643, 163);
            this.InitialTextBox.TabIndex = 0;
            this.InitialTextBox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConvertBtn);
            this.groupBox1.Controls.Add(this.ClearInitialListBtn);
            this.groupBox1.Controls.Add(this.OpenInitialListBtn);
            this.groupBox1.Controls.Add(this.InitialTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 220);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Initial List";
            // 
            // OpenInitialListBtn
            // 
            this.OpenInitialListBtn.Location = new System.Drawing.Point(6, 19);
            this.OpenInitialListBtn.Name = "OpenInitialListBtn";
            this.OpenInitialListBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenInitialListBtn.TabIndex = 1;
            this.OpenInitialListBtn.Text = "Open";
            this.OpenInitialListBtn.UseVisualStyleBackColor = true;
            // 
            // ClearInitialListBtn
            // 
            this.ClearInitialListBtn.Location = new System.Drawing.Point(87, 19);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 170);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "String Data";
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.Location = new System.Drawing.Point(168, 19);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(75, 23);
            this.ConvertBtn.TabIndex = 3;
            this.ConvertBtn.Text = "Convert";
            this.ConvertBtn.UseVisualStyleBackColor = true;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ConvertedTextBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 414);
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
            // StringTextBox
            // 
            this.StringTextBox.Location = new System.Drawing.Point(6, 19);
            this.StringTextBox.Name = "StringTextBox";
            this.StringTextBox.Size = new System.Drawing.Size(643, 142);
            this.StringTextBox.TabIndex = 1;
            this.StringTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 589);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "List Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox InitialTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button OpenInitialListBtn;
        private System.Windows.Forms.Button ClearInitialListBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ConvertBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox ConvertedTextBox;
        private System.Windows.Forms.RichTextBox StringTextBox;
    }
}

