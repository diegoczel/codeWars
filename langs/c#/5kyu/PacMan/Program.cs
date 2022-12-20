/*

PacMan(
    10, 
    new int[] {4, 6}, 
    new int[][] {
        new int[] {0, 2}
    }
);

PacMan(
    10, 
    new int[] {4, 6}, 
    new int[][] {
        new int[] {5, 2}
    }
);

PacMan(
    10, 
    new int[] {4, 6}, 
    new int[][] {
        new int[] {5, 5}
    }
);
*/

/*
PacMan(
    2, 
    new int[] {0, 0}, 
    new int[][] {}
);

PacMan(
    10, 
    new int[] {4, 6}, 
    new int[][] {
        new int[] {0, 2},
        new int[] {5, 2},
        new int[] {5, 5}
    }
);
Console.WriteLine();

PacMan(
    4, 
    new int[] {0, 1}, 
    new int[][] {
        new int[] {1, 2}
    }
);
Console.WriteLine();

PacMan(
    4, 
    new int[] {3, 0}, 
    new int[][] {
        new int[] {1, 2}
    }
);
Console.WriteLine();

PacMan(
    4, 
    new int[] {0, 3}, 
    new int[][] {
        new int[] {1, 2}
    }
);
Console.WriteLine();

PacMan(
    4, 
    new int[] {3, 3}, 
    new int[][] {
        new int[] {1, 2}
    }
);
Console.WriteLine();

PacMan(
    15, 
    new int[] {0, 13}, 
    new int[][] {
        new int[] {14, 8},
        new int[] {3, 1}
    }
);
Console.WriteLine();

PacMan(
    9, 
    new int[] {3, 5}, 
    new int[][] {
        new int[] {5, 4},
        new int[] {6, 7},
        new int[] {6, 2},
        new int[] {4, 6},
        new int[] {0, 1}
    }
);
Console.WriteLine();

PacMan(
    11, 
    new int[] {7, 9}, 
    new int[][] {
        new int[] {6, 7},
        new int[] {4, 8}
    }
);
Console.WriteLine();

PacMan(
    4, 
    new int[] {2, 3}, 
    new int[][] {
        new int[] {3, 2},
        new int[] {3, 1}
    }
);
Console.WriteLine();
*/
Console.WriteLine("rowMin == rowMax && colMin == colMax | Expected 14");
PacMan(
    16, 
    new int[] {1, 15}, 
    new int[][] {
        new int[] {3, 0},
        new int[] {8, 8},
        new int[] {6, 7},
        new int[] {9, 10}
    }
);
Console.WriteLine();

Console.WriteLine("rowMin == rowMax && colMin == colMax | Expected 41");
PacMan(
    12, 
    new int[] {6, 11}, 
    new int[][] {
        new int[] {1, 4},
        new int[] {0, 3},
        new int[] {5, 4},
        new int[] {4, 2}
    }
);
Console.WriteLine();

Console.WriteLine("rowMin == rowMax && colMin < colMax | Expected 95");
PacMan(
    15, 
    new int[] {6, 10}, 
    new int[][] {
        new int[] {2, 2},
        new int[] {1, 11}
    }
);
Console.WriteLine();

Console.WriteLine("rowMin < rowMax && colMin == colMax | Expected 5");
PacMan(
    17, 
    new int[] {2, 3}, 
    new int[][] {
        new int[] {3, 6},
        new int[] {9, 10},
        new int[] {1, 15},
        new int[] {10, 6},
        new int[] {3, 16}
    }
);
Console.WriteLine();

Console.WriteLine("rowMin < rowMax && colMin == colMax | Expected 15");
PacMan(
    10, 
    new int[] {4, 6}, 
    new int[][] {
        new int[] {0, 2},
        new int[] {5, 2},
        new int[] {5, 5}
    }
);
Console.WriteLine();

Console.WriteLine("rowMin == rowMax && colMin < colMax | Expected 24");
PacMan(
    15, 
    new int[] {2, 9}, 
    new int[][] {
        new int[] {7, 10},
        new int[] {5, 1},
        new int[] {10, 14},
        new int[] {14, 4},
        new int[] {9, 13}
    }
);
Console.WriteLine();

int PacMan(int lenOfMatrix, int[] positionOfPacMan, int[][] positionOfEnemies)
{
    if(lenOfMatrix < 2 || positionOfPacMan.Length == 0)
        return 0;

    if(positionOfEnemies.Length == 0)
        return lenOfMatrix * lenOfMatrix - 1;

    if(positionOfEnemies.Length == 1)
    {
        Console.WriteLine(CalcWithOneEnemie(lenOfMatrix, positionOfPacMan, positionOfEnemies[0]));
        return CalcWithOneEnemie(lenOfMatrix, positionOfPacMan, positionOfEnemies[0]);
    }

    var (rowMin, rowMax, colMin, colMax) = CalcRowColMinMax(positionOfPacMan, ref positionOfEnemies);
    //Console.WriteLine($"{rowMin} - {rowMax} - {colMin} - {colMax}");

    if(rowMin == rowMax && colMin == colMax)
    {
        // superior direito
        if(positionOfPacMan[0] < rowMin && positionOfPacMan[1] > colMin)
        {
            Console.WriteLine((rowMin - 0) * (lenOfMatrix - 1 - colMin) - 1);
            return (rowMin - 0) * (lenOfMatrix - 1 - colMin) - 1;
        }
        // inferior direito
        else if(positionOfPacMan[0] > rowMin && positionOfPacMan[1] > colMin)
        {
            Console.WriteLine((lenOfMatrix - 1 - rowMax) * (lenOfMatrix - 1 - colMax) - 1);
            return (lenOfMatrix - 1 - rowMax) * (lenOfMatrix - 1 - colMax) - 1;
        }
        // superior esquerdo
        else if(positionOfPacMan[0] < rowMin && positionOfPacMan[1] < colMin)
        {
            Console.WriteLine((rowMax - 0) * (colMin - 0) - 1);
            return (rowMax - 0) * (colMin - 0) - 1;
        }
        // inferior esquerdo
        else if(positionOfPacMan[0] > rowMin && positionOfPacMan[1] < colMin)
        {
            Console.WriteLine((lenOfMatrix - 1 - rowMax) * (colMin - 0) - 1);
            return (lenOfMatrix - 1 - rowMax) * (colMin - 0) - 1;
        }
    }

    if(rowMin == rowMax && colMin < colMax)
    {
        if(positionOfPacMan[0] < rowMin && positionOfPacMan[1] > colMin)
        {
            Console.WriteLine((rowMin - 0) * (colMax - 1 - colMin) - 1);
            return (rowMin - 0) * (colMax - 1 - colMin) - 1;
        }
        Console.WriteLine((lenOfMatrix - 1 - rowMax) * (colMax - 1 - colMin) - 1);
        return (lenOfMatrix - 1 - rowMax) * (colMax - 1 - colMin) - 1;
    }
    
    if(rowMin < rowMax && colMin == colMax)
    {
        if(positionOfPacMan[0] < rowMax && positionOfPacMan[1] > colMax)
        {
            Console.WriteLine((rowMax - 1 - rowMin) * (lenOfMatrix - 1 - colMax) - 1);
            return (rowMax - 1 - rowMin) * (lenOfMatrix - 1 - colMax) - 1;
        }
        Console.WriteLine((rowMax - 1 - rowMin) * (colMin - 0) - 1);
        return (rowMax - 1 - rowMin) * (colMin  - 0) - 1;
    }

    rowMin++;
    colMin++;
    
    if(colMax < positionOfPacMan[1])
    {
        if(rowMin > rowMax)
        {
            Console.WriteLine((rowMin - rowMax) * (lenOfMatrix - colMin + 1));
            return (rowMin - rowMax) * (lenOfMatrix - colMin + 1);
        }
        Console.WriteLine((rowMax - rowMin) * (lenOfMatrix - 1 - colMin + 1) - 1);
        return (rowMax - rowMin) * (lenOfMatrix - 1 - colMin + 1) - 1;
    }
    Console.WriteLine((rowMax - rowMin) * (colMax - colMin) - 1);
    return (rowMax - rowMin) * (colMax - colMin) - 1;
}

(int RowMin, int RowMax, int ColMin, int ColMax) CalcRowColMinMax(int[] positionOfPacMan, ref int[][] positionOfEnemies)
{
    var rows = new List<int>();
    var cols = new List<int>();

    int rowMin = -1;
    int rowMax = -1;
    int colMin = -1;
    int colMax = -1;

    foreach(var enemie in positionOfEnemies)
    {
        rows.Add(enemie[0]);
        cols.Add(enemie[1]);
    }
    
    try
    {
        rowMin = rows.Where(i => i < positionOfPacMan[0]).Max();
    }
    catch
    {
        rowMin = rows.Where(i => i > positionOfPacMan[0]).Min();
    }
    try
    {
        rowMax = rows.Where(i => i > positionOfPacMan[0]).Min();
    }
    catch
    {
        rowMax = rows.Where(i => i < positionOfPacMan[0]).Max();
    }
    try
    {
        colMin = cols.Where(i => i < positionOfPacMan[1]).Max();
    }
    catch
    {
        colMin = cols.Where(i => i > positionOfPacMan[1]).Min();
    }
    try
    {
        colMax = cols.Where(i => i > positionOfPacMan[1]).Min();
    }
    catch
    {
        colMax = cols.Where(i => i < positionOfPacMan[1]).Max();
    }

    return (rowMin, rowMax, colMin, colMax);
}

int CalcWithOneEnemie(int lenOfMatrix, int[] positionOfPacMan, int[] posOfEnemie)
{
    int elementsThatPacmaEat = 0;

    // superior esquerdo
    if(posOfEnemie[0] > positionOfPacMan[0] && posOfEnemie[1] > positionOfPacMan[1])
    {
        elementsThatPacmaEat += (posOfEnemie[0] - 0) * (posOfEnemie[1] - 0);
    }
    // inferior left
    else if(posOfEnemie[0] < positionOfPacMan[0] && posOfEnemie[1] > positionOfPacMan[1])
    {
        elementsThatPacmaEat += (lenOfMatrix - 1 - posOfEnemie[0]) * (posOfEnemie[1] - 0);
    }
    else if(posOfEnemie[0] > positionOfPacMan[0] && posOfEnemie[1] < positionOfPacMan[1])
    {
        elementsThatPacmaEat += (posOfEnemie[0] - 0) * (lenOfMatrix - 1 - posOfEnemie[1]);
    }
    else if(posOfEnemie[0] < positionOfPacMan[0] && posOfEnemie[1] < positionOfPacMan[1])
    {
        elementsThatPacmaEat += (lenOfMatrix - 1 - posOfEnemie[0]) * (lenOfMatrix - 1 - posOfEnemie[1]);
    }

    elementsThatPacmaEat -= 1; // Deduce count of pacman

    return elementsThatPacmaEat;
}