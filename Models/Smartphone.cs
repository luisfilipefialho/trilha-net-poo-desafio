namespace DesafioPOO.Models
{
    public abstract class Smartphone(string numero, string modelo, string imei, int memoria)
    {
        public string Numero { get; set; } = numero;
        protected string Modelo { get; set; } = modelo;
        protected string IMEI { get; set; } = imei;
        protected int Memoria { get; set; } = memoria;

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
