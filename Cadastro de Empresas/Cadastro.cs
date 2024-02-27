using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Empresas
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();
            empresa.Cnpj = txt_cnpj.Text;
            empresa.RazaoSocial = txt_razaosocial.Text;
            empresa.NomeFantasia = txt_nomefantasia.Text;
            empresa.SituacaoCad = cb_sitacaocadastral.Text;
            empresa.RegimeTribu = "";
            if (rb_simples.Checked)
            {
                empresa.RegimeTribu = "Simples Nacional";
            }
            else if (rb_lucro.Checked)
            {
                empresa.RegimeTribu = "Lucro Presumido";
            }
            else if (rb_lucroreal.Checked)
            {
                empresa.RegimeTribu = "Lucro Real";
            }
            empresa.DataInicio = Convert.ToDateTime(dt_inicio.Text);
            empresa.Telefone = mask_telefone.Text;
            empresa.CapitalSocial = Convert.ToInt32(txt_capitalsocial.Text);
            empresa.Endereco = cb_estado.Text;
            empresa.Tipo = "";                                   
            if(rb_filial.Checked)
            {
                empresa.Tipo = "Filial";
            }
            else if(rb_matriz.Checked)
            {
                empresa.Tipo = "Matriz";
            }
            empresa.PorteEmpre = "";
            if (rb_pequeno.Checked)
            {
                empresa.PorteEmpre = "Pequeno";
            }
            else if (rb_lucro.Checked)
            {
                empresa.PorteEmpre = "Médio";
            }
            else if (rb_lucroreal.Checked)
            {
                empresa.PorteEmpre = "Grande";
            }
            empresa.NaturezaJuri = cb_natureza.Text;
            empresa.NomePropri = txt_nomefantasia.Text;
            empresa.CPFpropri = txt_cpf.Text;


            MessageBox.Show($"Cnpj = {empresa.Cnpj}\n" +
                $"Razao Social = {empresa.RazaoSocial}\n" +
                $"Nome Fantasia = {empresa.NomeFantasia}\n" +
                $"Situação Cadastral = {empresa.SituacaoCad}\n" +
                $"Regime Tributário = {empresa.RegimeTribu}\n" +
                $"Data Inicio = {empresa.DataInicio}\n" +
                $"Telefone = {empresa.Telefone}\n" +
                $"Capital Social = {empresa.CapitalSocial}\n" +
                $"Endereço = {empresa.Endereco}\n" +
                $"Tipo = {empresa.Tipo} " +
                $"Porte Empresa = {empresa.PorteEmpre}\n" +
                $"Natureza Juridíca = {empresa.NaturezaJuri}\n " +
                $"Nome Proprietário = {empresa.NomePropri}\n" +
                $"CPF Proprietário = {empresa.CPFpropri} ");

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void rb_simples_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
