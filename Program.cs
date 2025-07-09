using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("71993129251", "Nokia 1100", 123456789, 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("71992458757", "Iphone 4s", 987654321, 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Twitter");