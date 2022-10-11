using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjF1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseContext context = new BaseContext();
            //Equipe e = new Equipe() { Nome = "Ferrari" };
            //context.Equipes.Add(e);
            //context.SaveChanges();

            //var equipes = context.Equipes.ToList();

            //foreach (var item in equipes)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            //Console.ReadKey();

            //string n = Console.ReadLine();

            //var e = new Equipe();

            //foreach (var item in equipes)
            //{
            //    if (n == item.Nome)
            //        e = item;
            //}
            //Carro c = new Carro() { Nome = "Baratex F1", Equipe = e };
            //context.Carros.Add(c);
            //context.SaveChanges();

            var carros = new BaseContext().Carros.ToList();

            foreach (var item in carros)
            {
                carros = new BaseContext().Carros.Include(item.Equipe.ToString()).FirstOrDefault(item.EquipeId == );
                var e = new BaseContext().Equipes.FirstOrDefault(x => x.Id == item.EquipeId);
                //Console.WriteLine(item.ToString());
                //Console.WriteLine(e.ToString());
            }

            Console.ReadKey();
        }
    }
}
