//Switch kasutamine - võimalus väärtust kontrollida . Switch sobib selleks, et kontrollida ainult ühte väärtust 

using System;

int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

switch (weekDay)   // weekday on siin väärtus mida kontrollitakse ja ainult üks väärtus, ei saa kontorllida veeel komasid jne.
{
    case 0:   // case 0: in tegelikult sama mis if (weekday==0)
        Console.WriteLine("It is Sunday");
        break;  // lõpetab switchi töö 
    case 1:
        Console.WriteLine("Esmaspäev");
        break;
    case 2:
        Console.WriteLine("Teisipäev");
        break;
    case 3:
        Console.WriteLine("Kolmapäev");
        break;
    case 4:
        Console.WriteLine("Neljapäev");
        break;
    case 5:
        Console.WriteLine("reede");
        break;
    case 6:
        Console.WriteLine("laupäev");
        break;  
        default:
        Console.WriteLine("Oops, your calendar must be broken");
        break;
}

Console.WriteLine("Have a nice day!");