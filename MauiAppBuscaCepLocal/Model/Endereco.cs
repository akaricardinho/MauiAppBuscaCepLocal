using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppBuscaCepLocal.Model
{
    internal class Endereco
    {
        public int id_logradouro { get; set; }
        public int id_cidade { get; set; }
        public string tipo { get; set; }
        public string descricao { get; set; }
        public string uf { get; set; } 
        public string complemente { get; set; }
        public string descricao_sem_numero { get; set; }   

    }
}
