using System;

namespace GustavoASP.Models
{
    public class DadosClima
    {
        public string Cidade { get; set; }
        public string Descricao { get; set; }
        public double Temperatura { get; set; }
        public double SensacaoTermica { get; set; }
        public double TemperaturaMinima { get; set; }
        public double TemperaturaMaxima { get; set; }
        public int Pressao { get; set; }
        public int Umidade { get; set; }
        public double VelocidadeVento { get; set; }
        public int DirecaoVento { get; set; }
        public double RajadaVento { get; set; }
        public int Nuvens { get; set; }
        public int Visibilidade { get; set; }
        public DateTime Amanhecer { get; set; }
        public DateTime Anoitecer { get; set; }
        public int Timezone { get; set; }

        public int Dt { get; set; }
    }
}
