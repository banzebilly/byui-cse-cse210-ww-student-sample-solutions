//banze Billy



GoalManager manager = new GoalManager();

while (true)
{
    Console.Clear();

    Console.WriteLine($"You have {manager.GetScore()} points.");
    Console.WriteLine();

    Console.WriteLine("Menu:");
    Console.WriteLine("1. Create New Goal");
    Console.WriteLine("2. List Goals");
    Console.WriteLine("3. Record Event");
    Console.WriteLine("4. Save Goals");
    Console.WriteLine("5. Load Goals");
    Console.WriteLine("6. Quit");

    Console.Write("Select a choice from the menu: ");
    string choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("How many points is this goal worth? ");
        int points = int.Parse(Console.ReadLine());

        if (goalType == "1")
        {
            SimpleGoal goal = new SimpleGoal(name, description, points);
            manager.AddGoal(goal);
        }
        else if (goalType == "2")
        {
            EternalGoal goal = new EternalGoal(name, description, points);
            manager.AddGoal(goal);
        }
        else if (goalType == "3")
        {
            Console.Write("How many times does this goal need to be completed? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for completing it? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal goal = new ChecklistGoal(
                name,
                description,
                points,
                target,
                bonus);

            manager.AddGoal(goal);
        }
    }
    else if (choice == "2")
    {
        manager.DisplayGoals();
    }
    else if (choice == "3")
    {
        Console.WriteLine("The goals are:");

        manager.DisplayGoals();

        Console.Write("Which goal did you accomplish? ");
        int goalNumber = int.Parse(Console.ReadLine());

        manager.RecordEvent(goalNumber - 1);
    }
    else if (choice == "4")
    {
        Console.WriteLine("Save Goals");
    }
    else if (choice == "5")
    {
        Console.WriteLine("Load Goals");
    }
    else if (choice == "6")
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid choice.");
    }

    Console.WriteLine();
    Console.Write("Press Enter to continue...");
    Console.ReadLine();
}