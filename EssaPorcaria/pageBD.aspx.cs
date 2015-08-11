using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace EssaPorcaria
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             SqlConnection conexao = new SqlConnection(""
                 +"DaTa Source=(LocalDb\\v11.0;AttachDbFilename="
                 +"D:\\Github\\EssaPorcaria\\EssaPorcaria\\BD\\northwind.mdf;Integrated Security=True");
            /*   
               SqlConnection conexao = new SqlConnection(""
                   +"server=MARCELL\\MARCELL;"
                   +"Database=northwind;"
                   +"Integrated Security=true");

            */
               //Criando o comando sql para executar no banco informado na conexão
               SqlCommand comandoSql = new SqlCommand("SELECT * FROM CADASTROS", conexao);

               //Criando o SqlDataAdapter para executar a query e preencher o dataset
               SqlDataAdapter adaptador = new SqlDataAdapter(comandoSql);

               //Criando o dataset e preenchendo o mesmo com o resultado da execução da query
               DataSet ds = new DataSet();
               adaptador.Fill(ds);
               //Criando o dataview e associando a origem dos dados
               DataView source = new DataView();
               source.Table = ds.Tables[0];

               //Criando a conexão entre o conjunto de dados (dataset) e o componente visual (datagrid)
               CadastrosDataGrid.DataSource = source;

               //Montando e exibindo as informações no grid
               CadastrosDataGrid.DataBind();
               
        }
    }
}