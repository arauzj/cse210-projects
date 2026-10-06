using System;
using System.Collections;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        Assignment regular = new Assignment("Harrison Ward", "Pre-Calc");
        Console.WriteLine(regular.GetSummary());
        MathAssignment math = new MathAssignment("Lucas Wayne", "Alegebra", "19.77", "5-12");
        Console.WriteLine(math.GetHomeworkList());
        WritingAssignment writingAssignment = new WritingAssignment("Aly Black", "English 160", "Finding My Stride");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}