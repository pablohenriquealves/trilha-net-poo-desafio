using System;
using DesafioPOO.Models;


// Criando um objeto Nokia
            Smartphone nokia = new Nokia("123456789", "Nokia 7.2", "ABC123", 64);

            // Testando métodos do Nokia
            Console.WriteLine("Testando Nokia:");
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine("\n");

            // Criando um objeto Iphone
            Smartphone iphone = new Iphone("987654321", "iPhone 12", "XYZ789", 128);

            // Testando métodos do iPhone
            Console.WriteLine("Testando iPhone:");
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");

            Console.ReadLine();
