namespace praktikumweek13
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
            this.button1Proses = new System.Windows.Forms.Button();
            this.label1Empty = new System.Windows.Forms.Label();
            this.textBox1Tulisan = new System.Windows.Forms.TextBox();
            this.label1InputData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1Proses
            // 
            this.button1Proses.Location = new System.Drawing.Point(30, 74);
            this.button1Proses.Name = "button1Proses";
            this.button1Proses.Size = new System.Drawing.Size(75, 23);
            this.button1Proses.TabIndex = 0;
            this.button1Proses.Text = "Proses";
            this.button1Proses.UseVisualStyleBackColor = true;
            this.button1Proses.Click += new System.EventHandler(this.button1Proses_Click);
            // 
            // label1Empty
            // 
            this.label1Empty.AutoSize = true;
            this.label1Empty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Empty.Location = new System.Drawing.Point(30, 126);
            this.label1Empty.Name = "label1Empty";
            this.label1Empty.Size = new System.Drawing.Size(103, 25);
            this.label1Empty.TabIndex = 1;
            this.label1Empty.Text = "[ EMPTY ]";
            // 
            // textBox1Tulisan
            // 
            this.textBox1Tulisan.Location = new System.Drawing.Point(30, 48);
            this.textBox1Tulisan.Name = "textBox1Tulisan";
            this.textBox1Tulisan.Size = new System.Drawing.Size(116, 20);
            this.textBox1Tulisan.TabIndex = 2;
            // 
            // label1InputData
            // 
            this.label1InputData.AutoSize = true;
            this.label1InputData.Location = new System.Drawing.Point(30, 29);
            this.label1InputData.Name = "label1InputData";
            this.label1InputData.Size = new System.Drawing.Size(63, 13);
            this.label1InputData.TabIndex = 3;
            this.label1InputData.Text = "Input Data :";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(327, 261);
            this.Controls.Add(this.label1InputData);
            this.Controls.Add(this.textBox1Tulisan);
            this.Controls.Add(this.label1Empty);
            this.Controls.Add(this.button1Proses);
            this.Name = "Form1";
            this.Text = "Form Pengaturan Warna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProses;
        private System.Windows.Forms.Label labelEmpty;
        private System.Windows.Forms.TextBox textBoxTulisan;
        private System.Windows.Forms.Label labelInputdata;
        private System.Windows.Forms.Button button1Proses;
        private System.Windows.Forms.Label label1Empty;
        private System.Windows.Forms.TextBox textBox1Tulisan;
        private System.Windows.Forms.Label label1InputData;
    }
}

