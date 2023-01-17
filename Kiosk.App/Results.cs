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

    public Dictionary<string, KeyValuePair<string, int>> proccessResults(Dictionary<string, List<String>> results) {
        var answers1 = new List<String>(){"T", "F", "T", "T", "T", "F"};
        var answers2 = new List<String>(){"Light Blue", "Green", "Red", "Brown", "Red"};
        var answers3 = new List<String>(){"True", "True", "False"};
        var fakeResults = new Dictionary<string, List<String>>();
        fakeResults.Add("Q1", answers1);
        fakeResults.Add("Q2", answers2);
        fakeResults.Add("Q3", answers3);

        var processedResults = new Dictionary<string, KeyValuePair<string, int>>();


        foreach (var question in fakeResults.Keys)
        {
            var valuecountedResults = new KeyValuePair<String, int>();
            var answers = fakeResults[question];
            for (var answer in answers) {

            }
        }

        return processedResults;
    }
    public void Run(Dictionary<String, List<String>> answers) {
        Console.WriteLine("Results");
    }
}