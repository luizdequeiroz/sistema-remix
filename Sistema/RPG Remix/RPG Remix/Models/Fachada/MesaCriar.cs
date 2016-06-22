using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RPG_Remix.Models.Fachada
{
    public class MesaCriar
    {
        public Mesa Mesa { get; set; }

        public MesaCriar()
        {
            Mesa = new Mesa();
            Mestre = new Mestre();
        }

        [Required(ErrorMessage = "O nome da mesa é necessário!")]
        [Remote("MesaUnica", "Desktop", ErrorMessage = "Este nome já está sendo usado!")]
        public string Nome
        {
            get
            {
                return Mesa.Nome;
            }
            set
            {
                Mesa.Nome = value;
            }
        }

        [Required(ErrorMessage = "A descrição da mesa é necessária!")]
        public string Descricao
        {
            get
            {
                return Mesa.Descricao;
            }
            set
            {
                Mesa.Descricao = value;
            }
        }

        public int? NumeroJogadores
        {
            get
            {
                return Mesa.NumeroJogadores;
            }
            set
            {
                Mesa.NumeroJogadores = value;
            }
        }

        public string Senha
        {
            get
            {
                return Mesa.Senha;
            }
            set
            {
                Mesa.Senha = value;
            }
        }

        public Mestre Mestre
        {
            get
            {
                return Mesa.Mestre;
            }
            set
            {
                Mesa.Mestre = value;
            }
        }

        [Required(ErrorMessage = "O nome do mestre é obrigatório para a mesa!")]
        public string NomeMestre
        {
            get
            {
                return Mestre.Nome;
            }
            set
            {
                Mestre.Nome = value;
            }
        }
    }
}