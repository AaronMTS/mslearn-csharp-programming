// Log a new event
string logFile = "log.txt";
string timestamp = DateTime.Now.ToString();
string newEvent = $"[{timestamp}] Application started.\n";

File.AppendAllText(logFile, newEvent);
Console.WriteLine("Event logged.\n");

// Read back every logged event
if (File.Exists(logFile))
{
    Console.WriteLine("Event history:");

    int numberOfEvents = 0;

    using StreamReader reader = new StreamReader(logFile);
    string? line;
    while ((line = reader.ReadLine()) != null)
    {
        Console.WriteLine(line);
        numberOfEvents++;
    }

    // Count the logged events
    Console.WriteLine($"\nLogged events: {numberOfEvents}");
}
else
{
    Console.WriteLine("File does not exist.");
}