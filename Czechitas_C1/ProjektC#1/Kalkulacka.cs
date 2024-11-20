﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjektC_1
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
                double umocniVysledek = Result;
                Result = 1;
                for (int i = 1; i <= (int)prvniCislo; i++)
                {
                    Result *= umocniVysledek;
                }
            }
        }
        public double VratAktualniVysledek()
        {
            return Result;
        }
    }
}
