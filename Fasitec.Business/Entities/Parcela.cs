using System;

namespace Fasitec.Business.Entities
{
    public class Parcela
    {
        public int ParcelaId { get;set; }
        public int Numero { get;set; }
        public decimal Valor { get;set; }
        public DateTime? DataPagamento { get;set; }
        public bool Pago { get;set; }
    }
}