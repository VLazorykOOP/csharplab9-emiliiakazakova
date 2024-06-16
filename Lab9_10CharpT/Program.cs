namespace Lab9_10CharpT
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Task1");

            ReverseCheck reverseCheck = new ReverseCheck();
            reverseCheck.Run();

            Console.WriteLine("\nTask2\n");

            PositiveNegativeOrder pnOrder = new PositiveNegativeOrder();
            pnOrder.Run();

            Console.WriteLine("\nTask3\n");

            ReverseCheckArray reverseCheckA = new ReverseCheckArray();
            reverseCheckA.Run();
            FileSortingArray fileArray = new FileSortingArray();
            fileArray.Run();


            Console.WriteLine("\nTask4\n");

            MusicCatalog catalog = new MusicCatalog();

            catalog.AddDisk("Disk1");
            catalog.AddDisk("Disk2");

            catalog.AddSong("Disk1", "Artist1", "Song1");
            catalog.AddSong("Disk1", "Artist1", "Song2");
            catalog.AddSong("Disk1", "Artist2", "Song3");
            catalog.AddSong("Disk2", "Artist2", "Song4");

            catalog.ViewCatalog();

            catalog.SearchByArtist("Artist1");

            catalog.RemoveDisk("Disk1");
            catalog.ViewCatalog();
        }
    }
}
