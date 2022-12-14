double GetVar(string VarName)
{
    Console.Write($"{VarName} = ");
    return Convert.ToDouble(Console.ReadLine());    
}

string GetIntersection(double b1, double k1, double b2, double k2)
{
    
    if (b1 == b2 && k1 == k2)
        return $"The lines match";
    if (k1 == k2)
        return $"The lines are parallel";
    else
    {    
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        return $"({x}; {y})";
    }
}

Console.WriteLine(GetIntersection(GetVar("b1"), GetVar("k1"), GetVar("b2"), GetVar("k2")));