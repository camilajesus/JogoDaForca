using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogodaforca
{
    public partial class Form1 : Form
    {
        private String[] palavras;
        private String[] dicas;
        private String palavra;
        private String tela;
        private int tentativas;
        private int pospalavra;


        public Form1()
        {
            InitializeComponent();
            this.IniciaVetor();
        }

        private void IniciaVetor()
        {
            palavras = new String[10];
            dicas = new String[10];

            palavras[0] = "banana";
            dicas[0] = "Fruta Tropical";

            palavras[1] = "leão";
            dicas[1] = "Animal Selvagem";

            palavras[2] = "homem Aranha";
            dicas[2] = "Super heroi";

            palavras[3] = "deadPool";
            dicas[3] = "Super heroi";

            palavras[4] = "computador";
            dicas[4] = "Equipamento eletronico";

            palavras[5] = "fanta";
            dicas[5] = "Refrigerante";

            palavras[6] = "são Paulo";
            dicas[6] = "Cidade e Estado";

            palavras[7] = "instagram";
            dicas[7] = "Aplicativo de Foto";

            palavras[8] = "facebook";
            dicas[8] = "Rede Social";

            palavras[9] = "gato";
            dicas[9] = "Animal domestico";

        }

        private void IniciaJogo()
        {
            // escolher a palavra
            Random r = new Random();
            pospalavra = r.Next(0, 9);
            //selecioneei a palavra
            palavra = palavras[pospalavra];
            //inserir texto em tela
            tela = "";
            for (int i = 0; i < palavra.Length; i++)
            {
                tela = tela + "#";

            }
            txtbpalavra.Text = tela;
            lbdica.Text = dicas[pospalavra];
            // total de tentativas
            tentativas = 5;
            lbtotaltentativas.Text = tentativas.ToString();
            lbtrestantes.Text = tentativas.ToString();



        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pnjogo.Visible = true;
            btnStart.Visible = false;
            //selecionar a palavra para identificar
            this.IniciaJogo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btOk_Click(object sender, EventArgs e)
        {
           // if (tentativas > 0)
            //{
                Boolean encontrou = false;
                //int pletra = 0;
                Char letra = Convert.ToChar(txtbletra.Text);
                String txt = "";
                for (int i = 0; i < palavra.Length; i++)
                {
                    if (palavra[i] == letra)
                    {
                        encontrou = true;
                        pletra = i;
                        // atualizar o texto na tela
                        txt = txt + txtbletra.Text;
                    }
                    else
                    {
                        txt = txt + tela[i];
                    }

                }
                tela = txt;
                txtbpalavra.Text = tela;
                txtbletra.Clear();
                txtbpalavra.Clear();
                tentativas--;
            if(tentativas <= 0)
            {
                pnjogo.Visible = true;

                
            }

            }
       // }

        private void txtbletra_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
