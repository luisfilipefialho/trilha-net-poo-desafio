using DesafioPOO.Models;

Console.WriteLine("Nokia: ");
Smartphone nokia = new Nokia(numero: "9999-9999", modelo: "Modelo Nokia", imei: "123456789", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Iphone: ");
Smartphone iphone = new Iphone(numero: "1111-1111", modelo: "Modelo Iphone", imei: "987654321", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Twitter");
