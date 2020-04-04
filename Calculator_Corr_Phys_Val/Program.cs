using System;

namespace Calculator_Corr_Phys_Val
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            Console.Clear();
            double Mphys, Mcorr, Nphys, Ncorr, Tstd, Pstd, T0, P0;
            Console.WriteLine("1 - Corrected Mass Flow\n2 - Physical Mass Flow\n3 - Corrected Speed\n4 - Physical speed");

            Tstd = 288.15;
            Pstd = 101325;

            Console.WriteLine("\nPstd [Pa]: " + Pstd);
            Console.WriteLine("Tstd [K]: " + Tstd);

            Console.Write("\nEnter a number of calculate variable: ");
            int calcNumber = Convert.ToInt32(Console.ReadLine());


            if (calcNumber == 1)
            {
                Console.Write("\nEnter Inlet Total Pressure [Pa]: ");
                P0 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Inlet Total Temperaturte [K]: ");
                T0 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Mass Flow Physical [kg/s]: ");
                Mphys = Convert.ToDouble(Console.ReadLine());

                Mcorr = Mphys * (Math.Sqrt(T0 / Tstd) / (P0 / Pstd));
                Console.WriteLine("\nMass Flow Corrected [kg/s]: " + Mcorr);
            }
            else if (calcNumber == 2)
            {
                Console.Write("\nEnter Inlet Total Pressure [Pa]: ");
                P0 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Inlet Total Temperaturte [K]: ");
                T0 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Mass Flow Corrected [kg/s]: ");
                Mcorr = Convert.ToDouble(Console.ReadLine());

                Mphys = Mcorr * ((P0 / Pstd) / Math.Sqrt(T0 / Tstd));
                Console.WriteLine("\nMass Flow Physical [kg/s]: " + Mphys);
            }
            else if (calcNumber == 3)
            {

                Console.Write("Enter Inlet Total Temperaturte [K]: ");
                T0 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Physical Speed [rpm]: ");
                Nphys = Convert.ToDouble(Console.ReadLine());

                Ncorr = Nphys / Math.Sqrt(T0 / Tstd);
                Console.WriteLine("\nCorrected Speed [rpm]: " + Ncorr);
            }
            else if (calcNumber == 4)
            {

                Console.Write("Enter Inlet Total Temperaturte [K]: ");
                T0 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Corrected Speed [rpm]: ");
                Ncorr = Convert.ToDouble(Console.ReadLine());

                Nphys = Ncorr * Math.Sqrt(T0 / Tstd);
                Console.WriteLine("\nPhysical Speed [rpm]: " + Nphys);
            }
            else

                Console.WriteLine("\nEnter number coresponding to list above [1, 2, 3, 4]\nPress any key to restart");
            Console.ReadLine();
            goto Start;

        }
        static void P1t()
        {
            double P0;
            
        }

                
    }
}
