// See https://aka.ms/new-console-template for more information

using Lezione2;

Console.WriteLine("inzio del programma");
    Auto auto = new Veicolo(); //equivalente a var veicolo = new Veicolo();
    Console.WriteLine($"ho creato un auto colore {auto.Colore}");
    auto.Colore = "rosso";
    Console.Write($"adesso il colore {auto.Colore}");
    auto.Targa = "ABCD123";
    Console.WriteLine($"e la targa e {auto.Targa}");



