using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


using System.Windows.Forms;

namespace Test15_01
{
    public class AsyncForm:Form
    {
        Label label;
        Button button;

        public AsyncForm()
        {
            label = new Label { Location = new Point(10,20), Text = "Length" };
            button = new Button { Location = new Point(10, 50), Text = "Click" };

            button.Click += DisplayWebSiteLength;
            AutoSize = true;
            Controls.Add(label);
            Controls.Add(button);
           
        }


        async void DisplayWebSiteLength(object sender,EventArgs e)
        {
            label.Text = "Fetching……";
            using(HttpClient client=new HttpClient())
            {
                //string text = await client.GetStringAsync("http://csharpindepth.com");
                Task<string> task = client.GetStringAsync("http://csharpindepth.com");
                string text = await task;
                label.Text = text.Length.ToString();
            }
        }

        static async Task<int> GetPageLengthAsync(string url)
        {
            using(HttpClient client=new HttpClient())
            {
                Task<string> fetchTextTask = client.GetStringAsync(url);
                int length = (await fetchTextTask).Length;
                return length;
            }
        }

        static void PrintPageLength()
        {
            Task<int> lengthTask = GetPageLengthAsync("http://csharpindepth.com");
            Console.WriteLine(lengthTask.Result);
        }
    }
}
