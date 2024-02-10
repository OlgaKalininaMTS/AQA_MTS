using System.Collections;

namespace LINQ;

class Person(int client, int year, int nummonth, int trainingtime)
{
    public int Client { get; set; } = client;
    public int Year { get; set; } = year;
    public int NumMonth { get; set; } = nummonth;
    public int TrainingTime { get; set; } = trainingtime;
}