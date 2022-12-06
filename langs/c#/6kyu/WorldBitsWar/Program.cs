string BitsWar(List<int> numbers)
{
    int quantityOfOneOdd = 0;
    int quantityOfOneEven = 0;

    foreach(var n in numbers)
    {
        string numberinBinary = Convert.ToString(Math.Abs(n), 2);
        int quantityOfOne = numberinBinary.Where(n => n == '1').Count();
        bool isGreatherThanZero = n >= 0;

        if(n % 2 == 0)
        {
            quantityOfOneEven += isGreatherThanZero ? quantityOfOne : -quantityOfOne;
        }
        else
        {
            quantityOfOneOdd += isGreatherThanZero ? quantityOfOne : -quantityOfOne;
        }
    }

    if(quantityOfOneEven > quantityOfOneOdd)
        return "evens win";
    else if(quantityOfOneEven < quantityOfOneOdd)
        return "odds win";
    else
        return "tie";
}
