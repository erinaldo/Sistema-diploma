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
    
    public partial class AFILIADO
    {
        public AFILIADO()
        {
            this.TURNO = new HashSet<TURNO>();
            this.DEUDAS = new HashSet<DEUDA>();
            this.FACTURAS = new HashSet<FACTURA>();
            this.RECIBOS = new HashSet<RECIBO>();
        }
    
        public int Id_Afiliado { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public int DNI { get; set; }
        public System.DateTime Fecha_Nacimiento { get; set; }
        public string Sexo { get; set; }
        public int Numero_Contrato { get; set; }
        public string Forma_Pago { get; set; }
        public bool Estado { get; set; }
    
        public virtual PLAN PLAN { get; set; }
        public virtual ICollection<TURNO> TURNO { get; set; }
        public virtual ICollection<DEUDA> DEUDAS { get; set; }
        public virtual ICollection<FACTURA> FACTURAS { get; set; }
        public virtual TARJETA TARJETAS { get; set; }
        public virtual ICollection<RECIBO> RECIBOS { get; set; }
    }
}
