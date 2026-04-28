namespace Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables to store student name and subject marks
            string name = "";
            List<int> subjects = new List<int>();

            // Get student name from user
            while (true)
            {
                Console.Write("Enter student name: ");
                name = Console.ReadLine();
                // Ensure user enters a valid name
                if (!string.IsNullOrWhiteSpace(name))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid name.");
                }
            }

            // Get 3 subject marks from user
            for (int i = 1; i < 4; i++)
            {
                while (true)
                {
                    Console.Write($"Enter mark for Subject {i}: ");
                    // Ensure user enters valid marks
                    if (int.TryParse(Console.ReadLine(), out int subject) && subject >= 0 && subject <= 100)
                    {
                        subjects.Add(subject);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                    }
                }
            }

            // Calculate results
            int totalMarks = subjects.Sum();
            double averageMarks = subjects.Average();
            bool isPassed = averageMarks >= 50;
            DateTime resultIssueDate = DateTime.Now;

            // Display results
            Console.WriteLine($"\n===== STUDENT RESULTS =====");
            Console.WriteLine($"Student Name: {name}");
            Console.WriteLine($"Total Marks: {totalMarks}");
            Console.WriteLine($"Average Marks: {averageMarks:F2}");
            Console.WriteLine($"Result: {(isPassed ? "PASS" : "FAIL")}");
            Console.WriteLine($"Result Issue At: {resultIssueDate}");
        }
    }
}
