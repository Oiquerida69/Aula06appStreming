using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula06Streming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string titulo = "Kill Bill";
            string descricao = "A ex-assassina conhecida apenas como Noiva acorda de um coma de quatro anos decidida a se vingar de Bill, seu ex-amante e chefe, que tentou matá-la no dia do casamento. Ela está motivada a acertar as contas com cada uma das pessoas envolvidas com a perda da filha, da festa de casamento e dos quatro anos de sua vida. Na jornada, a Noiva é submetida a dores físicas agonizantes ao enfrentar a inescrupulosa gangue de Bill, o Esquadrão Assassino de Víboras Mortais.";

            Form2 tela_descricao = new Form2();
            tela_descricao.titulo = titulo;
            tela_descricao.descricao = descricao;
            tela_descricao.Show();

            


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string titulo = "arraste-me para o inferno";
            string descricao = "A vida de uma bancária começa a mudar quando, para impressionar seu chefe, ela nega o pedido de prorrogação do prazo de pagamento das prestações da casa de uma idosa.";

            Form2 tela_descricao = new Form2();
            tela_descricao.titulo = titulo;
            tela_descricao.descricao = descricao;
            tela_descricao.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string titulo = "a vingança das damas de honra";
            string descricao = "Abigail e Parker se infiltram como damas de honra em um casamento para tentar destruir a reputação da noiva que vai se casar com o ex-namorado de Rachel, que também será dama de honra.";

            Form2 tela_descricao = new Form2();
            tela_descricao.titulo = titulo;
            tela_descricao.descricao = descricao;
            tela_descricao.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string titulo = "Heartstoppers";
            string descricao = "Charlie Spring e Nick Nelson. Charlie, gay assumido, sofre com o bullying na escola. Nick, por sua vez, é bastante popular, especialmente por ser um excelente jogador de rugby";

            Form2 tela_descricao = new Form2();
            tela_descricao.titulo = titulo;
            tela_descricao.descricao = descricao;
            tela_descricao.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string titulo = "A tia é Top";
            string descricao = "A Tia é Top é uma animação original da Netflix e acompanha a festeira Diane, uma mulher recém-separada que se recusa a crescer, e seu sobrinho introvertido Daniel enquanto os dois adentram juntos a vida adulta. Ele desiste de ir para faculdade e sua mãe, então, decide que ele deve ir morar com a tia. Embora com personalidades opostas, Diane e Daniel acabam se ajudando a lidar com os problemas do dia-a-dia enquanto aprendem a equilibrar suas responsabilidades";

            Form2 tela_descricao = new Form2();
            tela_descricao.titulo = titulo;
            tela_descricao.descricao = descricao;
            tela_descricao.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string titulo = "Sex Education";
            string descricao = "O inseguro Otis (Asa Butterfield) tem resposta para todas as questões sobre sexo, graças à sua mãe que é terapeuta sexual, apesar de ainda não ter perdido a virgindade. Por isso, juntamente com Maeve (Emma Mackey), uma colega de turma rebelde, ele resolve montar a sua própria clínica de saúde sexual na escola para ajudar os outros estudantes";

            Form2 tela_descricao = new Form2();
            tela_descricao.titulo = titulo;
            tela_descricao.descricao = descricao;
            tela_descricao.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            string titulo = "O Gambito da Rainha";
            string descricao = "Em um orfanato nos anos 1950, uma garota-prodígio do xadrez luta contra o vício em uma jornada improvável para se tornar a número 1 do mundo.";

            Form2 tela_descricao = new Form2();
            tela_descricao.titulo = titulo;
            tela_descricao.descricao = descricao;
            tela_descricao.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string titulo = "Big Mouth";
            string descricao = "Uma dupla de adolescentes vê suas vidas colocadas de pernas para o ar pelas maravilhas e horrores da puberdade, nesta comédia dos amigos Nick Kroll e Andrew Goldberg";

            Form2 tela_descricao = new Form2();
            tela_descricao.titulo = titulo;
            tela_descricao.descricao = descricao;
            tela_descricao.Show();
        }
    }
}
