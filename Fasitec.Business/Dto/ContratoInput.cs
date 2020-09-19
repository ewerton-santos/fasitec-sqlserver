namespace Fasitec.Business.Dto
{
    public class ContratoInput
    {
        public int ContratoId { get; set;}
        public int Numero { get; set; }
        public string Banco { get; set; }
        public decimal Valor { get; set; }
        public int QtdeParcelas { get; set; }
    }
}