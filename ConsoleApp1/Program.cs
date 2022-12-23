using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Execute python process...");
        Option1_ExecProcess();

        Console.WriteLine();



        Console.ReadKey();
    }

    static void Option1_ExecProcess()
    {
        // 1) Create Process Info
        var psi = new ProcessStartInfo();
        psi.FileName = @"C:\Users\devmith.DESKTOP-J4KJDQG\AppData\Local\Programs\Python\Python37\python.exe";
//main2.py");

        // 2) Provide script and arguments
        var script = @"C:\Users\devmith.DESKTOP-J4KJDQG\Documents\se\s4 y2 sem 1\PUSL2021     Computing Group Project (21SPM)\PROJECT-GIT\Side_temp\main2.py";
        var start = "2019-1-1";
        //var end = "2019-1-22";

        //psi.Arguments = $"\"{script}\" \"{start}\" \"{end}\"";
        psi.Arguments = $" \"{script}\" \"{start}\" ";

        // 3) Process configuration
        psi.UseShellExecute = false;
        psi.CreateNoWindow = true;
        psi.RedirectStandardOutput = true;
        psi.RedirectStandardError = true;

        // 4) Execute process and get output
        var errors = "";
        var results = "";

        using (var process = Process.Start(psi))
        {
            errors = process.StandardError.ReadToEnd();
            results = process.StandardOutput.ReadToEnd();
        }

        // 5) Display output
        Console.WriteLine("ERRORS:");
        Console.WriteLine(errors);
        Console.WriteLine();
        Console.WriteLine("Results:");
        Console.WriteLine(results);

    }

}