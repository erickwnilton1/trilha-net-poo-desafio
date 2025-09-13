using DesafioPOO.Models;

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "9876", modelo: 8, imei: "3453752", memoria: 264);
nokia.Ligar();
nokia.InstalarAplicativo("github");