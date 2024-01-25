void showStatus(int city,int manticore,int round)
{
    
    Console.WriteLine("-----------------------------------------------------------");
    Console.WriteLine($"STATUS: Round: {round}  City: {city}/15  Manticore: {manticore}/10 ");    
}

int computeDamage(int round)
{
    Console.WriteLine($"DEBUG: ROUND= {round}");
    if (round % 3 == 0 && round % 5 == 0)
    {
        return 10;
    }
    else if (round % 3 == 0 || round % 5 == 0)
    {
        return 3;
    }
    else return 1;   
}

bool checkIfHits(int distance, int cannonRange)
{
    if (cannonRange == distance)
    {
        Console.WriteLine("That round was a DIRECT HIT");
        return true;

    }else if (cannonRange > distance){
        Console.WriteLine("That round OVERSHOT the target");
        return false;

    }else {
        Console.WriteLine("That round FELL SHORT of the target");
        return false;
    }
}


int city = 15, manticore = 10, round = 1;
int distance, cannonRange, computedDamage;
bool hit;

Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
distance = int.Parse(Console.ReadLine());
Console.Clear();

Console.WriteLine("Player 2, it is your turn.");

while(city>0 && manticore>0)
{
    showStatus(city, manticore, round);
    computedDamage = computeDamage(round);

    Console.WriteLine($"The cannon is expected to deal {computedDamage} damage this round.");   
    Console.Write("Enter desired cannong range: ");
    cannonRange = int.Parse(Console.ReadLine());

    hit = checkIfHits(distance, cannonRange);
    if(hit)
    {
        manticore -= computedDamage;

        if(manticore > 0)
        {
            city -= 1;
        }
    }
    else { city -= 1; }
    round++;
}

if (manticore <= 0)
{
    Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
}
else
{
    Console.WriteLine("The City has been destroyed!");
}