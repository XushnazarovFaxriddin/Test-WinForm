
namespace BuxDU_Test
{
    partial class Registr
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
            this.label1 = new System.Windows.Forms.Label();
            this.Fakultet = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(669, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iltimos qayerda o\'qishingiz va kimligingizni kiriting!";
            // 
            // Fakultet
            // 
            this.Fakultet.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Fakultet.CausesValidation = false;
            this.Fakultet.Enabled = false;
            this.Fakultet.FormattingEnabled = true;
            this.Fakultet.Items.AddRange(new object[] {
            "Axborot texnologiyalari",
            "Fizika Matematika",
            "Harbiy talim",
            "Xorijiy tillar"});
            this.Fakultet.Location = new System.Drawing.Point(43, 78);
            this.Fakultet.Name = "Fakultet";
            this.Fakultet.Size = new System.Drawing.Size(340, 28);
            this.Fakultet.Sorted = true;
            this.Fakultet.TabIndex = 1;
            this.Fakultet.Text = "Fakultetni tanlang";
            this.Fakultet.SelectedIndexChanged += new System.EventHandler(this.Fakultet_SelectedIndexChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(43, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(340, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Yo\'nalishni tanlag";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Registr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1116, 732);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Fakultet);
            this.Controls.Add(this.label1);
            this.Name = "Registr";
            this.Text = "Ro\'yhatdan o\'tish";
            this.Load += new System.EventHandler(this.Registr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Fakultet;
        private System.Windows.Forms.Timer timer1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}