// See https://aka.ms/new-console-template for more information

using BabyCarrotLib.Tools;

LogManager log = new LogManager();
log.WriteLine("[Begin Processing]-----");

    for (int index = 0; index < 10; index++)
    {
        log.WriteLine("Processing : " + index);

        System.Threading.Thread.Sleep(500);

        log.WriteLine("Done : " + index);
    }

log.WriteLine("[End Processing]-----");
