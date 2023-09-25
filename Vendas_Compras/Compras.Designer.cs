namespace Games
{
    partial class Compras
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
            this.cbmPesquisa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pctCompra = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // cbmPesquisa
            // 
            this.cbmPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmPesquisa.FormattingEnabled = true;
            this.cbmPesquisa.Location = new System.Drawing.Point(87, 23);
            this.cbmPesquisa.Name = "cbmPesquisa";
            this.cbmPesquisa.Size = new System.Drawing.Size(121, 24);
            this.cbmPesquisa.TabIndex = 0;
            this.cbmPesquisa.SelectedIndexChanged += new System.EventHandler(this.cbmPesquisa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisa";
            // 
            // pctCompra
            // 
            this.pctCompra.Location = new System.Drawing.Point(15, 63);
            this.pctCompra.Name = "pctCompra";
            this.pctCompra.Size = new System.Drawing.Size(278, 266);
            this.pctCompra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCompra.TabIndex = 3;
            this.pctCompra.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "COMPRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pctCompra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbmPesquisa);
            this.Name = "Compras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this.pctCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}