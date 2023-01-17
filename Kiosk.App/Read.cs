using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Kiosk.App;

class Read {
    public void Run() {
        Console.WriteLine("Questions file contains:");
        Console.WriteLine(ReadQuestionsFile());
    }

    // this is just an example of how to read a file,
    // modify/delete as you see fit.
    public Dictionary<string, string[]> ReadQuestionsFile() {
        // we run in <root>/Kiosk.App/bin/Debug/net6.0, so gotta go up 4 levels
        var rootDir = AppContext.BaseDirectory + "/../../../../";

        // Create resulting dictionary
        Dictionary<string, string[]> questionnaire = new Dictionary<string, string[]>();

        // Read the questions file line by line
        foreach (string line in System.IO.File.ReadLines(rootDir + "questions.txt")) {
            // Split into question and possible answers
            string[] qanda = line.Split("?");
            // Trim current result
            qanda[0] = qanda[0].Trim();
            qanda[1] = qanda[1].Trim();
            // Now split the answers again
            string[] answers = qanda[1].Split(",");
            // Lastly trim these answers again
            for (int i = 0; i < answers.Length; i++) {
                answers[i] = answers[i].Trim();
            }

            // Now add it all to a dict
            questionnaire.Add(qanda[0], answers);
        }

        // Print the resulting data structure
        Console.WriteLine("- All questions and possible answers --");
        foreach (var entry in questionnaire) {
            Console.WriteLine("Question = {0}, Possible answers = {1}", entry.Key, String.Join(" ", entry.Value));
        }
        
        return questionnaire;
    }
}