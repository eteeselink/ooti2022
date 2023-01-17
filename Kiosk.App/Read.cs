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
    public string ReadQuestionsFile() {
        // we run in <root>/Kiosk.App/bin/Debug/net6.0, so gotta go up 4 levels
        var rootDir = AppContext.BaseDirectory + "/../../../../";

        // Read the questions file line by line
        foreach (string line in System.IO.File.ReadLines(rootDir + "questions.txt")) {
            Console.WriteLine(line);
        }
        
        return "hi xd";
    }
}