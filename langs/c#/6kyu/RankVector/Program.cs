static int[] Ranks(int[] ranks) {
    if(ranks.Length == 0) return new int[0];

    var rankOrdered = new SortedDictionary<int,List<int>>();
    
    for(int ind = 0; ind < ranks.Length; ind++)
    {
        if(rankOrdered.ContainsKey(ranks[ind]))
            rankOrdered[ranks[ind]].Add(ind);
        else
            rankOrdered.Add(ranks[ind], new List<int>{ind});
    }        
    
    int[] result = new int[ranks.Length];

    int rank = 1;
    for(int ind = rankOrdered.Count - 1; ind > -1; ind-- )
    {
        foreach(var val in rankOrdered.ElementAt(ind).Value)
            result[val] = rank;
        rank = rank + rankOrdered.ElementAt(ind).Value.Count;
    }

    return result;
}