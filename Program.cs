using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "908645", modelo: "Nokia G60 5G", imei: "001970-01-010000-0", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("TikTok");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "897658", modelo: "Iphone XR", imei: "006720-08-098214-0", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

nokia = new Nokia("654321", "Nokia 3310", "008906-04-090876-0", 32);
string App = "Telegram";
    // Act
nokia.InstalarAplicativo(App);

Console.WriteLine("\n");

iphone = new Iphone("123456", "iPhone 15 Pro Max", "008745-09-095643-0", 520);
string nomeApp = "Pinterst";
    // Act
iphone.InstalarAplicativo(nomeApp);


