// Movie
//     int id (1)
//     string title (Toy Story)
//     string[] genres (Action, Horror)
using System;
using NLog;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace movieLibraryAssignment
{
    public class Movie:LibraryItem,IMedia {

        public string Genres { get; set;}
        private static string File = "movies.csv";
        
     
        public void Read()
        {
            Console.WriteLine("How many movie do you want to be displayed? ");
            int numberOfMovies = Int32.Parse(Console.ReadLine());
            
            StreamReader reader = new StreamReader(File);

            for(int i = 0; i < numberOfMovies + 1 ; i++)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);    
            }
            reader.Close();
        }
        

        public  void Write()
        {
            ItemID = getLastID() + 1;
            StreamWriter sw = new StreamWriter(File, true);

            Console.WriteLine("Enter a new Title: ");
            string movieTitle = Console.ReadLine();

            var genres = new List<string>();
            string genre;
            string option;

            do
            {
                Console.WriteLine("Add genres: ");
                genre = Console.ReadLine();
                genres.Add(genre);
                Console.WriteLine("Do you want to add a genre: (Y/N)");
                option = Console.ReadLine().ToUpper();
            } while (option == "Y");
            
            string newGenres =  string.Join("|", genres); 

            //ask about how to serialize with current code. 

            // Product product = new Product();
            //     product.Name = "Apple";
            //     product.Expiry = new DateTime(2008, 12, 28);
            //     product.Sizes = new string[] { "Small" };

            // Movie movie = new Movie();
            // //     movie.Title = 



            // string json = JsonConvert.SerializeObject(product);


            sw.WriteLine("{0},{1},{2}", ItemID, movieTitle, newGenres);
            sw.Close();
        }

        
        public override int getLastID()
        {
            int lastID = 0;
            try
            {
                string lastLine = System.IO.File.ReadLines(File).Last();
                string[] lastLineSplit = lastLine.Split(',');
                lastID = Convert.ToInt32(lastLineSplit[0]);
                return lastID;
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("File does not exist.");
            }
            return lastID;
        }


    }
}