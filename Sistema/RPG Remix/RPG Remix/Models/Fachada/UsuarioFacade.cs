using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPG_Remix.Models.Fachada
{
    public class UsuarioFacade
    {
        Usuario Usuario;

        public UsuarioFacade()
        {
            Usuario = new Usuario();
        }

        public int Id
        {
            get
            {
                return Usuario.Id;
            }
            set
            {
                Usuario.Id = value;
            }
        }
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