/* Como Colecoes Hash comparam igualdade
 *
 *  - Caso GetHashCode e Equals estejam implementados:
 *      > Primeiro, faz GetHashCode;
 *      > Se der igual, usa o Equals para confirmar.
 *      
 *  - Caso GetHashCode e Equals NAO estiverem implementados:
 *      > Tipos referencia: compara as referencias dos objetos na memoria;
 *      > Tipos valor: compara os valores dos atributos.
 */

/* >>> PROGRAMA PRINCIPAL <<< */
using System;
using System.Collections.Generic;
using Aula210_ColecoesHash.Entities;

namespace Aula210_ColecoesHash
{
    class Program
    {
        static void Main(string[] args)
        {
            // A Classe String possui a implementacao do GetHashCode e Equals
            HashSet<string> set = new HashSet<string>(); // Instancia um HashSet vazio

            set.Add("Juliane"); // Adiciona valores
            set.Add("Vinicius");
            Console.Write("Com implementacao do GetHashCode e Equals direto pelo tipo String nativo do C#: ");
            Console.WriteLine(set.Contains("Juliane")); // Ja faz automaticamente o GetHashCode e Equals para comparar

            // Cria o conjunto "a" tipo "Product"
            Console.Write("Tipo Referencia, implementando GetHashCode e Equals no tipo Product: ");
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0)); // Adiciona itens ao conjunto
            a.Add(new Product("Notebook", 1200.00)); // Objeto diferente do "prod", mais abaixo no codigo

            // Cria o conjunto "b" tipo "Point"
            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4)); // Adiciona itens ao conjunto
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.00); /* Novo objeto, diferente do insedido mais acima no codigo
                                                              * com "Add", com endereco de memoria diferente */
            Console.WriteLine(a.Contains(prod));

            Console.Write("Tipo Valor, SEM implementacao GetHashCode e Equals no tipo Point: ");
            Point p = new Point(5, 10);
            Console.WriteLine(b.Contains(p));
        }
    }
}
