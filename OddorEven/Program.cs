using System.ComponentModel.Design;

Console.WriteLine("Enter a number");
int userNum = Convert.ToInt32(Console.ReadLine());  // sama nagu tryparse mida week 2 tegime. ehk int võtab numbreid ja conventeerib siis numbriks 

// kontrollime kas kasutaja arv on paaris või paaritu

int result = userNum % 2;

// Console.WriteLine(result); //kui tulemus on paaris, siis resulti väärtus on 0. 

if (result != 0)   // == siis kas on võrdsed, või kui != siis ei ole võrdne
{

    Console.WriteLine("User number ist odd ehk paaritu");
}    else

{
    Console.WriteLine("User number is even ehk paaris");

}