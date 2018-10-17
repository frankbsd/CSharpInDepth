using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test13_09
{
    class Program
    {
        static void Main(string[] args)
        {
            //object missing = Type.Missing;

            Application app = new Application { Visible = true };
            //app.Documents.Add(ref missing, ref missing, ref missing, ref missing);
            app.Documents.Add();
            Document document = app.ActiveDocument;
            //Paragraph paragraph = document.Paragraphs.Add(ref missing);
            Paragraph paragraph = document.Paragraphs.Add();
            paragraph.Range.Text = "Thank goodness for C# 4";

            //object filename = "demo.doc";
            //object format = WdSaveFormat.wdFormatDocument97;
            ////document.SaveAs2(ref filename, ref format,
            ////    ref missing, ref missing, ref missing,
            ////    ref missing, ref missing, ref missing,
            ////    ref missing, ref missing, ref missing,
            ////    ref missing, ref missing, ref missing,
            ////    ref missing, ref missing);
            //document.SaveAs2(FileName: ref filename, FileFormat: ref format);
            document.SaveAs2(FileName: "test.doc", FileFormat: WdSaveFormat.wdFormatDocument97);

            //document.Close(ref missing, ref missing, ref missing);
            //app.Application.Quit(ref missing, ref missing, ref missing);
            document.Close();
            app.Application.Quit();
        }
    }
}
