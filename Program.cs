using System;
using ExemploPOO.Models;


namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {


            Aluno a1 = new Aluno();
            a1.Nome = "Fernando";
            a1.Nota = 10;
            a1.Apresentar();

            Professor p1 = new Professor();
            p1.Nome = "Daniel";
            p1.Salario = 5.535;
            p1.Apresentar();

            // ---------------------------------------------------------- 

            //Retangulo r = new Retangulo();

            //r.Definir(30,30);

            //System.Console.WriteLine($"Área: {r.ObterArea()}");

            //-------------------------------------------------------------

            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Jordana";
            // p1.Idade = 26;

            // p1.Apresentar();

            //-------------------------------------------------------------

            // Aluno aluno1 = new Aluno();
            // aluno1.Nome = "Jessica";
            // aluno1.Idade = 28;
            // aluno1.Nota = 9.5;

            // System.Console.WriteLine($"{aluno1.Nome} tem {aluno1.Idade} anos e tirou {aluno1.Nota} de média geral");

            // Professor prof = new Professor();
            // prof.Nome = "Leonardo";
            // prof.Idade = 45;

            // prof.Apresentar();
        }
    }
}