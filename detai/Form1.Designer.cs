namespace detai
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
            this.TXTHOTEN = new System.Windows.Forms.TextBox();
            this.TXTMAGV = new System.Windows.Forms.TextBox();
            this.BTTHEM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXTHOTEN
            // 
            this.TXTHOTEN.Location = new System.Drawing.Point(386, 66);
            this.TXTHOTEN.Name = "TXTHOTEN";
            this.TXTHOTEN.Size = new System.Drawing.Size(372, 22);
            this.TXTHOTEN.TabIndex = 0;
            this.TXTHOTEN.TextChanged += new System.EventHandler(this.TXTHOTEN_TextChanged);
            // 
            // TXTMAGV
            // 
            this.TXTMAGV.Location = new System.Drawing.Point(386, 94);
            this.TXTMAGV.Name = "TXTMAGV";
            this.TXTMAGV.Size = new System.Drawing.Size(372, 22);
            this.TXTMAGV.TabIndex = 0;
            this.TXTMAGV.TextChanged += new System.EventHandler(this.TXTHOTEN_TextChanged);
            // 
            // BTTHEM
            // 
            this.BTTHEM.Location = new System.Drawing.Point(401, 232);
            this.BTTHEM.Name = "BTTHEM";
            this.BTTHEM.Size = new System.Drawing.Size(164, 57);
            this.BTTHEM.TabIndex = 1;
            this.BTTHEM.Text = "Thêm Giáo Viên";
            this.BTTHEM.UseVisualStyleBackColor = true;
            this.BTTHEM.Click += new System.EventHandler(this.BTTHEM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTTHEM);
            this.Controls.Add(this.TXTMAGV);
            this.Controls.Add(this.TXTHOTEN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTHOTEN;
        private System.Windows.Forms.TextBox TXTMAGV;
        private System.Windows.Forms.Button BTTHEM;
    }
}

