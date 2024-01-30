// See https://aka.ms/new-console-template for more information
using clase2;

public class xd 
{
    public static void Main(string[] args) 
    {
        principal o = new principal();
        int alm ,sal , i=0 , ap=0 , rp =0;
        double[] n1; double[] n2; double[] n3; double[] n4; double[] totl ;
        n1 = new double[40];
        n2 = new double[40];
        n3 = new double[40];
        n4 = new double[40];
        totl = new double[40];

        do
        {

            do
            {
                alm = o.validar("Digite la cantidad de estudiantes:  ");
                

            } while (alm <= 0 || alm > 40);

            for (i = 0; i < alm; i++)
            {
                
                Console.WriteLine("Notas del estudiante #"+ (1 + i));

                do 
                {
                    n1[i] = o.validar("Valor de la nota 1 :");
                    o.punt1(n1);
                }while (n1[i] < 0 || n1[i] > 25);

                do
                {
                    n2[i] = o.validar("Valor de la nota 2 :");
                    o.punt2(n2);
                } while (n2[i] < 0 || n2[i] > 25);

                do
                {
                    n3[i] = o.validar("Valor de la nota 3 :");
                    o.punt3(n3);
                } while (n3[i] < 0 || n3[i] > 25);

                do
                {
                    n4[i] = o.validar("Valor de la nota 4 :");
                    o.punt4(n4);
                } while (n4[i] < 0 || n4[i] > 25);

                Console.WriteLine("-------------------------------///");
                   

            }
            for(i = 0;i < alm; i++) 
            {
                totl[i] = n1[i] + n2[i] + n3[i] + n4[i];
            }
            for (i = 0; i < alm; i++)
            {
                if (totl[i] >= 60)
                {
                    Console.WriteLine("El estudiante #" + (1 + i) + " Aprobo " + " Nota: " + totl[i]);
                    ap++;
                }
                else
                {
                    Console.WriteLine("El estudiante #" + (1 + i) + " Reprobo " + " Nota: " + totl[i]);
                    rp++;
                }

                Console.WriteLine("------------------------------------------//");

               
            }
            Console.WriteLine("Aprobados: " + ap);
            Console.WriteLine("Reprobados: " + rp);
            do
            {
                sal = o.validar("Desea seguir en el programa? 1.Si 2.No" + "\t");

            } while (sal <= 0 || sal > 2);

        } while(sal == 1);
        Console.WriteLine("Buen dia :)");

    }
}

