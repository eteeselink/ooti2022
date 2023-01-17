using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Kiosk.App;

class Survey {

    private Read reader;
    private Results results;
    private Dictionary<String, string[]> questions;
    private Dictionary<String, List<String>> answers;
    private int n;

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


    public void ExecuteSurvey() {
        Console.WriteLine("Number of participants: ");
        n = Int32.Parse(Console.ReadLine());

        answers = new Dictionary<string, List<string>>();
        foreach(var question in questions.Keys) {
            answers.Add(question, new List<String>());
        }

        for (int i = 0; i < n; i ++) {
            Console.WriteLine("Participant " + (i + 1));

            foreach(var question in questions) {
                Console.WriteLine(question.Key + " (" + string.Join(" ", question.Value) + ")");
                string temp = Console.ReadLine();
                answers[question.Key].Add(temp);
            }
        }

    }

    public void Run() {
        Console.WriteLine("Survey");
        reader = new Read();
        questions = reader.ReadQuestionsFile();
        ExecuteSurvey();
        sendSurveyResults();
    }

    public void sendSurveyResults() {
        results = new Results();
        results.proccessResults(answers);
    }
}