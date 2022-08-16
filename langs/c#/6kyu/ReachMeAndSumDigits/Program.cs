Console.WriteLine(SumDigNthTerm(10, new long[] {2, 1, 3}, 6));
Console.WriteLine(SumDigNthTerm(10, new long[] {1, 2, 3}, 15));

static long SumDigNthTerm(long initval, long[] patternl, int nthterm) 
{
    long nthNumber = initval;
    nthNumber += patternl.Sum() * ((nthterm - 1) / patternl.Length);
    nthNumber += patternl.Where((value, ind) => {
        if(ind < (nthterm - 1) % patternl.Length)
            return true;
        return false;
    }).Sum();

    return SumDigits(nthNumber);
}

static long SumDigits(long number)
{
    return number.ToString().Sum(val => Convert.ToInt64(val.ToString()));
}