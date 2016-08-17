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
        }

        [Required(ErrorMessage = "O nome do personagem é obrigatório!")]
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

        [Required(ErrorMessage = "A Adrenalina é obrigatória!")]
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
        [Required(ErrorMessage = "O Ataque é obrigatório!")]
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
        [Required(ErrorMessage = "A Defesa é obrigatória!")]
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
        [Required(ErrorMessage = "A Destreza é obrigatória!")]
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
        [Required(ErrorMessage = "A Força é obrigatória!")]
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
        [Required(ErrorMessage = "A Inteligência é obrigatória!")]
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
        [Required(ErrorMessage = "A Resistência é obrigatória!")]
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
        [Required(ErrorMessage = "A Sabedoria é obrigatória!")]
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
        [Required(ErrorMessage = "A Velocidade é obrigatória!")]
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
        [Required(ErrorMessage = "A Vitalidade é obrigatória!")]
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
        [Required(ErrorMessage = "A Sorte é obrigatória!")]
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