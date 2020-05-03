using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace layout_2
{
    public partial class Form1 : Form
    {
        private bool expandir;
        public Form1()
        {
            InitializeComponent();
           
        }

       
        private void btnGrafico_Click(object sender, EventArgs e)
        {
            var tipoControle = pnlMenuCadastro.Controls.GetType();

            //Expandir(pnlMenuGrafico);

            if (expandir)
            {
                FecharAutomatico();
                expandir = false;
            }
            else
            {
                ExpandirAutomatico();
                expandir = true;
            }
            
        }

        private void ExpandirAutomatico()
        {
            foreach (var controle in pnlMenuCadastro.Controls)
            {
                if (controle.GetType().FullName.Equals("System.Windows.Forms.Button"))//Se for um Button
                {
                    var botaoAtual = (Button)controle;
                    pnlMenuGrafico.Height += botaoAtual.Height;
                }
            }
        }

        private void FecharAutomatico()
        {
            Button primeiroBotao = (Button)pnlMenuGrafico.Controls[pnlMenuGrafico.Controls.Count - 1];            

            for (int x = 0; x < pnlMenuCadastro.Controls.Count; x++)
            {
                if (pnlMenuCadastro.Controls[x].GetType().FullName.Equals("System.Windows.Forms.Button"))//Se for um Button
                {
                    var botaoAtual = (Button)pnlMenuCadastro.Controls[x];
                    pnlMenuGrafico.Height -= botaoAtual.Height;
                }
            }

            pnlMenuGrafico.Height += primeiroBotao.Height;


        }

        private void Expandir(Panel painel)
        {
            if (expandir)
            {

                painel.Height -= 160;
                if (painel.Size == painel.MinimumSize)
                {
                    
                    expandir = false;
                }
            }
            else
            {
                painel.Height += botao3.Height + button2.Height+ botao4.Height+ botao5.Height;

                if (painel.Size == painel.MaximumSize)
                {
                   
                    expandir = true;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Expandir(pnlMenuCadastro);
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            menuDropDown1.Controle();
        }
    }
}
