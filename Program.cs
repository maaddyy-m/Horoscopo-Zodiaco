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
                "𝗣𝗼𝘀𝗶𝘁𝗶𝘃𝗼:",
                "Energético y dinámico",
                "Líder y natural",
                "Valiente y decidido",
                "Entusiasta y aventurero",

                "𝗡𝗲𝗴𝗮𝘁𝗶𝘃𝗼:",
                "Impulsividad y falta de paciencia",
                "Se arriesga demasiado",
                "No soportan equivocarse ni el fracasar",

                "𝗖𝗼𝗺𝗽𝗮𝘁𝗶𝗯𝗶𝗹𝗶𝗱𝗮𝗱:",
                "Sus signos compatibles son Cancer y Piscis",
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
                "𝗣𝗼𝘀𝗶𝘁𝗶𝘃𝗼:",
                "Paciente y determinado",
                "Práctico y confiable",
                "Dedicado y responsable",
                "Estable y persistente",

                "𝗡𝗲𝗴𝗮𝘁𝗶𝘃𝗼:",
                "La terquedad y la posesividad",
                 "El materialismo, la pereza y la resistencia al cambio",

                "𝗖𝗼𝗺𝗽𝗮𝘁𝗶𝗯𝗶𝗹𝗶𝗱𝗮𝗱:",
                "Sus signos compatibles son Capricornio y Virgo",

            },
            StartDate = new DateTime(DateTime.Now.Year, 4, 20),
            EndDate = new DateTime(DateTime.Now.Year, 5, 20)
        },
        new ZodiacSign
        {

            Name = " Géminis",
            DateRange = "21 de mayo - 20 de junio",
            Characteristics =new string[]
            {
                "𝗣𝗼𝘀𝗶𝘁𝗶𝘃𝗼:",
                "Simpatía y curiosidad", 
                "comunicación y flexibilidad",

                "𝗡𝗲𝗴𝗮𝘁𝗶𝘃𝗼:",
                "Suelen ser falsos y dobles",
                "Caprichosos y distraidos",

                "𝗖𝗼𝗺𝗽𝗮𝘁𝗶𝗯𝗶𝗹𝗶𝗱𝗮𝗱:",
                "Sus signos compatibles son Libra y Acuario",
            },
            StartDate = new DateTime(DateTime.Now.Year, 5, 21),
            EndDate = new DateTime(DateTime.Now.Year, 6, 20)
        },
        new ZodiacSign
        {
            Name = "Cancer",
            DateRange = "21 de junio - 22 de julio",
            Characteristics = new string[]
            {
                "𝗣𝗼𝘀𝗶𝘁𝗶𝘃𝗼:",
                "Lealtad y sensibilidad", 
                "empatía y memoria",

                "𝗡𝗲𝗴𝗮𝘁𝗶𝘃𝗼:",
                "Hipersensibilidad.",
                "Desordenados y acumulación",
                "Suelen ser compulsivos y tienen mucho rencor.",

                "𝗖𝗼𝗺𝗽𝗮𝘁𝗶𝗯𝗶𝗹𝗶𝗱𝗮𝗱:",
                "Sus signos compatibles son Piscis y Escorpio",

            },
            StartDate = new DateTime(DateTime.Now.Year, 6, 21),
            EndDate = new DateTime(DateTime.Now.Year, 7, 22)
        },
        new ZodiacSign
        {
            Name = "Leo",
            DateRange = "23 de julio - 22 de agosto",
            Characteristics = new string[]
            {
                "𝗣𝗼𝘀𝗶𝘁𝗶𝘃𝗼:",
                "Confianza y generosidad", 
                "creatividad y carisma",

                "𝗡𝗲𝗴𝗮𝘁𝗶𝘃𝗼:",
                "Son Egocentricos y impaciencientes",
               "Arrogancia y tendencia a la infidelid",

                "𝗖𝗼𝗺𝗽𝗮𝘁𝗶𝗯𝗶𝗹𝗶𝗱𝗮𝗱:",
                "Sus signos compatibles son Aries y Sagitario"
            },
            StartDate = new DateTime(DateTime.Now.Year, 7, 23),
            EndDate = new DateTime(DateTime.Now.Year, 8, 22)
        },
         new ZodiacSign
        {
            Name = "Virgo",
            DateRange = "23 de agosto - 22 de septiembre",
            Characteristics = new string[]
            {
                "𝗣𝗼𝘀𝗶𝘁𝗶𝘃𝗼:",
                "Perfeccionismo y análisis",
                "servicio y atención al detalle",

                "𝗡𝗲𝗴𝗮𝘁𝗶𝘃𝗼:",
                "Perfeccionismo y obsesión por el orden",
                 "Humor negroy terror a enfermarse.",

                "𝗖𝗼𝗺𝗽𝗮𝘁𝗶𝗯𝗶𝗹𝗶𝗱𝗮𝗱:",
                "Sus signos compatibles son Tauro y Capricornio"
            },
            StartDate = new DateTime(DateTime.Now.Year, 8, 23),
            EndDate = new DateTime(DateTime.Now.Year, 9, 22)
        },
        new ZodiacSign
        {
            Name = "Libra",
            DateRange = "23 de septiembre - 22 de octubre",
            Characteristics = new string[]
            {
                "𝗣𝗼𝘀𝗶𝘁𝗶𝘃𝗼:",
                "Equilibrio y armonía", 
                "justicia y diplomacia",

                "𝗡𝗲𝗴𝗮𝘁𝗶𝘃𝗼:",
                "Influenciables y dependientes emocionales",
                "Indecisión e hipocresía",

                "𝗖𝗼𝗺𝗽𝗮𝘁𝗶𝗯𝗶𝗹𝗶𝗱𝗮𝗱:",
                "Sus signos compatibles son Géminis, Acuario, Leo y Sagitario"
            },
            StartDate = new DateTime(DateTime.Now.Year, 9, 23),
            EndDate = new DateTime(DateTime.Now.Year, 10, 22)
        },
        new ZodiacSign
        {
            Name = "Escorpio",
            DateRange = "23 de octubre - 21 de noviembre",
            Characteristics = new string[]
            {
                "𝗣𝗼𝘀𝗶𝘁𝗶𝘃𝗼:",
                "Pasión y intensidad", 
                "Misterioso y transformador",

                "𝗡𝗲𝗴𝗮𝘁𝗶𝘃𝗼:",
                "la agresión, los celos y el resentimiento.",

                "𝗖𝗼𝗺𝗽𝗮𝘁𝗶𝗯𝗶𝗹𝗶𝗱𝗮𝗱:",
                "Sus signos compatibles son Cáncer y Piscis",

            },
            StartDate = new DateTime(DateTime.Now.Year, 10, 23),
            EndDate = new DateTime(DateTime.Now.Year, 11, 21)
        },
        new ZodiacSign
        {
            Name = "Sagitario",
            DateRange = "22 de noviembre - 21 de diciembre",
            Characteristics = new string[]
            {
                "𝗣𝗼𝘀𝗶𝘁𝗶𝘃𝗼:",
                "Optimismo y aventura", 
                "filosofía y independencia",

                "𝗡𝗲𝗴𝗮𝘁𝗶𝘃𝗼:",
                " Son intensos y les gusta el sarcasmo",
                "Tendencia a ser inpulsivos e impasientes",

                "𝗖𝗼𝗺𝗽𝗮𝘁𝗶𝗯𝗶𝗹𝗶𝗱𝗮𝗱:",
                ""
            },
            StartDate = new DateTime(DateTime.Now.Year, 11, 22),
            EndDate = new DateTime(DateTime.Now.Year, 12, 21)
        },
        new ZodiacSign
        {
            Name = "Capricornio",
            DateRange = "22 de diciembre - 19 de enero",
            Characteristics = new string[]
            {
                "𝗣𝗼𝘀𝗶𝘁𝗶𝘃𝗼:",
                "Disciplina y ambición",
                "responsabilidad y determinación",

                "𝗡𝗲𝗴𝗮𝘁𝗶𝘃𝗼:",

                "𝗖𝗼𝗺𝗽𝗮𝘁𝗶𝗯𝗶𝗹𝗶𝗱𝗮𝗱:",

            },
            StartDate = new DateTime(DateTime.Now.Year, 12, 22),
            EndDate = new DateTime(DateTime.Now.Year,1, 19),
        },
        new ZodiacSign
        {
            Name = "Acuario",
            DateRange = "20 de enero - 18 de febrero",
            Characteristics = new string[]
            {
                "𝗣𝗼𝘀𝗶𝘁𝗶𝘃𝗼:",
                "Innovación y independencia",
                "originalidad y humanidad",

                "𝗡𝗲𝗴𝗮𝘁𝗶𝘃𝗼:",

                "𝗖𝗼𝗺𝗽𝗮𝘁𝗶𝗯𝗶𝗹𝗶𝗱𝗮𝗱:",
            },
            StartDate = new DateTime(DateTime.Now.Year, 1, 20),
            EndDate = new DateTime(DateTime.Now.Year, 2, 18)
        },
        new ZodiacSign
        {
            Name = "Piscis",
            DateRange = "19 de febrero - 20 de marzo ",
            Characteristics = new string[]
            {
                "𝗣𝗼𝘀𝗶𝘁𝗶𝘃𝗼:",
                "Intuición y creatividad",
                "compasión y sueño",
                "Amorosa y llorones",

                "𝗡𝗲𝗴𝗮𝘁𝗶𝘃𝗼:"
            },
            StartDate = new DateTime(DateTime.Now.Year, 2, 19),
            EndDate = new DateTime(DateTime.Now.Year, 3, 20)
        },
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