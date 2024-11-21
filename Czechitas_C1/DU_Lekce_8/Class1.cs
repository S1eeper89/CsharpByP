using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DU_Lekce_8
{

    public class Kalkulacka
    {
        public double Result;
        public Kalkulacka(double result = 0)
        {
            Result = result;
        }
        public static bool JePlatnyOperator(string vstupOperator)
        {
            if (vstupOperator == "+" || vstupOperator == "-" || vstupOperator == "*" || vstupOperator == "/" || vstupOperator == "^" || vstupOperator.ToLower() == "x")
            {
                return true;
            }
            else return false;
        }
        // ilustracni priklad jednoho reseni
        public void Secti(double druheCislo)
        {
            double prvniCislo = Result;
            Result = prvniCislo + druheCislo;
        }
        // ilustracni priklad jednodussiho reseni
        public void Odecti(double druheCislo)
        {
            Result -= druheCislo;
        }
        public void Nasob(double druheCislo)
        {
            Result *= druheCislo;
        }
        public void Del(double druheCislo)
        {
            Result /= druheCislo;
        }
        public void Umocni(double mocnitel)
        {
            if (mocnitel == 0)
            {
                Result = 1;
            }
            else
            {
                double mocnenec = Result;
                Result = 1;
                for (int i = 1; i <= (int)mocnitel; i++)
                {
                    Result *= mocnenec;
                }
            }
        }
        public double VratAktualniVysledek()
        {
            return Result;
        }
    }
}
