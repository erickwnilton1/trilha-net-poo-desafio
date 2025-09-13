using DesafioPOO.Models;

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "9876", modelo: 8, imei: "3453752", memoria: 264);
nokia.Ligar();
nokia.InstalarAplicativo("github");

Console.WriteLine("Iphone:");
Smartphone iphone = new Iphone(numero: "9876", modelo: 16, imei: "3453752", memoria: 264);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");