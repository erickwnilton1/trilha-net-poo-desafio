namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, int modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){}

        public override void InstalarAplicativo(string nomeApp)
        {
            string Message = $"Instalando o aplicativo \"{nomeApp}\" no Nokia";
            Console.WriteLine(Message);
        }

    }
}