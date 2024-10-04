namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string modelo, string numero, string imei, int memoria ) : base(modelo, numero, imei, memoria){
            
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone.");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}