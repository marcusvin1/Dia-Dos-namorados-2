using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dia_Dos_namorados_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDeclaracao_Click(object sender, EventArgs e)
        {
            ExibirDeclaracaoAleatoria();
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            AcessarVideoFofo();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExibirDeclaracaoAleatoria()
        {
            string[] declaracoes = new string[]
            {
               "Você é a luz dos meus dias e a razão do meu sorriso.",
                "Cada momento ao seu lado é especial e inesquecível.",
                "Te amo mais do que palavras podem expressar.",
                "Você completa minha vida de uma maneira que eu nunca imaginei ser possível.",
                "Ser seu namorado(a) é o maior presente que eu poderia ter.",
                "Meu amor por você é infinito e cresce a cada dia.",
                "Seu sorriso ilumina até os meus dias mais sombrios.",
                "Você é meu sonho realizado e minha realidade mais feliz.",
                "Amo cada detalhe sobre você e cada momento ao seu lado.",
                "Estar com você é a melhor parte do meu dia.",
                "Você é a razão pela qual eu acredito no amor verdadeiro.",
                "Nosso amor é como um conto de fadas que eu nunca quero que termine.",
                "Meu coração pertence a você, agora e para sempre.",
                "Você é minha melhor amiga, meu amor e meu tudo.",
                "Cada dia ao seu lado é uma bênção que eu agradeço."
            };

            Random rand = new Random();
            int indice = rand.Next(declaracoes.Length);

            MessageBox.Show(declaracoes[indice], "Declaração");
        }

        private void AcessarVideoFofo()
        {
            string url = "https://www.youtube.com/watch?v=9zI2hdrHjZg";
            System.Diagnostics.Process.Start(url);
        }

        private void Bins_Click(object sender, EventArgs e)
        {
            string url = "https://www.instagram.com/cyntiagrazieli_/";
            System.Diagnostics.Process.Start(url);
        }

        private void btnVideo_Click_1(object sender, EventArgs e)
        {
            string url = "https://www.youtube.com/watch?v=9zI2hdrHjZg";
            System.Diagnostics.Process.Start(url);
        }
    }
}

