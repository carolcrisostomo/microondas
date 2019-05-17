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
        private readonly Microondas microondas;
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
 
            try
            {
                saidaTextBox.Text += Environment.NewLine + microondas.Aquecer(entrada)+"\n";
            }
            catch (Exception ex) {
                saidaTextBox.Text += Environment.NewLine + ex.Message ; 
            }


        }
    }
}
