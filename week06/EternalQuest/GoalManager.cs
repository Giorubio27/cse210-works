using System.Runtime.CompilerServices;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();

    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();

    }
    public void Start()
    {
        string choice = "";
        Console.WriteLine("1. Display player info\n2. List goal names\n3. List goal details\n4. Record Events\n5 Create Goals\n6. Save Goals\n7. Load Goals");
        choice = Console.ReadLine();
        while (choice != "quit")
        {

            if (choice == "1")
            {
                DisplayPlayerInfo();

            }
            else if (choice == "2")
            {
                ListGoalNames();

            }
            else if (choice == "3")
            {
                ListGoalDetails();

            }
            else if (choice == "4")
            {
                RecordEvent();
            }
            else if (choice == "5")
            {
                CreateGoal();
            }
            else if (choice == "6")
            {
                Console.WriteLine("What file would you like to save your goals to?");
                string filename = Console.ReadLine();
                SaveGoals(filename);
            }
            else if (choice == "7")
            {
                LoadGoals();
            }
            Console.WriteLine("1. Display player info\n2. List goal names\n3. List goal details\n4. Record Events\n5 Create Goals\n6. Save Goals\n7. Load Goals");
            choice = Console.ReadLine();
        }

    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have a total of {_score} points");

    }
    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            string representation = goal.GetStringRepresentation();

            string[] parts = representation.Split(",");
            string name = parts[1];
            Console.WriteLine(name);
        }

    }
    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailString());
        }
    }
    public void CreateGoal()
    {

        Console.WriteLine("What is the name of the goal you want to create?");
        string goalname = Console.ReadLine();
        Console.WriteLine("What is the description for the goal?");
        string goalDescription = Console.ReadLine();
        Console.WriteLine("How many points is this goal worth?");
        string goalPoints = Console.ReadLine();
        int goalPointsInt = int.Parse(goalPoints);
        Console.WriteLine("What kind of goal is it? \n1. Simple, \n2. Checklist, \n3. Eternal Goal");
        string goalType = Console.ReadLine();
        if (goalType == "1")
        {
            SimpleGoal simplegoal = new SimpleGoal(goalname, goalDescription, goalPointsInt);
            _goals.Add(simplegoal);

        }
        else if (goalType == "2")
        {
            Console.WriteLine("What is the target for the times you need to complete it?");
            string targetTimes = Console.ReadLine();
            int targetTimesInt = int.Parse(targetTimes);
            Console.WriteLine("What is the bonus upon hitting the target?");
            string bonus = Console.ReadLine();
            int bonusInt = int.Parse(bonus);



            ChecklistGoal checkGoal = new ChecklistGoal(goalname, goalDescription, goalPointsInt, targetTimesInt, bonusInt);
            _goals.Add(checkGoal);

        }
        else if (goalType == "3")
        {
            Console.WriteLine("This will be a lifetime pursuit");
            EternalGoal eternalGoal = new EternalGoal(goalname, goalDescription, goalPointsInt);
            _goals.Add(eternalGoal);

        }

    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailString()}");
        }
        Console.WriteLine("Which goal did you want to record? ");
        int selectedGoal = int.Parse(Console.ReadLine()) - 1;

        _goals[selectedGoal].RecordEvent();

        _score += _goals[selectedGoal].GetPoints();

        Console.WriteLine($"Congrats! You now have {_score} points!");

    }
    public void SaveGoals(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }

    }
    public void LoadGoals()
    {
        Console.WriteLine("What is the filename that you want to load? ");
        string loadFile = Console.ReadLine();
        string[] goals = System.IO.File.ReadAllLines(loadFile);

        _score = int.Parse(goals[0]);
        for (int i = 1; i < goals.Length; i++)
        {
            string goal = goals[i];
            string[] partsgoals = goal.Split(',');

            string loadGoal = partsgoals[0];
            string loadName = partsgoals[1];
            string loadDesc = partsgoals[2];
            string loadPoints = partsgoals[3];
            string loadTarget = partsgoals[4];
            string loadBonus = partsgoals[5];
            string loadAmount = partsgoals[6];

            int loadPointsInt = int.Parse(loadPoints);
            // If i make the key or first index a type of Goal i think that could help me load the goals correctly is that a good method?
            if (loadGoal == "SimpleGoal")
            {
                bool isComplete = bool.Parse(partsgoals[4]);
                SimpleGoal newSimpleGoal = new SimpleGoal(loadName, loadDesc, loadPointsInt);
                _goals.Add(newSimpleGoal);
            }
            else if (loadGoal == "ChecklistGoal")
            {
                int loadBonusInt = int.Parse(loadBonus);
                int loadTargetInt = int.Parse(loadTarget);
                int loadAmountInt = int.Parse(loadAmount);
                ChecklistGoal newChecklistGoal = new ChecklistGoal(loadName, loadDesc, loadPointsInt, loadTargetInt, loadBonusInt);
                _goals.Add(newChecklistGoal);
            }
            else if (loadGoal == "EternalGoal")
            {
                EternalGoal newEternal = new EternalGoal(loadName, loadDesc, loadPointsInt);
                _goals.Add(newEternal);
            }



        }

    }
}