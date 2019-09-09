using System;

namespace calculaSalario
{
    public enum Cargo
    {
        DESENVOLVEDOR,
        DBA,
        TESTADOR
    }

    public class Funcionario
    {
        public String Nome { get; private set; }
        public double Salario { get; private set; }
        public Cargo Cargo { get; private set; }

        public Funcionario(String nome, double salario, Cargo cargo)
        {
            this.Nome = nome;
            this.Salario = salario;
            this.Cargo = cargo;
        }
    }
    public class CalculadoreDeSalario
    {
        public double CalculaSalario(Funcionario funcionario)
        {
            if (funcionario.Cargo.Equals(Cargo.DESENVOLVEDOR))
            {
                if (funcionario.Salario > 3000) return 3200.0;
                return 1350.0;
            }
            return 425.0;
        }
    }
}
