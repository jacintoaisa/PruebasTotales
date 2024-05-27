namespace PruebasInicial.Services
{
    public class MultiplosYDivisoresUno : IMultiplosyDivisores
    {
        public int MaximoComunDivisor(int val1, int val2)
        {
            int mcd = 0;
            int a = Math.Max(val1, val2);
            int b = Math.Min(val1, val2);
            do
            {
                mcd = b;
                b = a % b;
                a = mcd;
            } while (b != 0);
           return mcd;
        }

        public int MinimoComunMultiplo(int num1, int num2)
        {
            int a = Math.Max(num1, num2);
            int b = Math.Min(num1, num2);
            int mcm = (a / this.MaximoComunDivisor(num1, num2)) * b;
            return mcm;
        }
    }
}

