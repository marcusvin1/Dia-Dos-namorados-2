namespace Dia_Dos_namorados_2._0
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDeclaracao = new System.Windows.Forms.Button();
            this.btnVideo = new System.Windows.Forms.Button();
            this.Bins = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnDeclaracao
            // 
            this.btnDeclaracao.BackgroundImage = global::Dia_Dos_namorados_2._0.Properties.Resources.Mensagens_do_Dia_dos_Namorados;
            this.btnDeclaracao.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeclaracao.ForeColor = System.Drawing.Color.Cyan;
            this.btnDeclaracao.Location = new System.Drawing.Point(555, 105);
            this.btnDeclaracao.Name = "btnDeclaracao";
            this.btnDeclaracao.Size = new System.Drawing.Size(233, 53);
            this.btnDeclaracao.TabIndex = 0;
            this.btnDeclaracao.Text = "Declaração";
            this.btnDeclaracao.UseVisualStyleBackColor = true;
            this.btnDeclaracao.Click += new System.EventHandler(this.btnDeclaracao_Click);
            // 
            // btnVideo
            // 
            this.btnVideo.BackgroundImage = global::Dia_Dos_namorados_2._0.Properties.Resources.Mensagens_do_Dia_dos_Namorados;
            this.btnVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVideo.Font = new System.Drawing.Font("Ravie", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideo.ForeColor = System.Drawing.Color.Cyan;
            this.btnVideo.Location = new System.Drawing.Point(555, 179);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(233, 45);
            this.btnVideo.TabIndex = 1;
            this.btnVideo.Text = "Vídeo Fofo";
            this.btnVideo.UseVisualStyleBackColor = true;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click_1);
            // 
            // Bins
            // 
            this.Bins.BackgroundImage = global::Dia_Dos_namorados_2._0.Properties.Resources.pngtree_modern_double_color_futuristic_neon_background_image_351866;
            this.Bins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bins.Font = new System.Drawing.Font("Ravie", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bins.ForeColor = System.Drawing.Color.FloralWhite;
            this.Bins.Location = new System.Drawing.Point(254, 351);
            this.Bins.Name = "Bins";
            this.Bins.Size = new System.Drawing.Size(295, 60);
            this.Bins.TabIndex = 2;
            this.Bins.Text = "Mostrar Algo Lindo";
            this.Bins.UseVisualStyleBackColor = true;
            this.Bins.Click += new System.EventHandler(this.Bins_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Dia_Dos_namorados_2._0.Properties.Resources.Captura_de_tela_2024_06_12_224453;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 123);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Dia_Dos_namorados_2._0.Properties.Resources.Captura_de_tela_2024_06_12_224639;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(254, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(116, 104);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Dia_Dos_namorados_2._0.Properties.Resources.Captura_de_tela_2024_06_12_224805;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(204, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(119, 108);
            this.panel3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dia_Dos_namorados_2._0.Properties.Resources.Imagem_do_WhatsApp_de_2024_06_12_à_s__16_30_59_8d7b5bd2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Bins);
            this.Controls.Add(this.btnVideo);
            this.Controls.Add(this.btnDeclaracao);
            this.Name = "Form1";
            this.Text = "Presente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeclaracao;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.Button Bins;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

