//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MODELO
{
    using System;
    using System.Collections.Generic;
    
    public partial class DEUDA
    {
        public int Id { get; set; }
        public string Mes { get; set; }
        public int Año { get; set; }
        public decimal Monto { get; set; }
        public bool Pagada { get; set; }
    
        public virtual AFILIADO AFILIADO { get; set; }
        public virtual DETALLE_RECIBO DETALLE_RECIBO { get; set; }
    }
}
