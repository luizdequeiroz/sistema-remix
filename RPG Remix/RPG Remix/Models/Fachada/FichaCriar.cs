using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RPG_Remix.Models.Fachada
{
    public class FichaCriar
    {
        public Ficha Ficha { get; set; }

        public FichaCriar()
        {
            Ficha = new Ficha();
            Idade = 0;
            Raca = "Desconhecida";
            Classe = "Desconhecida";
            PtsExperiencia = 0;
            Suportes = 0;
        }

        [Required(ErrorMessage = "O nome e a idade do personagem são obrigatórios!")]
        public string Nome
        {
            get
            {
                return Ficha.Nome;
            }
            set
            {
                Ficha.Nome = value;
            }
        }
        public int Idade
        {
            get
            {
                return Ficha.Idade;
            }
            set
            {
                Ficha.Idade = value;
            }
        }
        public string Raca
        {
            get
            {
                return Ficha.Raca;
            }
            set
            {
                Ficha.Raca = value;
            }
        }
        public string Classe
        {
            get
            {
                return Ficha.Classe;
            }
            set
            {
                Ficha.Classe = value;
            }
        }

        [Required]
        public int Adre
        {
            get
            {
                return Ficha.Adre;
            }
            set
            {
                Ficha.Adre = value;
            }
        }
        [Required]
        public int Ataq
        {
            get
            {
                return Ficha.Ataq;
            }
            set
            {
                Ficha.Ataq = value;
            }
        }
        [Required]
        public int Defe
        {
            get
            {
                return Ficha.Defe;
            }
            set
            {
                Ficha.Defe = value;
            }
        }
        [Required]
        public int Dest
        {
            get
            {
                return Ficha.Dest;
            }
            set
            {
                Ficha.Dest = value;
            }
        }
        [Required]
        public int Forc
        {
            get
            {
                return Ficha.Forc;
            }
            set
            {
                Ficha.Forc = value;
            }
        }
        [Required]
        public int Inte
        {
            get
            {
                return Ficha.Inte;
            }
            set
            {
                Ficha.Inte = value;
            }
        }
        [Required]
        public int Resi
        {
            get
            {
                return Ficha.Resi;
            }
            set
            {
                Ficha.Resi = value;
            }
        }
        [Required]
        public int Sabe
        {
            get
            {
                return Ficha.Sabe;
            }
            set
            {
                Ficha.Sabe = value;
            }
        }
        [Required]
        public int Velo
        {
            get
            {
                return Ficha.Velo;
            }
            set
            {
                Ficha.Velo = value;
            }
        }
        [Required]
        public int Vital
        {
            get
            {
                return Ficha.Vital;
            }
            set
            {
                Ficha.Vital = value;
            }
        }
        [Required]
        public int Sort
        {
            get
            {
                return Ficha.Sort;
            }
            set
            {
                Ficha.Sort = value;
            }
        }
        public int Suportes
        {
            get
            {
                return Ficha.Suportes;
            }
            set
            {
                Ficha.Suportes = value;
            }
        }
        public int PtsTestes
        {
            get
            {
                return Ficha.PtsTestes;
            }
            set
            {
                Ficha.PtsTestes = value;
            }
        }
        public int PtsPericias
        {
            get
            {
                return Ficha.PtsPericias;
            }
            set
            {
                Ficha.PtsPericias = value;
            }
        }
        public int PtsDesvantagens
        {
            get
            {
                return Ficha.PtsDesvantagens;
            }
            set
            {
                Ficha.PtsDesvantagens = value;
            }
        }
        public int PtsExperiencia
        {
            get
            {
                return Ficha.PtsExperiencia;
            }
            set
            {
                Ficha.PtsExperiencia = value;
            }
        }
    }
}