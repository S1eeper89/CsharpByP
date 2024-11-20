using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DU_Lekce_7
{

    public class Kalkulacka
    {
        public double Result;
        public Kalkulacka(double result = 0)
        {
            Result = result;
        }
        public bool JePlatnyOperator(string vstupOperator)
        {
            if (vstupOperator == "+" || vstupOperator == "-" || vstupOperator == "*" || vstupOperator == "/" || vstupOperator == "^")
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
        public void Odecti(double prvniCislo)
        {
            Result -= prvniCislo;
        }
        public void Nasob(double prvniCislo)
        {
            Result *= prvniCislo;
        }
        public void Del(double prvniCislo)
        {
            Result /= prvniCislo;
        }
        public void Umocni(double prvniCislo)
        {
            if (prvniCislo == 0)
            {
                Result = 1;
            }
            else
            {
                Result = 1;
                for (int i = 1; i <= (int)prvniCislo; i++)
                {
                    Result *= prvniCislo;
                }
            }
        }
        public double VratAktualniVysledek()
        {
            return Result;
        }
    }
}