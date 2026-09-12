using System;

class Program
{
    static void Main(string[] args)
    {
        //lte me create the Journal object.
        Journal journal = new Journal();

        //the  list of questions that the program can randomly choose from the program.
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "What did I learn today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What am I grateful for today?",
            "What challenge did I overcome today?",
            "What is one thing I want to improve tomorrow?"
        };

        // The Random object used to select a random prompt.
        Random random = new Random();

        // This controls the main menu.
        string choice = "";

        Console.WriteLine("Welcome to the Journal Program!");

    
        while (choice != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices:");

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();


            
            if (choice == "1")
            {
         
                int randomNumber = random.Next(prompts.Count);

                string prompt = prompts[randomNumber];

                
                Console.WriteLine($"\n{prompt}");

                //To  get the user s response.
                Console.Write("> ");
                string response = Console.ReadLine();

                // Geting today's date.
                string date = DateTime.Now.ToShortDateString();

                //the  extra feature: to ask for the user s mood.
                Console.Write("How are you feeling today? ");
                string mood = Console.ReadLine();

                // Create a new Entry object.
                Entry entry = new Entry();

                // Store the information in the Entry.
                entry._date = date;
                entry._prompt = prompt;
                entry._response = response;
                entry._mood = mood;

                // Add the Entry to the Journal.
                journal.AddEntry(entry);

                Console.WriteLine("Your entry has been added.");
            }


            // OPTION 2: DISPLAY
            else if (choice == "2")
            {
                journal.Display();
            }


          
            else if (choice == "3")
            {
                Console.Write("Enter the filename to load: ");
                string filename = Console.ReadLine();

                try
                {
                    journal.LoadFromFile(filename);
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("The file could not be found.");
                }
                catch (Exception)
                {
                    Console.WriteLine("There was a problem loading the journal.");
                }
            }


            
            else if (choice == "4")
            {
                Console.Write("Enter the filename to save: ");
                string filename = Console.ReadLine();

                try
                {
                    journal.SaveToFile(filename);
                }
                catch (Exception)
                {
                    Console.WriteLine("There was a problem saving the journal.");
                }
            }


           
            else if (choice == "5")
            {
                Console.WriteLine("Thank you for using the Journal Program.");
            }


            // the Invalid option
            else
            {
                Console.WriteLine("Please enter a number from 1 to 5.");
            }
        }
    }
}