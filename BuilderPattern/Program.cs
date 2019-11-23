using System;
using System.Text.Json;
using BuilderPattern.Builders;
using BuilderPattern.Domain;
using BuilderPattern.Util;

namespace BuilderPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            string keypress;

            do
            {
                // 0)
                // Display starting menu
                Console.Clear();

                Console.WriteLine("Builder Pattern -- Computer Context");
                Console.WriteLine();

                // 1)
                // Select model ( desktop / laptop )                
                Console.WriteLine("1) Build desktop pc");
                Console.WriteLine("2) Build laptop");

                var modelChoice = Console.ReadKey().KeyChar.ToString();
                Console.Clear();

                ComputerBuilder builder;

                if (modelChoice == "1")
                {
                    builder = Store.SelectModel(ComputerModel.Desktop);
                }
                else
                {
                    builder = Store.SelectModel(ComputerModel.Laptop);
                }

                // 2) Open an empty shopping cart
                builder.OpenCart();

                // 3)
                // Add parts to the computer                
                string partSelected;
                do
                {
                    Console.Clear();

                    Console.WriteLine($"Select part.  Done ( D )");
                    Console.WriteLine();

                    Console.WriteLine($"1) Add {Part.Cpu} ${(decimal)Part.Cpu}");
                    Console.WriteLine($"2) Add {Part.Memory} ${(decimal)Part.Memory}");
                    Console.WriteLine($"3) Add {Part.HardDrive} ${(decimal)Part.HardDrive}");

                    partSelected = Console.ReadKey().KeyChar.ToString();

                    if (partSelected.ToLower() == "d")
                    {
                        break;
                    }

                    Console.WriteLine();
                    Console.Write("Quantity: ");
                    Console.WriteLine();

                    int.TryParse(Console.ReadKey().KeyChar.ToString(), out int quantity);

                    switch (partSelected)
                    {
                        case "1":
                            builder.AddPart(Part.Cpu, quantity);
                            break;
                        case "2":
                            builder.AddPart(Part.Memory, quantity);
                            break;
                        case "3":
                            builder.AddPart(Part.HardDrive, quantity);
                            break;
                    }

                } while (partSelected.ToLower() != "d");

                // 7)
                // Display Computer and cost to build      
                Console.Clear();
                Console.WriteLine("Thank you for shopping with us!");
                Console.WriteLine();

                Console.WriteLine("Model:");
                Console.WriteLine($"{builder.Computer.Model}");

                Console.WriteLine();
                Console.WriteLine("Parts:");
                Console.WriteLine(DictionarySerialize.Parts(builder.Computer.Parts));

                Console.WriteLine();
                Console.WriteLine("Total Price:");
                Console.WriteLine($"${builder.Cart.TotalPrice}");

                Console.WriteLine();
                Console.WriteLine("Line Items:");
                Console.WriteLine(DictionarySerialize.Parts(builder.Cart.Parts));

                Console.WriteLine();
                Console.WriteLine("Menu ( M )");
                Console.WriteLine("Exit ( X )");

                keypress = Console.ReadKey().KeyChar.ToString();
            } while (keypress.ToLower() != "x");
        }
    }
}
