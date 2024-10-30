using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MiniTCC_Smartir.Classes
{
    internal class Conta
    {
        //Atributos Conta de um Usuario
        private int idusuario;
        private string nome;
        private string email;
        private string senha;

        //Construtor com parametro
        public Conta(int idusuario, string nome, string email, string senha)
        {
            this.idusuario = idusuario;
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }

        //Construtor sem parametro
        public Conta(){ }

        //encapsulamento
        public int Idusuario { get => idusuario; set => idusuario = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
