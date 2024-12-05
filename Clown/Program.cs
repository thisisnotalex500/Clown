internal class Program
{
    private static void Main(string[] args)
    {
        // These statements create an instance of 
        // Clown and then set its fields
        Clown oneClown = new Clown
        {
            name = "Boffo",
            Height = 14
        };
        oneClown.TalkAboutYourself();

        // These statements instantiate a second
        // Clown object and fill it with data.

        Clown anotherClown = new Clown();
        anotherClown.name = "Biff";
        anotherClown.Height = 16;
        anotherClown.TalkAboutYourself();

        // Now we instantiate a third Clown object
        // and use data from the other two
        // instances to set its fields
        Clown clown3 = new Clown();
        clown3.name = anotherClown.name;
        clown3.Height = oneClown.Height - 3;
        clown3.TalkAboutYourself();

        // Notice how there's no "new" statement
        // here -- we're not creating a new object,
        // just modifying one already in memory
        anotherClown.Height *= 2;
        anotherClown.TalkAboutYourself();
    }

}