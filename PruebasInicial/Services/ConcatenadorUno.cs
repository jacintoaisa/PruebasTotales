namespace PruebasInicial.Services
{
    public class ConcatenadorUno : IConcatenador
    {
        public string contatena(string cadena1, string cadena2)
        {
            return cadena1 + cadena2;
        }

        public int diferenciaContaje(string cadena1, string cadena2)
        {
            return cadena1.Length-cadena2.Length;
        }
    }
}
