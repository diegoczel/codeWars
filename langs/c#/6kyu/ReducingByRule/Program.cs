Func<double, double, double>[] rules = new Func<double, double, double>[] 
{ 
    (a, b) => a + b,
    (a, b) => a - b
};

Console.WriteLine($"{ReduceByRules(new[] { 2.0, 2.0, 3.0, 4.0 }, rules)} - {5}");
rules = new Func<double, double, double>[] { (a, b) => a + b };
Console.WriteLine($"{ReduceByRules(new[] { 2.0, 2.0, 2.0 }, rules)} - {6}");
Console.WriteLine($"{ReduceByRules(new[] { 2.0, 2.0, 2.0, 2.0 }, rules)} - {8}");
Console.WriteLine($"{ReduceByRules(new[] { 2.0, 2.0, 2.0, 2.0, 2.0 }, rules)} - {10}");
Console.WriteLine($"{ReduceByRules(new[] { 2.0, 2.0, 2.0, 2.0, 2.0, 2.0 }, rules)} - {12}");
static double ReduceByRules(double[] numbers, Func<double, double, double>[] rules)
{
    int indexOfRules = 0;
    double result = rules[0](numbers[0], numbers[1]);

    if(numbers.Length < 3) return result;

    for(int ind = 2; ind < numbers.Length; ind++)
    {
        if(indexOfRules < rules.Length - 1) indexOfRules++;
        else indexOfRules = 0;

        result = rules[indexOfRules](result, numbers[ind]);
    }

    return result;
}