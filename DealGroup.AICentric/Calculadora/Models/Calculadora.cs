using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraApp.Models
//Represebtação das 4 operações básicas da matemática
{
    public class Calculadora
    {// Abrindo a Classe Calculadora
        public void Somar(int x, int y) //Recebendo dois números como parametro no método
        {
            Console.WriteLine($"{x} + {y} = {x + y} "); // {x} + {y} pega o valor das variaveis, {x + y} Soma o valor das variaves


        }

        public void Subtrair(int x, int y) //Recebendo dois números como parametro no método
        {
            Console.WriteLine($"{x} - {y} = {x - y} "); // {x} - {y} pega o valor das variaveis, {x - y} Subtrai o valor das variaves


        }

        public void Multiplicar(int x, int y) //Recebendo dois números como parametro no método
        {
            Console.WriteLine($"{x} * {y} = {x * y} "); // {x} * {y} pega o valor das variaveis, {x * y} Multiplica o valor das variaves


        }

        public void Dividir(int x, int y) //Recebendo dois números como parametro no método
        {
            Console.WriteLine($"{x} / {y} = {x / y} "); // {x} / {y} pega o valor das variaveis, {x / y} Divide o valor das variaves


        }

        public void Potencia(int x, int y) //Recebendo dois números como parametro no método
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {pot}"); // {x} * {y} pega o valor das variaveis, {pot} calcula
        }

        public void Seno(double angulo) //Recebendo parametro no método
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano); // Math.Sin calcula o seno do angulo em radiano
            Console.WriteLine($"Seno de {angulo}º = {Math.Round(seno, 4)}"); // {angulo} pega o valor da variavel, {seno} calcula.
            //{Math.Round(seno, 4)}") arredonda o valor do seno para 4 casas decimais
        }

        public void Coseno(double angulo) //Recebendo parametro no método
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano); // Math.Cos calcula o seno do angulo em radiano
            Console.WriteLine($"coseno de {angulo}º = {Math.Round(coseno, 4)}"); // {angulo} pega o valor da variavel, {coseno} calcula
            //{Math.Round(seno, 4)}") arredonda o valor do seno para 4 casas decimais
        }

        public void Tangente(double angulo) //Recebendo parametro no método
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano); // Math.Tan calcula o seno do angulo em radiano
            Console.WriteLine($"Tangente de {angulo}º = {Math.Round(tangente, 4)}"); // {angulo} pega o valor da variavel, {tangente} calcula
            //{Math.Round(seno, 4)}") arredonda o valor do seno para 4 casas decimais
        }

        public void RaizQuadrda(double x) //Recebendo parametro no método
        {
            double raiz = Math.Sqrt(x); // Math.Sqrt calcula a raiz quadrada do número
            Console.WriteLine($"Raiz Quadrada de {x} = {raiz} "); // {x} pega o valor da variavel, {raiz} calcula
        }

    } // Fechando a Classe Calculadora
}