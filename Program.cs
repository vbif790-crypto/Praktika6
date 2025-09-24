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

        