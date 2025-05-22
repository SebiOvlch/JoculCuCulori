namespace JoculCuCulori
{
    partial class Form2
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
            this.numUD_Rows = new System.Windows.Forms.NumericUpDown();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numUD_Cols = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Cols)).BeginInit();
            this.SuspendLayout();
            // 
            // numUD_Rows
            // 
            this.numUD_Rows.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numUD_Rows.Location = new System.Drawing.Point(149, 11);
            this.numUD_Rows.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUD_Rows.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUD_Rows.Name = "numUD_Rows";
            this.numUD_Rows.Size = new System.Drawing.Size(65, 35);
            this.numUD_Rows.TabIndex = 0;
            this.numUD_Rows.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUD_Rows.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btn_Accept
            // 
            this.btn_Accept.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Accept.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Accept.Location = new System.Drawing.Point(303, 273);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(145, 45);
            this.btn_Accept.TabIndex = 1;
            this.btn_Accept.Text = "Accept";
            this.btn_Accept.UseVisualStyleBackColor = false;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rows: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(256, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Columns:";
            // 
            // numUD_Cols
            // 
            this.numUD_Cols.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numUD_Cols.Location = new System.Drawing.Point(432, 15);
            this.numUD_Cols.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUD_Cols.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUD_Cols.Name = "numUD_Cols";
            this.numUD_Cols.Size = new System.Drawing.Size(65, 35);
            this.numUD_Cols.TabIndex = 0;
            this.numUD_Cols.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUD_Cols.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(751, 469);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.numUD_Cols);
            this.Controls.Add(this.numUD_Rows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Cols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUD_Rows;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUD_Cols;
    }
}