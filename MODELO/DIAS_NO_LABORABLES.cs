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
    
    public partial class DIAS_NO_LABORABLES
    {
        public int Id { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Motivo { get; set; }
    
        public virtual DATOS_EMPRESA DATOS_EMPRESA { get; set; }
    }
}
