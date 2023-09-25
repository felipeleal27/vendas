namespace Games
{
    partial class Vendas
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
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdUsado = new System.Windows.Forms.RadioButton();
            this.rdNovo = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnImagem = new System.Windows.Forms.Button();
            this.lblImagem = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkquebrado = new System.Windows.Forms.CheckBox();
            this.chkFinanceiro = new System.Windows.Forms.CheckBox();
            this.chkNgostei = new System.Windows.Forms.CheckBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.dateP1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(76, 68);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(133, 22);
            this.txtItem.TabIndex = 0;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(22, 68);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(41, 20);
            this.lblItem.TabIndex = 13;
            this.lblItem.Text = "Item";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdUsado);
            this.groupBox1.Controls.Add(this.rdNovo);
            this.groupBox1.Location = new System.Drawing.Point(338, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 127);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Situação";
            // 
            // rdUsado
            // 
            this.rdUsado.AutoSize = true;
            this.rdUsado.Location = new System.Drawing.Point(32, 77);
            this.rdUsado.Name = "rdUsado";
            this.rdUsado.Size = new System.Drawing.Size(69, 20);
            this.rdUsado.TabIndex = 1;
            this.rdUsado.TabStop = true;
            this.rdUsado.Text = "Usado";
            this.rdUsado.UseVisualStyleBackColor = true;
            // 
            // rdNovo
            // 
            this.rdNovo.AutoSize = true;
            this.rdNovo.Location = new System.Drawing.Point(32, 40);
            this.rdNovo.Name = "rdNovo";
            this.rdNovo.Size = new System.Drawing.Size(61, 20);
            this.rdNovo.TabIndex = 0;
            this.rdNovo.TabStop = true;
            this.rdNovo.Text = "Novo";
            this.rdNovo.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(555, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(896, 630);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(93, 40);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(38, 25);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "<";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnImagem
            // 
            this.btnImagem.Location = new System.Drawing.Point(730, 59);
            this.btnImagem.Name = "btnImagem";
            this.btnImagem.Size = new System.Drawing.Size(88, 36);
            this.btnImagem.TabIndex = 9;
            this.btnImagem.Text = "Adicionar";
            this.btnImagem.UseVisualStyleBackColor = true;
            this.btnImagem.Click += new System.EventHandler(this.btnImagem_Click);
            // 
            // lblImagem
            // 
            this.lblImagem.AutoSize = true;
            this.lblImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagem.Location = new System.Drawing.Point(644, 34);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(263, 20);
            this.lblImagem.TabIndex = 10;
            this.lblImagem.Text = "Adicione uma imagem do produto:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(502, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(55, 16);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "17:30:45";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkquebrado);
            this.groupBox2.Controls.Add(this.chkFinanceiro);
            this.groupBox2.Controls.Add(this.chkNgostei);
            this.groupBox2.Location = new System.Drawing.Point(63, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 184);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Motivo de venda";
            // 
            // chkquebrado
            // 
            this.chkquebrado.AutoSize = true;
            this.chkquebrado.Location = new System.Drawing.Point(30, 137);
            this.chkquebrado.Name = "chkquebrado";
            this.chkquebrado.Size = new System.Drawing.Size(129, 20);
            this.chkquebrado.TabIndex = 2;
            this.chkquebrado.Text = "Está com defeito";
            this.chkquebrado.UseVisualStyleBackColor = true;
            // 
            // chkFinanceiro
            // 
            this.chkFinanceiro.AutoSize = true;
            this.chkFinanceiro.Location = new System.Drawing.Point(30, 86);
            this.chkFinanceiro.Name = "chkFinanceiro";
            this.chkFinanceiro.Size = new System.Drawing.Size(160, 20);
            this.chkFinanceiro.TabIndex = 1;
            this.chkFinanceiro.Text = "Questões Financeiras";
            this.chkFinanceiro.UseVisualStyleBackColor = true;
            // 
            // chkNgostei
            // 
            this.chkNgostei.AutoSize = true;
            this.chkNgostei.Location = new System.Drawing.Point(30, 38);
            this.chkNgostei.Name = "chkNgostei";
            this.chkNgostei.Size = new System.Drawing.Size(163, 20);
            this.chkNgostei.TabIndex = 0;
            this.chkNgostei.Text = "Não gostei do produto";
            this.chkNgostei.UseVisualStyleBackColor = true;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(501, 405);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(48, 20);
            this.lblValor.TabIndex = 16;
            this.lblValor.Text = "Valor";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(555, 405);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 22);
            this.textBox2.TabIndex = 15;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(72, 385);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(205, 20);
            this.lblData.TabIndex = 12;
            this.lblData.Text = "Selecione a data da venda";
            // 
            // dateP1
            // 
            this.dateP1.Location = new System.Drawing.Point(44, 408);
            this.dateP1.Name = "dateP1";
            this.dateP1.Size = new System.Drawing.Size(286, 22);
            this.dateP1.TabIndex = 17;
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 682);
            this.Controls.Add(this.dateP1);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblImagem);
            this.Controls.Add(this.btnImagem);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.txtItem);
            this.Name = "Vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdUsado;
        private System.Windows.Forms.RadioButton rdNovo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnImagem;
        private System.Windows.Forms.Label lblImagem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkquebrado;
        private System.Windows.Forms.CheckBox chkFinanceiro;
        private System.Windows.Forms.CheckBox chkNgostei;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dateP1;
    }
}