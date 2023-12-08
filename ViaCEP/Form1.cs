using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace ViaCEP
{
    public partial class Form1 : Form
    {

        //Global
        Endereco endereco = new Endereco();
        int Idselecionado = 0;


        public Form1()
        {
            InitializeComponent();

            dgvCep.DataSource = endereco.ListarTudo();
           

            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cep = txbCEP.Text;
            string link = "https://viacep.com.br/ws/" + cep + "/json/";

            WebClient wc = new WebClient();

            string r = wc.DownloadString(link);
            r= Encoding.UTF8.GetString(Encoding.Default.GetBytes(r));
            endereco = JsonConvert.DeserializeObject<Endereco>(r);


            
            lblLogradouro.Text = endereco.Logradouro;
            lblComplemento.Text = endereco.Complemento;
            lblBairro.Text = endereco.Bairro;
            lblLocalidade.Text = endereco.Localidade;
            lblUF.Text = endereco.Uf;
            lblDDD.Text = endereco.Ddd;


                
            

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           

           endereco.FavoritarCep();
           dgvCep.DataSource = endereco.ListarTudo();
        }

        private void btnApagarTudo_Click(object sender, EventArgs e)
        {
            endereco.DeletarTudo();
            dgvCep.DataSource = endereco.ListarTudo();
        }

        private void dgvCep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Obter a linha:
            int linhaselecionada = dgvCep.CurrentCell.RowIndex;
            
            
            //Armazenar os dados da linha selecionada:
            var linha = dgvCep.Rows[linhaselecionada];
                    

            Idselecionado = int.Parse(linha.Cells[0].Value.ToString());

           
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Endereco endereco = new Endereco();
            endereco.Id = Idselecionado;           
            endereco.DeletarSelecionado();
            
            //Atualizar Tabela:
            dgvCep.DataSource = endereco.ListarTudo();
        }
    }
}
