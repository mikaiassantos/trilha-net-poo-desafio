namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
             // Construtor da classe Iphone
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            // Implementação do construtor da classe Iphone, chamando o construtor da classe base
        }
           // Método "InstalarAplicativo"
       public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} em um Iphone.");
        }
    }
}