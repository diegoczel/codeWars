//var c = new PagnationHelper<char>();
var c = new PagnationHelper<char>(new List<char>{'a', 'b', 'c', 'd', 'e', 'f'}, 4);
c.Test1();

Console.WriteLine();
var d = new PagnationHelper<int>(
    new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24}, 
    10
);
d.Test1();


class PagnationHelper<T>
{
    private IList<T> _collection;
    private int _itemsPerPage;
  
    /// <summary>
    /// Constructor, takes in a list of items and the number of items that fit within a single page
    /// </summary>
    /// <param name="collection">A list of items</param>
    /// <param name="itemsPerPage">The number of items that fit within a single page</param>
    public PagnationHelper(IList<T> collection, int itemsPerPage)
    {
        _collection = collection;
        _itemsPerPage = itemsPerPage;
    }

    /// <summary>
    /// The number of items within the collection
    /// </summary>
    public int ItemCount
    {
        get => _collection.Count;
    }

    /// <summary>
    /// The number of pages
    /// </summary>
    public int PageCount
    {
        get
        {
            if(ItemCount / _itemsPerPage == 0)
            {
                return ItemCount / _itemsPerPage;
            }
            return ItemCount / _itemsPerPage + 1;
        }
    }

    /// <summary>
    /// Returns the number of items in the page at the given page index 
    /// </summary>
    /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
    /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
    public int PageItemCount(int pageIndex)
    {
        if(pageIndex < 0 || pageIndex >= PageCount)
        {
            return -1;
        }

        if(ItemCount / _itemsPerPage == 0)
        {
            return ItemCount / _itemsPerPage;
        }
        // when is the last element
        return ((pageIndex + 1) == PageCount) ? (ItemCount - (ItemCount / _itemsPerPage * _itemsPerPage)) : _itemsPerPage;
    }

    /// <summary>
    /// Returns the page index of the page containing the item at the given item index.
    /// </summary>
    /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
    /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
    public int PageIndex(int itemIndex)
    {
        if(itemIndex < 0 || itemIndex >= ItemCount)
        {
            return -1;
        }
        
        return itemIndex / _itemsPerPage;
    }

    public void Test1()
    {
        Console.WriteLine($"Page Count: {PageCount}");
        Console.WriteLine($"Item Count: {ItemCount}");
        Console.WriteLine($"Page 0 - Count: {PageItemCount(0)}");
        Console.WriteLine($"Page 1 - Count: {PageItemCount(1)}");
        Console.WriteLine($"Page 2 - Count: {PageItemCount(2)}");
        Console.WriteLine($"Page 19 - Count: {PageItemCount(19)}");
        Console.WriteLine($"Page 0 - Page: {PageIndex(0)}");
        Console.WriteLine($"Page 3 - Page: {PageIndex(3)}");
        Console.WriteLine($"Page 4 - Page: {PageIndex(4)}");
        Console.WriteLine($"Page 5 - Page: {PageIndex(5)}");
        Console.WriteLine($"Page 6 - Page: {PageIndex(6)}");
        Console.WriteLine($"Page 7 - Page: {PageIndex(7)}");
        Console.WriteLine($"Page 9 - Page: {PageIndex(9)}");
        Console.WriteLine($"Page 10 - Page: {PageIndex(10)}");
        Console.WriteLine($"Page 19 - Page: {PageIndex(19)}");
        Console.WriteLine($"Page 20 - Page: {PageIndex(20)}");
        Console.WriteLine($"Page 23 - Page: {PageIndex(23)}");
        Console.WriteLine($"Page 24 - Page: {PageIndex(24)}");
        Console.WriteLine($"Page 27 - Page: {PageIndex(27)}");
    }
}