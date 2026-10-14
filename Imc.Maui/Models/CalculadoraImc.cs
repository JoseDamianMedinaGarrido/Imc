using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Imc.Maui.Models
{
    public static class CalculadoraImc
    {
        public static decimal IndiceDeMasaCorporal(
            decimal peso, 
           decimal estatura)
           => peso / (estatura * estatura);
    

    public static string EstadoNutricional(decimal imc)
        {
            if (imc < 18.5m)
            {
                return "Peso bajo";
            }
            if (imc < 25.0m)
            {
                return "Peso Normal";
            }
            if (imc < 30.0m)
            {
                return "Sobrepeso";
            }
            if (imc < 40.0m)
            {
                return "obesidad";
            }
            return "Obesidad Extrema";
        }
    }
}

