using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;



namespace Kiosk.App;
class Results {

    public void Run() {
        Console.WriteLine("TextResultReport");
    }

    public void proccessResults(Dictionary<string, List<String>> results) {
        // var answers1 = new List<String>(){"T", "F", "T", "T", "T", "F"};
        // var answers2 = new List<String>(){"Light Blue", "Green", "Red", "Brown", "Red"};
        // var answers3 = new List<String>(){"True", "True", "False"};
        // var fakeResults = new Dictionary<string, List<String>>();
        // fakeResults.Add("Q1", answers1);
        // fakeResults.Add("Q2", answers2);
        // fakeResults.Add("Q3", answers3);

        var processedResults = new Dictionary<string, Dictionary<string, int>>();


        foreach (var question in results.Keys)
        {
            var countedResults = new Dictionary<string, int>();
            var answers = results[question];
            foreach (var answer in answers) {
                if (countedResults.ContainsKey(answer)) {
                    countedResults[answer]++;
                } else {
                    countedResults.Add(answer, 1);
                }    
            }
            processedResults.Add(question, countedResults);
        }

       new Report().visualizeresults(processedResults);
    }
    public void Run(Dictionary<String, List<String>> answers) {
        Console.WriteLine("Results");
    }
}