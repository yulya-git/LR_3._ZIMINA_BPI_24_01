using System;
using LR_2_ZIMINA_BPI_24_01.Properties;


namespace LR_2_ZIMINA_BPI_24_01
{
    public class Formula_5 : Formula
    {
        public double P { get; set; }  
        public double Y { get; set; }   
        public double N { get; set; }      
        public double K { get; set; }      

        public Formula_5() : base(Resources.FormulaImage5Light, Resources.FormulaImage5Dark, "5") { }

        public override double Calculate()
        {
            double z = 0;
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= K; j++)
                {
                    double numerator = Math.Pow(P, i) * Math.Pow(Y, j);

                    z += numerator / (i * j);
                }
            }
            return z;
        }
    }
}
