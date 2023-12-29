namespace DesafioPOO.Models
{
        // Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
         public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            // Implementação do construtor da classe Nokia, chamando o construtor da classe base
        }
           // Método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} em um Nokia.");
        }
    }
}