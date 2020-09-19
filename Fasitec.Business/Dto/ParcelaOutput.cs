using System;

namespace Fasitec.Business.Dto
{
    public class ParcelaOutput
    {        
        public int ParcelaId { get;set; }
        public int Numero { get;set; }
        public decimal Valor { get;set; }
        public DateTime? DataPagamento { get;set; }
        public bool Pago { get;set; }
    }
}