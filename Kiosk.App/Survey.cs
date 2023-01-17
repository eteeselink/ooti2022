using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Kiosk.App;

class Survey {

    private Read reader;
    private Results results;
    private Dictionary<String, List<String>> questions;
    private Dictionary<String, List<String>> answers;

    private Dictionary<String, List<String>> MockDict() {
        Dictionary<String, List<String>> mockQuestions = new Dictionary<String, List<String>>();

        string[] answers = {"Y", "N"};
        List<string> ansRange = new List<string>(answers);
        mockQuestions.Add("Are cats better than dogs?", ansRange);

        return mockQuestions;
    }

    private Dictionary<String, List<String>> MockAnswers() {
        Dictionary<String, List<String>> mockAnswers = new Dictionary<String, List<String>>();

        string[] answers = {"Y", "N", "Y", "Y"};
        List<string> ansRange = new List<string>(answers);

        mockAnswers.Add("Are cats better than dogs?", ansRange);

        return mockAnswers;
    }


    


    public void Run() {
        Console.WriteLine("Survey");
    }

    public void sendSurveyResults() {
        answers = MockAnswers();
        results.Run(answers);
    }
}