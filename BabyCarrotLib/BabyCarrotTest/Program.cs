// See https://aka.ms/new-console-template for more information

using BabyCarrotLib.Tools;
using BabyCarrotLib.Extensions;


/*
LogManager log = new LogManager(null, "_BabyCarrotText");

log.WriteLine("[Begin Processing]-----");

    for (int index = 0; index < 10; index++)
    {
        log.WriteLine("Processing : " + index);

        Thread.Sleep(500);

        log.WriteLine("Done : " + index);
    }

log.WriteLine("[End Processing]-----");
*/

string temp = "12/08/2015 10:10";

Console.WriteLine("IsNumeric? : " + temp.IsNumeric());
Console.WriteLine("IsDateTime? : " + temp.IsDateTime());
