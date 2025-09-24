using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    class Computer
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public int RAM { get; set; } // ОЗУ в Гб
        public int DiskSpace { get; set; } // Жесткий диск в Гб
        public double Speed { get; set; } // Скорость в ГГц

        public Computer(int id, string brand, int ram, int diskSpace, double speed)
        {
            ID = id;
            Brand = brand;
            RAM = ram;
            DiskSpace = diskSpace;
            Speed = speed;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Марка: {Brand}, ОЗУ: {RAM} Гб, ДП: {DiskSpace} Гб, Скорость: {Speed} ГГц";
        }
    }

    static void Main()
    {
        List<Computer> computers = new List<Computer>();

        computers.Add(new Computer(1, "Apple", 12, 200, 2));
        computers.Add(new Computer(2, "Asus", 6, 1500, 2.3));
        computers.Add(new Computer(3, "Lenovo", 8, 600, 2.5));
        computers.Add(new Computer(4, "Assus", 6, 1000, 4));
        computers.Add(new Computer(5, "Apple", 4, 1400, 2.8));

        Console.WriteLine("Все компьютеры в коллекции:");
        foreach (var computer in computers)
        {
            Console.WriteLine(computer);
        }
        Console.WriteLine();

        Console.WriteLine("Добавляем новый компьютер перед ID=3");
        Computer newComputer = new Computer(1, "Sumsung", 10, 2000, 4.4);

        int indexToInsert = computers.FindIndex(c => c.ID == 3);

        if (indexToInsert != -1)
        {
            computers.Insert(indexToInsert, newComputer);
            Console.WriteLine("Новый компьютер добавлен успешно");
        }
        else
        {
            Console.WriteLine("Компьютер с ID=3 не найден");
        }
        Console.WriteLine();

        Console.WriteLine("Все компьютеры после добавления нового:");
        foreach (var computer in computers)
        {
            Console.WriteLine(computer);
        }
        Console.WriteLine();

        Console.WriteLine("Удаляем компьютер с ID=3");
        computers.RemoveAll(c => c.ID == 3);
        Console.WriteLine("Компьютер с ID=3 удален");
        Console.WriteLine();

        Console.WriteLine("Все компьютеры после удаления:");
        foreach (var computer in computers)
        {
            Console.WriteLine(computer);
        }
        Console.WriteLine();

        Console.WriteLine("Поиск всех компьютеров Assus:");
        List<Computer> compAssus = computers.Where(c => c.Brand == "Assus").ToList();

        if (compAssus.Any())
        {
            foreach (var computer in compAssus)
            {
                Console.WriteLine(computer);
            }
        }
        else
        {
            Console.WriteLine("Компьютеры марки Assus не найдены");
        }
        Console.WriteLine();

        Console.WriteLine("Упорядоченные компьютеры по Марка и Скорость:");
        var sortedComputers = computers.OrderBy(c => c.Brand).ThenBy(c => c.Speed).ToList();

        foreach (var computer in sortedComputers)
        {
            Console.WriteLine(computer);
        }
    }
}