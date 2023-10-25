using desafio.Models;
using DesafioPOO.Models;

// Instanciando os smartphones
Smartphone s1 = new Iphone("(21) 9-8888-8888", "Apple iPhone 14", "352099/06/552077/1", 128);

Console.WriteLine(s1);
s1.Ligar();
s1.ReceberLigacao();
s1.InstalarAplicativo("WhatsApp");
Console.WriteLine("");


Smartphone s2 = new Nokia("(21) 9-9999-9999", "Smartphone Nokia C2", "352099/06/552078/0", 32);
Console.WriteLine(s2);
s2.Ligar();
s2.ReceberLigacao();
s2.InstalarAplicativo("Spotify");
