using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MiniTCC_Smartir.Classes
{
    internal class Esp32
    {
        //Atributos Esp32
        private int idesp32;
        private string ip;
        private string estado;
        private int v1;
        private int v2;

        //Construtor com parametros
        public Esp32(int idesp32, string ip, string estado)
        {
            this.idesp32 = idesp32;
            this.ip = ip;
            this.estado = estado;
        }

        //Emcapsulamento
        public int Idesp32 { get => idesp32; set => idesp32 = value; }
        public string Ip { get => ip; set => ip = value; }
        public string Estado { get => estado; set => estado = value; }

        //Construtor sem parametro
        public Esp32() { }

        public Esp32(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}
