namespace Övning_12._3
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
            this.lblAntal = new System.Windows.Forms.Label();
            this.lblSök = new System.Windows.Forms.Label();
            this.lblOutPut = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnBinarySearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAntal
            // 
            this.lblAntal.AutoSize = true;
            this.lblAntal.Location = new System.Drawing.Point(61, 46);
            this.lblAntal.Name = "lblAntal";
            this.lblAntal.Size = new System.Drawing.Size(37, 16);
            this.lblAntal.TabIndex = 0;
            this.lblAntal.Text = "Antal";
            // 
            // lblSök
            // 
            this.lblSök.AutoSize = true;
            this.lblSök.Location = new System.Drawing.Point(61, 89);
            this.lblSök.Name = "lblSök";
            this.lblSök.Size = new System.Drawing.Size(31, 16);
            this.lblSök.TabIndex = 1;
            this.lblSök.Text = "Sök";
            // 
            // lblOutPut
            // 
            this.lblOutPut.AutoSize = true;
            this.lblOutPut.Location = new System.Drawing.Point(281, 146);
            this.lblOutPut.Name = "lblOutPut";
            this.lblOutPut.Size = new System.Drawing.Size(44, 16);
            this.lblOutPut.TabIndex = 2;
            this.lblOutPut.Text = "label3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(334, 44);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generera";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(334, 89);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Sök";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(122, 196);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 7;
            this.btnSort.Text = "Sortera";
            this.btnSort.UseVisualStyleBackColor = true;
            // 
            // btnBinarySearch
            // 
            this.btnBinarySearch.Enabled = false;
            this.btnBinarySearch.Location = new System.Drawing.Point(250, 196);
            this.btnBinarySearch.Name = "btnBinarySearch";
            this.btnBinarySearch.Size = new System.Drawing.Size(75, 23);
            this.btnBinarySearch.TabIndex = 8;
            this.btnBinarySearch.Text = "Binärsök";
            this.btnBinarySearch.UseVisualStyleBackColor = true;
            this.btnBinarySearch.Click += new System.EventHandler(this.btnBinarySearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBinarySearch);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblOutPut);
            this.Controls.Add(this.lblSök);
            this.Controls.Add(this.lblAntal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAntal;
        private System.Windows.Forms.Label lblSök;
        private System.Windows.Forms.Label lblOutPut;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnBinarySearch;
    }
}

