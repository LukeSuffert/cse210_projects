class Journal

//attibute
public List<Entry> _entryList;

//behaviors
public void Initialize()
{
    _entryList = new List<Entry>();
}

public void AppendEntry(Entry e)
{
    _entryList.Add(e);
}

public void Display()
{
    Console.WriteLine("--------");
    foreach (Entry item in _entryList)

    {
        Entry.Display();
        Console.WriteLine("--------");
    }
    Console.WriteLine(entryList[0]._entryDateTime);
}