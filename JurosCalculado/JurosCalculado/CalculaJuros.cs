using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace JurosCalculado
{
    public class CalculaJuros
    {
        private string JurosHost;

        public CalculaJuros()
        {
            JurosHost = "http://" + BuscaURL();
        }

        public string RealizaCalculo(double valorInicial, int meses)
        {
            if (valorInicial == 0)
                return "deve informar valor inicial";
            var juros = GetJuros();
            return Calcula(valorInicial, meses, juros);
        }

        public double GetJuros()
        {
            string MetodoPath = "/JurosFixo";

            string juros;
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(JurosHost + MetodoPath);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var resultado = streamReader.ReadToEnd();
                    if (string.IsNullOrEmpty(resultado))
                        throw new Exception("Sem valor vinculado.");
                    juros = resultado;

                }
            }
            catch (Exception e)
            {
                throw new Exception("Falha ao buscar juros: " + e.Message);
            }
            return Convert.ToDouble(juros.Replace(",", "."));

        }

        public string BuscaURL()
        {
            try
            {

                TextReader tr = new StreamReader("EnderecoURL.txt");
                string endereco = tr.ReadLine();
                tr.Close();

                return endereco;
            }
            catch
            {
                TextWriter tw = new StreamWriter("EnderecoURL.txt");
                string enderecoFixo = "192.168.1.4:62489";
                tw.WriteLine(enderecoFixo);
                tw.Close();
                return enderecoFixo;
            }

        }

        public string Calcula(double valorInicial, int meses, double juros)
        {
            var resultado = valorInicial * Math.Pow(1 + juros, meses);
            return resultado.ToString("0.00");
        }
    }
}



          