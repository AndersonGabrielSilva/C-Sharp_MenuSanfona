using System.Windows.Forms;

namespace layout_2
{
    class MenuSanfona : System.Windows.Forms.Panel
    {
        private MenuSanfona2 menuSanfona21;
        private System.ComponentModel.IContainer components;

        protected void Expandir()
        {        
           foreach (var controle in this.Controls)
           {
              if (controle.GetType().FullName.Equals("System.Windows.Forms.Button"))//Se for um Button
              {
                        var botaoAtual = (Button)controle;
                        this.Height += botaoAtual.Height;
              }
           }
        }

        protected void Fechar()
        {
            Button primeiroBotao = (Button)this.Controls[this.Controls.Count - 1];

            for (int x = 0; x < this.Controls.Count; x++)
            {
                if (this.Controls[x].GetType().FullName.Equals("System.Windows.Forms.Button"))//Se for um Button
                {
                    var botaoAtual = (Button)this.Controls[x];
                    this.Height -= botaoAtual.Height;
                }
            }

            this.Height += primeiroBotao.Height;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuSanfona21 = new layout_2.MenuSanfona2(this.components);
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
