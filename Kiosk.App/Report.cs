using System.Runtime.Serialization;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Kiosk.App;

public class Report {
    public void Run() {
        Console.WriteLine("Visual Report");
        Console.WriteLine("============");
        
        int[] data = {25, 18};
        string[] labels = {"Y", "N"};
        var html ="=====" + "a" + "======";
       Console.WriteLine(html);
    }
}