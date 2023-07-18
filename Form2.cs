using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula06Streming
{
    public partial class Form2 : Form
    {
        public string titulo;
        public string descricao;
        public string CaminhoImagem;
        public string Link_video;
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            
            Form1 Maintela = new Form1();
            
            
            lbl_Titulo.Text = $"{titulo}";
            lbl_Descricao.Text = $"{descricao}";
            pic_Fundo.ImageLocation = CaminhoImagem;
            Wv_video.Source = new Uri(Link_video);

        }

        private void btn_Assistir_Click(object sender, EventArgs e)
        {
            Wv_video.Show();
        }
    }
}
