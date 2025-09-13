namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, int modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){}

        public override void InstalarAplicativo(string nomeApp)
        {
            string Message = $"Instalando o aplicativo \"{nomeApp}\" no Iphone";
            Console.WriteLine(Message);
        }
    }
}