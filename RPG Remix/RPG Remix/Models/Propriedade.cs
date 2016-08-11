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
    
    public partial class Propriedade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Nullable<int> CoordX { get; set; }
        public Nullable<int> CoordY { get; set; }
        public Nullable<int> CoordGX { get; set; }
        public Nullable<int> CoordGY { get; set; }
        public int FichaId { get; set; }
        public int RegiãoId { get; set; }
    
        public virtual Ficha Ficha { get; set; }
        public virtual Região Região { get; set; }
    }
}
