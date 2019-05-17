using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MICROONDASDIGITAL
{
    public class Microondas
    {
        private readonly Leitor leitor;
        private readonly GerandorTextoAquecimento gerandorTextoAquecimento;

        public Microondas( Leitor leitor, GerandorTextoAquecimento gerandorTextoAquecimento)
        {
            this.leitor = leitor;
            this.gerandorTextoAquecimento = gerandorTextoAquecimento;
        }

        public string Aquecer(string entrada)
        {
            var dados = leitor.Ler(entrada);
            var aquecendo = gerandorTextoAquecimento.Execute(dados);
            return aquecendo + Environment.NewLine + "aquecida"; 
        }
    }

    public class GerandorTextoAquecimento
    {
        public string Execute(Dados dados) {
            return new string('.', dados.Tempo * dados.Potencia);
        }
    }


    public class Leitor
    {
        private readonly Validador validador;

        public Leitor(Validador validador)
        {
            this.validador = validador;
        }

        public Dados Ler (string entrada)
        {
            Dados dados = new Dados();
            var tempDados =  entrada.Split(';' );

            if (tempDados.Length == 0)
            {
                throw new Exception("Favor, informar os parametros para o aquecimento <tempo;potencia>");
            }else 
            if (tempDados.Length == 1  && !tempDados[0].Equals("Rapido", StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception("Para iniciar o aquecimento rápido utilize o parametro <Rapido> ou informe os parametro <tempo;potencia>");
            }
            else if (tempDados.Length == 2)
            {
                try
                { dados.Tempo = int.Parse(tempDados[0]); }
                catch
                { throw new Exception("Informe o parametro de Tempo válido."); }

                try
                { dados.Potencia = int.Parse(tempDados[1]); }
                catch
                { throw new Exception("Informe o parametro de Potência válido."); }
            }
            else if (tempDados.Length > 2)
            {
                throw new Exception("Não possui a quantidade necessária de paametros. Utilize <tempo;potencia>");
            }

            dados.Entrada = entrada;

            validador.Validar(dados);

            return dados;
        }
    }

    public class Validador
    {
        public void Validar(Dados dados) {
            // if condiçao 1 throw 
            
            if (dados.Tempo < 1 | dados.Tempo > 120)
            {   throw new Exception("O parametro de Tempo deve ser maior que 1 e menor que 120 segundos (2 minutos)");  }

            if (dados.Potencia < 1 | dados.Potencia > 10)
            {   throw new Exception("O parametro de Potência deve ser maior que 1 e menor que 10");            }

        }
    }
    public class Dados
    {
        public int Tempo { get; set; } = 30;
        public int Potencia { get; set; } = 8;
        public string Entrada { get; set; } = "";

    }
  
}
