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

   