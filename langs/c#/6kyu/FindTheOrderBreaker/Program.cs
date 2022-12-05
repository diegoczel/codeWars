//Console.WriteLine(OrderBreaker());
Console.WriteLine(OrderBreaker(new int[] { 1, 2, 0, 3, 4 }));//0
Console.WriteLine(OrderBreaker(new int[] { 1, 2, 3, 4, -1 })); //-1
Console.WriteLine(OrderBreaker(new int[] { 1, 3, 2 }));

int OrderBreaker(int[] input)
{
    if(input[0] > input[1])
        return input[0];

    for(int i = 1; i < input.Length - 1; i++)
    {
        if(input[i] < input[i - 1])
        {
            return input[i];
        }    
        else if(input[i] > input[i + 1] && input[i + 1] < input[i - 1])
        {
            return input[i + 1];
        }
        else if(input[i] > input[i + 1] && input[i + 1] > input[i - 1])
        {
            return input[i];
        }
    }

    return 0;
}