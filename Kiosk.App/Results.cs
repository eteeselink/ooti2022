using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;


namespace Kiosk.App;

class Results {
    public void Run() {
        var answers1 = new List<String>(){"T", "F", "T", "T", "T", "F"};
        var answers2 = new List<String>(){"Light Blue", "Green", "Red", "Brown", "Red"};
        var answers3 = new List<String>(){"True", "True", "False"};
        var results = new Dictionary<string, List<String>>();
        results.Add("Q1", answers1);
        results.Add("Q2", answers2);
        results.Add("Q3", answers3);


    }
}