using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MiniTCC_Smartir.Classes
{
    internal class Lab
    {
        //Atributos Lab
        private int idlab;
        private string nome;
        private string localizacao;
        private string descricao;

        //Construtor com parametro
        public Lab(int idlab, string nome, string localizacao, string descricao)
        {
            this.idlab = idlab;
            this.nome = nome;
            this.localizacao = localizacao;
            this.descricao = descricao;
        }

        //Emcapsulamento
        public int Idlab { get => idlab; set => idlab = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Localizacao { get => localizacao; set => localizacao = value; }
        public string Descricao { get => descricao; set => descricao = value; }

        //Construtor sem parametro
        public Lab() { }
    }
}
