using System; 

class Program
{
    static void Main(string[] args)
    {
        Entry myEntry = new Entry();
        myEntry._givenprompt = "What was the best part of your day?";
        myEntry._entryDateTime = "OCt 6 2025";
        myEntry._entryText = "I had a great day learning C#!";
        //myEntry.Display();
        Entry anotherEntry = new Entry();
        anotherEntry._givenprompt = "Favorite GC Talk?";
        anotherEntry._entryDateTime = "Oct 5 2025";
        anotherEntry._entryText = "Elder Amos' talk";

        Journal myJournal = new Journal();
        myJournal.Initialize();
        myJournal.AppendEntry(myEntry);
        myJournal.AppendEntry(anotherEntry);
        myJournal.Display();
    }
}