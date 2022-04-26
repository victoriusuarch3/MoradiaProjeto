namespace MoradiaProjeto.Classes
{
    public class Moradia
    {
        protected string Endereco {get; set;}
        protected int Cep {get; set;}
        protected double TamanhoEmMetros {get; set;}
        protected int QuantidadeDeQuartos {get; set;}
        protected List<Morador> Moradores{get; set;}        
    }
}