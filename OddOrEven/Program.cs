
Console.WriteLine("Sisesta number:");
int userNum = Convert.ToInt32(Console.ReadLine());

// Kas kasutaja arv on paaris või paaritu

int result = userNum % 2;

//Console.WriteLine(result);

if(result !=0) // != - ei ole võrdne
{
    Console.WriteLine("Number on paaritu.");
}
else
{
    Console.WriteLine("Number on paaris");
}