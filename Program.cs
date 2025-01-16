// Program.cs
using System;
using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Teste com a classe Nokia
        Smartphone nokia = new Nokia("123456", "ModeloNokia", "1111111111", 64);
        Console.WriteLine("--- Teste com Nokia ---");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        // Teste com a classe iPhone
        Smartphone iphone = new Iphone("654321", "ModeloIphone", "2222222222", 128);
        Console.WriteLine("--- Teste com iPhone ---");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}