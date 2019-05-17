using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MICROONDASDIGITAL
{
    public partial class Form1 : Form
    {
        private Microondas microondas;
        public Form1()
        {
            InitializeComponent();

            Validador validador = new Validador();
            Leitor leitor = new Leitor(validador);
            GerandorTextoAquecimento gerador = new GerandorTextoAquecimento();

            microondas = new Microondas(leitor, gerador);
        }

        private void AquecerButton_Click(object sender, EventArgs e)
        {
            string entrada = entradaTextBox.Text;

            //saidaTextBox.Text = entrada;
   
            try
            {
                saidaTextBox.Text = microondas.aquecer(entrada);
            }
            catch (Exception ex) {
                saidaTextBox.Text = ex.Message;
            }


           // ModelDados md = new ModelDados();
           // Leitor leitor = new Leitor(new Validador());
           // Dados dados = leitor.Ler(entrada);
           // md.Value.tempo = md.AsTempo(Convert.ToString(dados.tempo));
           // md.Value.potencia = md.AsPotencia(Convert.ToString(dados.potencia));
           //// md.Value.entrada = md.IsTyped(entrada);
           // if (md.Validate())
           // {
           //     string aquecido = new String('.', dados.tempo * dados.potencia);
           //     saidaTextBox.Text = saidaTextBox.Text + Environment.NewLine + aquecido;
           //     saidaTextBox.Text = saidaTextBox.Text + Environment.NewLine + "aquecida";
           // }
           // else
           //     {
           //         saidaTextBox.Text = saidaTextBox.Text + Environment.NewLine + "Erros ocorreram!";
           //         foreach (var erro in md.Errors)
           //         { //tem várias formas para mostrar os erros
           //             saidaTextBox.Text = saidaTextBox.Text + Environment.NewLine + erro.Value;
           //         }
           //     }
        }
    }
}
