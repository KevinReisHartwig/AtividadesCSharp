﻿using AtividadeMetodoAbstrato.Entities;
using AtividadeMetodoAbstrato.Enums;
using System.Globalization;

namespace AtividadeHerançaPolimorfismo;
class Program {
    static void Main(string[] args) {

        List<Shape> list = new List<Shape>();

        Console.Write("Enter  the number of shapes: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++) {
            Console.WriteLine($"Shape #{i} date: ");
            Console.Write("Reactangle or Circle (r/c: )");
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("Color (Black/Blue/Red: ");
            Color color = Enum.Parse<Color>(Console.ReadLine());

            if (ch == 'r') {
                Console.Write("Widht: ");
                double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Height: ");
                double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Rectangle(height, width, color));

            }
            else {
                Console.Write("Radius: ");
                double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Circle(radius, color));
            }

            Console.WriteLine();
            Console.WriteLine("Shape areas: ");
            foreach (Shape shape in list) {
                Console.WriteLine(shape.Area().ToString("F2"), CultureInfo.InvariantCulture);


            }

        
    
            }

        }

    }
