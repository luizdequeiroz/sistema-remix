using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RPG_Remix.Models.Fachada
{
    public class UsuarioFacade
    {
        public Usuario Usuario { get; set; }
        public Usuario UsuarioEntrada { get; set; }
        public Usuario UsuarioCadastro { get; set; }

        public UsuarioFacade()
        {
            Usuario = new Usuario();
            UsuarioEntrada = new Usuario();
            UsuarioCadastro = new Usuario();
        }
        
        [Required(ErrorMessage="O nome é obrigatório!")]
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
        public byte Sexo
        {
            get
            {
                return Usuario.Sexo;
            }
            set
            {
                Usuario.Sexo = value;
            }
        }
        public string DataCadastro
        {
            get
            {
                return Usuario.DataCadastro;
            }
            set
            {
                Usuario.DataCadastro = value;
            }
        }
    }
}