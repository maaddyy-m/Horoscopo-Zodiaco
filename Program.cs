using System;

class ZodiacCalculator
{
    // Estructura para almacenar la información del signo zodiacal
    public class ZodiacSign
    {
        public string Name { get; set; }
        public string DateRange { get; set; }
        public string[] Characteristics { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    // Array con la información de todos los signos zodiacales
    private static readonly ZodiacSign[] zodiacSigns = new ZodiacSign[]
    {
        new ZodiacSign
        {
            Name = "Aries",
            DateRange = "21 de marzo - 19 de abril",
            Characteristics = new string[]
            {
                "Energético y dinámico",
                "Líder natural",
                "Valiente y decidido",
                "Entusiasta y aventurero"
            },
            StartDate = new DateTime(DateTime.Now.Year, 3, 21),
            EndDate = new DateTime(DateTime.Now.Year, 4, 19)
        },
        new ZodiacSign
        {
            Name = "Tauro",
            DateRange = "20 de abril - 20 de mayo",
            Characteristics = new string[]
            {
                "Paciente y determinado",
                "Práctico y confiable",
                "Dedicado y responsable",
                "Estable y persistente"
            },
            StartDate = new DateTime(DateTime.Now.Year, 4, 20),
            EndDate = new DateTime(DateTime.Now.Year, 5, 20)
        },
        new ZodiacSign
        {
            Name = " Géminis",
            DateRange = "21 de mayo - 20 de junio"
            Characteristics =new string[]
            {

            }
        }
       ///////////////////////////////////////////////////////////////////////////
    };

    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora de Signo Zodiacal");
        Console.WriteLine("=============================");

        DateTime birthDate;
        while (true)
        {
            Console.Write("\nIngrese su fecha de nacimiento (DD/MM/YYYY): ");
            if (DateTime.TryParseExact(Console.ReadLine(), 
                                     "dd/MM/yyyy", 
                                     null, 
                                     System.Globalization.DateTimeStyles.None, 
                                     out birthDate))
            {
                break;
            }
            Console.WriteLine("Formato de fecha inválido. Por favor, use el formato DD/MM/YYYY");
        }

        var sign = GetZodiacSign(birthDate);
        DisplayZodiacInfo(sign);
    }

    private static ZodiacSign GetZodiacSign(DateTime birthDate)
    {
        // Ajustamos la fecha de nacimiento al año actual para comparar solo mes y día
        var compareDate = new DateTime(DateTime.Now.Year, birthDate.Month, birthDate.Day);

        foreach (var sign in zodiacSigns)
        {
            // Caso especial para Capricornio que cruza el año
            if (sign.Name == "Capricornio")
            {
                if (birthDate.Month == 12 || birthDate.Month == 1)
                {
                    return sign;
                }
                continue;
            }

            if (compareDate >= sign.StartDate && compareDate <= sign.EndDate)
            {
                return sign;
            }
        }

        return null; // No debería llegar aquí si los rangos están bien definidos
    }

    private static void DisplayZodiacInfo(ZodiacSign sign)
    {
        if (sign == null)
        {
            Console.WriteLine("No se pudo determinar el signo zodiacal.");
            return;
        }

        Console.WriteLine($"\nTu signo zodiacal es: {sign.Name}");
        Console.WriteLine($"Rango de fechas: {sign.DateRange}");
        Console.WriteLine("\nCaracterísticas principales:");
        foreach (var characteristic in sign.Characteristics)
        {
            Console.WriteLine($"- {characteristic}");
        }
    }
}