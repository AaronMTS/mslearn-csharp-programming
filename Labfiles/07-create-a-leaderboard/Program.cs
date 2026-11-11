// Set up the game
Random random = new Random();

Console.Write("Rounds to be played: ");
int roundsPlayed;
while (!int.TryParse(Console.ReadLine(), out roundsPlayed))
{
    Console.WriteLine("Invalid number. Please try again. ");
}

List<int> allScores = new List<int>();

Console.WriteLine($"Playing {roundsPlayed} rounds...\n");

// Simulate playing rounds and log every score
for (int i = 0; i < roundsPlayed; i++)
{
    int score = random.Next(0, 101);
    Console.WriteLine($"Round #{i + 1,2}: {score,3} points");
    allScores.Add(score);
}
Console.WriteLine($"\nTotal rounds logged: {allScores.Count}");

// Build the Top 5 leaderboard array and print the leaderboard
allScores.Sort();
allScores.Reverse();

int[] top5 = new int[5];

Console.WriteLine("\n🏆 Top 5 Leaderboard 🏆");
for (int i = 0; i < Math.Min(top5.Length, allScores.Count); i++)
{
    Console.WriteLine($"{i + 1}. {allScores[i]} points");
    top5[i] = allScores[i];
}