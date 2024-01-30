using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace clase2
{
    internal class principal
    {
        private double[] nota = new double[40];
        private double[] nota2 = new double[40];
        private double[] nota3 = new double[40];
        private double[] nota4 = new double[40];

        public principal() { }
        public principal(double[] Nota, double[] Nota2, double[] Nota3 , double[] Nota4)
        {
            nota = Nota; nota2 = Nota2; nota3 = Nota3; nota4 = Nota4;
        }
        public void punt1(double[] Nota)
        {
            this.nota = Nota;
        }

        public void punt2(double[] Nota2)
        {
            this.nota2 = Nota2;
        }

        public void punt3(double[] Nota3)
        {
            this.nota3 = Nota3;
        }

        public void punt4(double[] Nota4)
        {
            this.nota4 = Nota4;
        }

        public int validar(String Mensaje)
        {
            int num = 0, v;
            do
            {
                v = 1;
                try
                {
                    Console.Write(Mensaje);
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    v = 0;
                    Console.WriteLine("No se aceptan letras", error.Message);
                }
            } while (v == 0);
            return num;
        }
    }
}
