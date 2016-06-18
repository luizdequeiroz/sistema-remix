using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RPG_Remix.Models.Fachada
{
    public class UsuarioFacade
    {
        public UsuarioEntrar UsuarioEntrarModel { get; set; }
        public UsuarioCadastrar UsuarioCadastrarModel { get; set; }

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

        public class UsuarioCadastrar
        {
            public Usuario Usuario { get; set; }

            public UsuarioCadastrar()
            {
                Usuario = new Usuario();
            }

            [Required(ErrorMessage = "Informe seu nome. Não é necessário ser completo.")]
            public string Nome
            {
                get
                {
                    return Usuario.Nome;
                }
                set
                {
                    Usuario.Nome = value;
                }
            }

            [Required(ErrorMessage = "Informe seu e-mail para o acesso.")]
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

            [Required(ErrorMessage = "Informe a senha para o acesso.")]
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

            [Required(ErrorMessage = "Confirme sua senha para o acesso.")]
            [System.Web.Mvc.Compare("Senha", ErrorMessage = "A confirmação não confere com a senha!")]
            public string RepSenha { get; set; }

            [RegularExpression(@"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$",
                ErrorMessage = "O E-mail informado năo é válido!")]
            public string DataNascimento
            {
                get
                {
                    return Usuario.DataNascimento;
                }
                set
                {
                    Usuario.DataNascimento = value;
                }
            }

            [Required(ErrorMessage = "Não quer informar seu sexo? Selecione \"Outro\"!")]
            public char Sexo
            {
                get
                {
                    return (char)Usuario.Sexo;
                }
                set
                {
                    Usuario.Sexo = (byte)value;
                }
            }

            [StringLength(200, MinimumLength = 10, ErrorMessage = "Se você optou por se descrever, o texto deve ter entre 10 e 200 caracteres!")]
            public string Descricao
            {
                get
                {
                    return Usuario.Descricao;
                }
                set
                {
                    Usuario.Descricao = value;
                }
            }
        }
    }
}