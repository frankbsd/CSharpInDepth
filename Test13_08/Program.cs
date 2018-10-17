using Microsoft.Office.Interop.Word;
using System;

namespace Test13_08
{
    class Program
    {
        static void Main(string[] args)
        {
            object missing = Type.Missing;

            Application app = new Application { Visible = true };
            app.Documents.Add(ref missing, ref missing, ref missing, ref missing);
            Document document = app.ActiveDocument;
            Paragraph paragraph = document.Paragraphs.Add(ref missing);
            paragraph.Range.Text = "Thank goodness for C# 4";

            object filename = "demo.doc";
            object format = WdSaveFormat.wdFormatDocument97;
            document.SaveAs2(ref filename, ref format,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing);

            document.Close(ref missing, ref missing, ref missing);
            app.Application.Quit(ref missing, ref missing, ref missing);

        }
    }
}
