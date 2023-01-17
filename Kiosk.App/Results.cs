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