using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RPG_Remix.Models.Fachada
{
    public class UsuarioEntrar
    {
        public Usuario Usuario { get; set; }

        public UsuarioEntrar()
        {
            this.Usuario = new Usuario();
        }

        [Required(ErrorMessage = "É necessário informar seu e-mail!")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "O E-mail informado năo é válido!")]
        public string Email
        {
            get
            {
                return Usuario.Email;
            }
            set
            {
                Usuario.Email = value;
            }
        }

        [Required(ErrorMessage = "É necessário informar sua senha!")]
        public string Senha
        {
            get
            {
                return Usuario.Senha;
            }
            set
            {
                Usuario.Senha = value;
            }
        }
    }
}