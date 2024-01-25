using System.ComponentModel.Design;
int userOption = 0;
bool running = true;

while(running)
{
    Console.WriteLine("Do you want to choose a pre-defined arrow or make your own custom arrow?");
    Console.WriteLine("1- Choose a pre-defined Arrow  2- Make a custom arrow");
    Console.Write("Your option: ");
    userOption = int.Parse(Console.ReadLine());
    if(userOption == 1 || userOption == 2)
        running = false;
}

if(userOption == 1)
{
    Console.Clear();
    int arrowNum = 0;
    Console.WriteLine("Which one do you want: 1- Elite Arrow  2- Beginner Arrow  3- Marksman Arrow");
    arrowNum = int.Parse(Console.ReadLine());

    Arrow preDefineArrow = arrowNum switch
    {
        1 => Arrow.CreateEliteArrow(),
        2 => Arrow.CreateBeginnerArrow(),
        3 => Arrow.CreateMarksmanArrow(),
    };

}
else
{
    Console.Clear();
    Console.Write("Pick the ArrowHead -> Steel, Wood or Obsidian: ");
    string ahType = Console.ReadLine();
    Console.Write("Pick the ArrowHead -> Plastic, Turkey Feathers or Goose Feathers: ");
    string fletching = Console.ReadLine();
    Console.Write("Pick the Length -> Between 60cm and 100cm long ");
    float length = float.Parse(Console.ReadLine());
    Arrow myArrow = new Arrow(ahType, length, fletching);
    Console.WriteLine(myArrow.GetCost());
}


class Arrow
{
    public FletchingType _fletchingType;
    public ArrowHead _arrowHead;
    public float _shaft;
    public float _cost;

    public Arrow(string arrowHead, float length, string fletchingType)
    {

        _arrowHead = arrowHead switch
        {
            "Steel" => ArrowHead.Steel,
            "Wood" => ArrowHead.Wood,
            "Obsidian" => ArrowHead.Obsidian
        };

        _fletchingType = fletchingType switch
        {
            "Plastic" => FletchingType.Plastic,
            "Turkey Feathers" => FletchingType.TurkeyFeather,
            "Goose Feathers" => FletchingType.GooseFeathers
        };

        _shaft = length;
    }
    public static Arrow CreateEliteArrow() => new Arrow("Steel", 95f, "Plastic");
    public static Arrow CreateBeginnerArrow() => new Arrow("Wood",75f, "Goose Feathers");
    public static Arrow CreateMarksmanArrow() => new Arrow("Steel", 65f, "Goose Feathers");

    public float GetCost()
    {
        float arrowHeadCost = _arrowHead switch
        {
            ArrowHead.Steel => 10,
            ArrowHead.Wood => 3,
            ArrowHead.Obsidian => 5
        };

        float fletchingCost = _fletchingType switch
        {
            FletchingType.Plastic => 10,
            FletchingType.TurkeyFeather => 5,
            FletchingType.GooseFeathers => 3
        };
        float lengthCost = 0.05f * _shaft;
        return arrowHeadCost + fletchingCost + lengthCost;
    }

}


enum ArrowHead { Steel, Wood, Obsidian };
enum FletchingType { Plastic, TurkeyFeather, GooseFeathers };

