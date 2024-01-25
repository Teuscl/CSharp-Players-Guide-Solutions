using System.ComponentModel.Design;

Console.Write("Pick the ArrowHead -> Steel, Wood or Obsidian: ");
string ahType = Console.ReadLine();
Console.Write("Pick the ArrowHead -> Plastic, Turkey Feathers or Goose Feathers: ");
string fletching = Console.ReadLine();
Console.Write("Pick the Length -> Between 60cm and 100cm long ");
float length = float.Parse(Console.ReadLine());





Arrow myArrow = new Arrow(ahType, length, fletching);
Console.WriteLine(myArrow.GetCost());
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
enum FletchingType { Plastic, TurkeyFeather, GooseFeathers};

