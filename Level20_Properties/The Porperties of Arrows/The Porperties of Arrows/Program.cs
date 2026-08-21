Console.WriteLine("Arrow Making");

arrowMake();

void arrowMake()
{
    Arrowhead arrow = GetArrowType();
    Fletching fletch = GetFletchType();
    float arrowlength = GetArrowLength();
    float arrowcost = GetCost(arrow, fletch, arrowlength);
    Console.WriteLine($"The total arrow cost is {arrowcost}");
}

//Console.WriteLine(arrow);

Arrowhead GetArrowType()
{
    Arrowhead arrowtype;
    Console.WriteLine("Select your arrowhead: ");
    Console.WriteLine("1. Steel");
    Console.WriteLine("2. Wood");
    Console.WriteLine("3. Obsidian");

    // user selection
    int user = Convert.ToInt32(Console.ReadLine());
    switch (user)
    {
        case 1:
            Console.WriteLine("Selected steel option");
            return arrowtype = Arrowhead.steel;
        case 2:
            Console.WriteLine("Selected wood option");
            return arrowtype = Arrowhead.wood;
        case 3:
            Console.WriteLine("Selected obsidian option");
            return arrowtype = Arrowhead.obsidian;
        default:
            Console.WriteLine("Default option is steel");
            return arrowtype = Arrowhead.steel;
    }
    ;
}

Fletching GetFletchType()
{
    Fletching fletchtype;
    Console.WriteLine("Select your fletching: ");
    Console.WriteLine("1. Plastic");
    Console.WriteLine("2. Turkey Feathers");
    Console.WriteLine("3. Goose Feathers");

    int user = Convert.ToInt32(Console.ReadLine());
    switch (user)
    {
        case 1:
            Console.WriteLine("Selected plastic fletching option");
            return fletchtype = Fletching.plastic;
        case 2:
            Console.WriteLine("Selected turkey feathers fletching option");
            return fletchtype = Fletching.turkeyfeathers;
        case 3:
            Console.WriteLine("Selected goose feathers fletching option");
            return fletchtype = Fletching.goosefeathers;
        default:
            Console.WriteLine("Default option is plastic flecthing");
            return fletchtype = Fletching.plastic;
    }
    ;
}

float GetArrowLength()
{
    Console.WriteLine("Select arrow length between 60 to 100: ");
    float user = Convert.ToSingle(Console.ReadLine());
    float arrowlength = user;
    return arrowlength;
}

float GetCost(Arrowhead arrow, Fletching fletch, float length)
{
    Arrow arrow1 = new Arrow(arrow, fletch, length);
    Console.WriteLine($"Your arrow is {arrow1.GetArrType} type, {arrow1.GetFleType} fletching, {arrow1.GetArrLength}cm");
    float total = arrow1.GetCost();
    return total;
}
// Object 1
//Arrow arrow1 = new Arrow(Arrowhead.steel, 60, 100);
//Console.WriteLine($"ArrowType: { arrow1.aHead}, Length: {arrow1.length}cm, Cost: {arrow1.cost} gold");


// Blueprint to make arrows
// Build a class to represent arrow and price of the arrows
class Arrow
{
    private Arrowhead aHead;
    private Fletching fletch;
    private float length; // 60cm to 100cm

    public Arrowhead GetArrType
    {
        get => aHead;
        set;
    } 
    public Fletching GetFleType
    {
        get => fletch;
        set;
    } 
    public float GetArrLength
    {
        get => length;
        set;
    } 

    // Constructor
    public Arrow(Arrowhead _arrow, Fletching _fletch, float _length)
    {
        aHead = _arrow;
        fletch = _fletch;
        length = _length;
    }

    public float GetCost()
    {
        float ArrCost = aHead switch
        {
            Arrowhead.steel => 10,
            Arrowhead.wood => 3,
            Arrowhead.obsidian => 5,
            _ => 10
        };

        float FleCost = fletch switch
        {
            Fletching.plastic => 10,
            Fletching.turkeyfeathers => 5,
            Fletching.goosefeathers => 3,
            _ => 10
        };

        float LengthCost = (float)(length * 0.05);

        return ArrCost + FleCost + LengthCost;
    }
}

enum Arrowhead { steel, wood, obsidian } // 10g, 3g, 5g
enum Fletching { plastic, turkeyfeathers, goosefeathers }// 10g, 5g, 3g