using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia", imei: "11111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Watsapp");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "123456", modelo: "Nokia", imei: "11111111", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");