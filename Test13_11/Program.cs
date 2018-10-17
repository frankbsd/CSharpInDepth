using Microsoft.Office.Interop.Word;
using System;

namespace Test13_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Application app = new Application { Visible = false };
            object missing = Type.Missing;
            ShowInfo(app.get_SynonymInfo("painful", ref missing));
            ShowInfo(app.SynonymInfo["nice", WdLanguageID.wdEnglishUS]);
            ShowInfo(app.SynonymInfo[Word: "features"]);

            app.Application.Quit();
            Console.ReadKey();
        }

        static void ShowInfo(SynonymInfo info)
        {
            Console.WriteLine("{0} has {1} meanings", info.Word, info.MeaningCount);
        }
    }
}
