using System.Collections.Generic;

namespace Fasitec.Business.Entities
{
    public class Contrato
    {
        public int ContratoId { get; set; }
        public int Numero { get;set; }
        public string Banco { get;set; }
        public decimal Valor { get;set; }
        public int QtdeParcelas { get;set; }        
        public virtual ICollection<Parcela> Parcelas { get; set;}
    }
}