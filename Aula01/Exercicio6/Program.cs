﻿using System;

namespace Exercicio6
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Declarar os gatos
            Cat cat1, cat2;

            // Alterar os valores comuns a todos os gatos
            Cat.MaxEnergy = 300;
            Cat.EnergyGainAfterSleep = 25;
            Cat.EnergyLossAfterMeow = 2;
            Cat.EnergyLossAfterPlay = 14;

            // Criar dois gatos usando os diferentes construtores
            cat1 = new Cat("Lombriga");
            cat2 = new Cat("Minhoca", 99, Feed.Full, Mood.HyperActive);

            // Mostrar estado de cada gato antes das ações
            Console.WriteLine("Estado inicial dos gatos:");

            Console.WriteLine("\tNome={0}, Energia={1}, Aliment.={2}, Disp.={3}",
                cat1.Name, cat1.Energy, cat1.FeedStatus, cat1.MoodStatus);

            Console.WriteLine("\tNome={0}, Energia={1}, Aliment.={2}, Disp.={3}",
                cat2.Name, cat2.Energy, cat2.FeedStatus, cat2.MoodStatus);

            // Gato 1 brinca e diz miau
            Console.WriteLine($"{cat1.Name} plays");
            cat1.Play();
            cat1.Meow();

            // Gato 2 come e dorme
            Console.WriteLine($"{cat2.Name} eats and sleeps");
            cat2.Eat();
            cat2.Sleep();

            // Estado dos gatos após terem efetuado algumas ações
            Console.WriteLine("Estado final dos gatos, após as suas ações:");

            Console.WriteLine("\tNome={0}, Energia={1}, Aliment.={2}, Disp.={3}",
                cat1.Name, cat1.Energy, cat1.FeedStatus, cat1.MoodStatus);

            Console.WriteLine("\tNome={0}, Energia={1}, Aliment.={2}, Disp.={3}",
                cat2.Name, cat2.Energy, cat2.FeedStatus, cat2.MoodStatus);

        }
    }
}
