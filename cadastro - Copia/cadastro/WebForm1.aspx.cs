using cadastro.classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cadastro
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnEnviar_click(object sender, EventArgs e)   // void criada para defifinir funções ao botão Enviar
        {
            string nome = txtNome.Text;
            Conecta con = new Conecta();

            String cmd = @"INSERT INTO TB_CADASTRO(NOME) values ('" + nome + "' )";

            string resultado = con.ExecutaComando(cmd);
            saida.Text = "Bem Vindo, " + txtNome.Text; // referente a linha 29 do arquivo .aspx 
        }
    }
}