//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RPG_Remix.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Riqueza
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public double Valor { get; set; }
        public string Descricao { get; set; }
    
        public virtual Ficha Ficha { get; set; }
    }
}
