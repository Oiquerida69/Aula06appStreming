namespace Aula06Streming
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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_Assistir = new System.Windows.Forms.Button();
            this.lbl_Descricao = new System.Windows.Forms.Label();
            this.pic_Fundo = new System.Windows.Forms.PictureBox();
            this.Wv_video = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Fundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wv_video)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(12, 226);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(64, 27);
            this.lbl_Titulo.TabIndex = 1;
            this.lbl_Titulo.Text = "Titulo";
            // 
            // btn_Assistir
            // 
            this.btn_Assistir.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Assistir.Location = new System.Drawing.Point(12, 269);
            this.btn_Assistir.Name = "btn_Assistir";
            this.btn_Assistir.Size = new System.Drawing.Size(88, 33);
            this.btn_Assistir.TabIndex = 2;
            this.btn_Assistir.Text = "Assistir";
            this.btn_Assistir.UseVisualStyleBackColor = true;
            this.btn_Assistir.Click += new System.EventHandler(this.btn_Assistir_Click);
            // 
            // lbl_Descricao
            // 
            this.lbl_Descricao.AutoSize = true;
            this.lbl_Descricao.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descricao.Location = new System.Drawing.Point(12, 305);
            this.lbl_Descricao.MaximumSize = new System.Drawing.Size(700, 0);
            this.lbl_Descricao.Name = "lbl_Descricao";
            this.lbl_Descricao.Size = new System.Drawing.Size(74, 19);
            this.lbl_Descricao.TabIndex = 3;
            this.lbl_Descricao.Text = "Descrição";
            // 
            // pic_Fundo
            // 
            this.pic_Fundo.Location = new System.Drawing.Point(0, -1);
            this.pic_Fundo.Name = "pic_Fundo";
            this.pic_Fundo.Size = new System.Drawing.Size(801, 450);
            this.pic_Fundo.TabIndex = 0;
            this.pic_Fundo.TabStop = false;
            this.pic_Fundo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Wv_video
            // 
            this.Wv_video.AllowExternalDrop = true;
            this.Wv_video.CreationProperties = null;
            this.Wv_video.DefaultBackgroundColor = System.Drawing.Color.White;
            this.Wv_video.Location = new System.Drawing.Point(0, -1);
            this.Wv_video.Name = "Wv_video";
            this.Wv_video.Size = new System.Drawing.Size(801, 450);
            this.Wv_video.TabIndex = 4;
            this.Wv_video.Visible = false;
            this.Wv_video.ZoomFactor = 1D;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Wv_video);
            this.Controls.Add(this.lbl_Descricao);
            this.Controls.Add(this.btn_Assistir);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.pic_Fundo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Fundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wv_video)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Fundo;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_Assistir;
        private System.Windows.Forms.Label lbl_Descricao;
        private Microsoft.Web.WebView2.WinForms.WebView2 Wv_video;
    }
}