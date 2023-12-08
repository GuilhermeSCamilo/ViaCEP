using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViaCEP
{
    internal class Endereco
    {       
            public int Id { get; set; }
            public string Cep { get; set; }
            public string Logradouro { get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
            public string Localidade { get; set; }
            public string Uf { get; set; }
            public string Ddd { get; set; }

        public DataTable ListarTudo()
        {

            // Definir o objeto de "tabela" que será preenchido com a consulta:
            DataTable tabela = new DataTable();
            // Instanciar e conectar ao banco:
            ConexaoBD1 banco = new ConexaoBD1();
            banco.Conectar();
            // Criar o objeto SQLiteCommand:
            var cmd = banco.conexao.CreateCommand();
            // Definir qual comando DQL será executado:
            cmd.CommandText = "SELECT * FROM enderecos";
            // Executar e "atribuir" o resultado em um objeto SQLiteDA
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, banco.conexao);
            // Definir qual "tabela" será preenchida com o resultado da consulta:
            da.Fill(tabela);
            // Desconectar:
            banco.Desconectar();
            return tabela;
          


        }

        public DataTable FavoritarCep()
        {





            // Definir o objeto de "tabela" que será preenchido com a consulta:
            DataTable tabela = new DataTable();
            // Instanciar e conectar ao banco:
            ConexaoBD1 banco = new ConexaoBD1();
            banco.Conectar();
            // Criar o objeto SQLiteCommand:
            var cmd = banco.conexao.CreateCommand();

            cmd.CommandText = "INSERT INTO enderecos (cep, logradouro,bairro, ddd, localidade, complemento, uf)" +
                              "VALUES (@cep, @logradouro, @bairro, @ddd, @localidade, @complemento, @uf)";
            
            
            cmd.Parameters.AddWithValue("@cep", Cep);
            cmd.Parameters.AddWithValue("@logradouro", Logradouro);
            cmd.Parameters.AddWithValue("@bairro", Bairro);
            cmd.Parameters.AddWithValue("@ddd", Ddd);
            cmd.Parameters.AddWithValue("@localidade", Localidade);
            cmd.Parameters.AddWithValue("@complemento", Complemento);
            cmd.Parameters.AddWithValue("@uf", Uf);

            // Executar:
            cmd.ExecuteNonQuery();
            // Desconectar
            banco.Desconectar();

            return tabela;
        }

            public DataTable DeletarTudo()

            {


            // Definir o objeto de "tabela" que será preenchido com a consulta:
            DataTable tabela = new DataTable();
            // Instanciar e conectar ao banco:
            ConexaoBD1 banco = new ConexaoBD1();
            banco.Conectar();
            // Criar o objeto SQLiteCommand:
            var cmd = banco.conexao.CreateCommand();

            cmd.CommandText = "DELETE FROM enderecos";


            // Executar:
            cmd.ExecuteNonQuery();
            // Desconectar
            banco.Desconectar();

            return tabela;



            }



        public DataTable DeletarSelecionado()

        {


            // Definir o objeto de "tabela" que será preenchido com a consulta:
            DataTable tabela = new DataTable();
            // Instanciar e conectar ao banco:
            ConexaoBD1 banco = new ConexaoBD1();
            banco.Conectar();
            // Criar o objeto SQLiteCommand:
            var cmd = banco.conexao.CreateCommand();

            cmd.CommandText = "DELETE FROM enderecos WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", Id);


            // Executar:
            cmd.ExecuteNonQuery();
            // Desconectar
            banco.Desconectar();

            return tabela;



        }







    }

    }
    


