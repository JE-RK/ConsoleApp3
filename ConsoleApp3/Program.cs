using System;
using System.Collections.Generic;

namespace ConsoleApp3
{

    class Mainland
    {
        public static string materik = "Евразия Африка Австралия Северная-Америка Южная-Америка Антарктида";
        public static List<string> materik2 = new List<string>(materik.Split(' '));
    }

    class Ocean : Mainland
    {
        public static string ocean = "Атлантический Индийский Тихий Северный-Ледовитый";
        public static List<string> ocean2 = new List<string>(ocean.Split(' '));
    }

    class Island : Ocean
    {
        public static string island = "Гренландия Новая-Гвинея Калимантан Мадагаскар Баффинова-Земля Суматра Великобритания Хонсю Виктория Элсмир";
        public static List<string> island2 = new List<string>(island.Split(' '));
    }

    class Planet : Island
    {
        public static List<string> choice = new List<string>();
        public static string planet = "Земля";
        public void Getmainland()
        {
            Console.WriteLine("Выберите материк");
            foreach (var person in materik2)
            {
                Console.WriteLine(person);
            }
            int n = int.Parse(Console.ReadLine());
            choice.Add($"Материк: {materik2[n - 1]}");
        }

        public void Getocean()
        {
            Console.WriteLine("Выберите океан");
            foreach (var person in ocean2)
            {
                Console.WriteLine(person);
            }
            int n = int.Parse(Console.ReadLine());
            choice.Add($"Океан: {ocean2[n - 1]}");
        }

        public void Getisland()
        {
            Console.WriteLine("Выберите остров");
            foreach (var person in island2)
            {
                Console.WriteLine(person);
            }
            int n = int.Parse(Console.ReadLine());
            choice.Add($"Остров: {island2[n - 1]}");
        }

        public void Getplanet()
        {
            Console.WriteLine($"Назвние планеты: {planet}, хотите изменить?");
            string x = Console.ReadLine();
            switch (x)
            {
                case "да":
                    Console.WriteLine($"Введите новое название планеты");
                    planet = Console.ReadLine();
                    break;
                case "нет":
                    break;
            }

        }

        public void Getchoice()
        {
            foreach (var person in choice)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine($"Количество материков: {materik2.Count}");
            Console.WriteLine($"Название планеты: {planet}");
        }

        public void Getchange()
        {
        XYZ:
            Console.WriteLine("Все верно?");
            string y = Console.ReadLine();
            switch (y)
            {
                case "да":
                    Console.WriteLine("Cписок составлен!");
                    break;
                case "нет":
                    Console.WriteLine("Что вы хотите изменить?");
                    Console.WriteLine("Материк");
                    Console.WriteLine("Океан");
                    Console.WriteLine("Остров");
                    Console.WriteLine("Название планеты");
                    int c = int.Parse(Console.ReadLine());
                    switch (c)
                    {
                        case 1:
                            Getmainland();
                            Planet.choice.RemoveAt(0);
                            Getchoice();
                            goto XYZ;
                        case 2:
                            Getocean();
                            Planet.choice.RemoveAt(1);
                            Getchoice();
                            goto XYZ;
                        case 3:
                            Getisland();
                            Planet.choice.RemoveAt(2);
                            Getchoice();
                            goto XYZ;
                        case 4:
                            Console.WriteLine($"Введите новое название планеты");
                            planet = Console.ReadLine();
                            Getchoice();
                            goto XYZ;
                    }
                    break;
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Planet planet = new Planet();
            planet.Getmainland();
            planet.Getocean();
            planet.Getisland();
            planet.Getplanet();
            planet.Getchoice();
            planet.Getchange();
            Console.ReadKey();
        }
    }
}