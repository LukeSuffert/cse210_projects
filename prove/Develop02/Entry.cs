class Entry
{

    //attributes
    public string _givenprompt;
    public string _entryDateTime;
    public string _entryText;

    //behavior
    public void Display()
    {
        //Console.WriteLine("Hello Developer02");
        Entry myEntry = new Entry();
        myEntry._givenprompt = "What was the best part of your day?";
        myEntry._entryDateTime = "OCt 6 2025";
        myEntry._entryText = "I had a great day learning C#!";
        myEntry.Display();
    }
}