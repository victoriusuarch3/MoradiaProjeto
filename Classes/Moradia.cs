namespace MoradiaProjeto.Classes
{
    public class Moradia
    {
        protected string Endereco {get; set;}
        protected int Cep {get; set;}
        protected double TamanhoEmMetros {get; set;}
        protected int QuantidadeDeQuartos {get; set;}
        protected List<Morador> Moradores{get; set;}   

        public Moradia(string endereco, int cep, double tamanhoemmetros, int quantidadedequartos)
        {
            Endereco = endereco;
            Cep = cep;
            TamanhoEmMetros = tamanhoemmetros;
            QuantidadeDeQuartos = quantidadedequartos;

            Moradores = new List<Morador>();
        }
        
        public void SetEndereco(string endereco)
        {
            Endereco = endereco;
        }
        public string GetEndereco()
        {
            return Endereco;
        }

        public void SetCep(int cep)
        {
            Cep = cep;
        }
        public int GetCep()
        {
            return Cep;
        }
        public void SetTamanhoEmMetros(double tamanhoemmetros)
        {
            TamanhoEmMetros = tamanhoemmetros;
        }
        public double GetTamanhoEmMetros()
        {
            return TamanhoEmMetros;
        }
        public void SetQuantidadeDeQuartos(int quantidadedequartos)
        {
            QuantidadeDeQuartos = quantidadedequartos;
        }
        public int GetQuantidadeDeQuartos()
        {
            return QuantidadeDeQuartos;
        }
    }
}