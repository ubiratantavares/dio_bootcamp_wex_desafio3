using DesafioPOO.Models;

namespace desafio.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone.");
        }

        public override string ToString()
        {
            return $"Iphone(Numero: {Numero}, Modelo: {Modelo}, IMEI: {IMEI}, Memória: {Memoria} GB)";
        }
    }
}