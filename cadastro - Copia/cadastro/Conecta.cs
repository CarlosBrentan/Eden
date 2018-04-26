// esse é o scrip que faz a conecção com o banco de dados 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;                   //
using System.Data.SqlClient;        //   Essas são as bibliotecas utilizadas para conexão
using System.Data;                  //




namespace cadastro.classe
{

    public class Conecta
    {

        //definindo o banco de dados que vamos conectar
        //linha de comando retirada do site do professor Carlos Rafael, com modificações
        //                                                          ( nome do servidor )              (nome do banco de dados)          (Nome do usuario)          (Senha de acesso)
        //                                                         ||          ||      ||                   ||      ||                     ||      ||                ||      ||
        //                                                         \/          \/      \/                   \/      \/                     \/      \/                \/      \/
        static string ConnectionString = "Server=tcp:         cadastrotest.database.windows.net;      Database=testeCadastro;          User ID = Luizca95;       Password=Senha123";  // Eu sei que o Carlos vai tentar usar essa senha em algum lugar então já aviso que utilizei ela exclusivamente para esse exemplo


        SqlConnection con = new SqlConnection(ConnectionString);  //criando conexão sql com a string que foi definida a cima onde contem os dados do banco 
                                                                  // o nome da conexão foi definida como "con"                  
        public String ExecutaComando (String comandoSql)
        {

            // pesquisar sobre "try, catch e finally"


            try
            {
                con.Open(); // abrindo conexão
                

                SqlCommand cmd = new SqlCommand(comandoSql, con);
                cmd.ExecuteNonQuery();   // Executa um comando que não traz uma relação de linhas e colunas. Seu retorno é, na verdade, a quantidade de linhas afetadas pelo comando.
                                         // É usado para sentenças como INSERT, UPDATE, DELETE, etc.
                                         // 
                                         //definição do comando ExecuteNonQuery retirado da internet:
                                         //https://pt.stackoverflow.com/questions/94315/m%C3%A9todos-executereader-executenonquery-e-executescalar-quais-s%C3%A3o-as-difer.
                return "ok";
            }
            catch(Exception erro)
            {
                return erro.Message;
            }


            finally
            {
                con.Close(); // utilizado para fechar a conexão com o banco de dados 
            }
        }




        
    }
}