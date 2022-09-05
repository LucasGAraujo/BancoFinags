using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoFinags.Models
{
    public class Conta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }

        public Conta() { }
        public Conta(int id, string nome, double saldo)
        {
            Id = id;
            Nome = nome;
            Saldo = saldo;
        }
        public override string ToString()
        {
            return Nome + " " + Id + " " + Saldo;
        }
    }
}
