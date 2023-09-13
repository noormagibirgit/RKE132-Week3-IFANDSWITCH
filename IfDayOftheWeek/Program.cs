// proovime tuvastada mis nädalapäev täna´on . arvutis on pühapäev 0,  esmspäev 1, teisipäev 2 , kolmap. 3 jne. kuni laup 6 

using System;

int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);  // pakubki 0 - 6 ni . 

if(weekDay == 0 )
{
    Console.WriteLine("See on pühapäev");
}
else if(weekDay == 1 )
{
    Console.WriteLine("See on esmaspäev");
}
else if (weekDay == 2 )
{
    Console.WriteLine("See on teisipäev");
}
else if (weekDay == 3 )
{
    Console.WriteLine("See on kolmapäev");
}
else if(weekDay == 4 )
{
    Console.WriteLine("See on neljapäev");
}
else if (weekDay == 5 )
{
    Console.WriteLine("See on reede");
}
else  
{
    Console.WriteLine("See on laupäev");
}
Console.WriteLine("Ilusat päeva!");