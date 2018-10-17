using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test15_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //throw new ArgumentNullException();
            //同步调用
            //MainAsync().Wait();
            //异步调用，无法抛出异常，Why？
            //MainAsync();


            MainAsyncLambda().Wait();


            Console.ReadKey();
        }

        #region 传统方式
        async static Task MainAsync()
        {
            Task<int> task = ComputeLengthAsync(null);
            Console.WriteLine("Fetched the task");
            int length = await task;
            Console.WriteLine("Length: {0}", length);

        }
        //async static Task<int> ComputeLengthAsync(string text)
        static Task<int> ComputeLengthAsync(string text)
        {
            if (text == null)
            {
                //Console.WriteLine("text is null");
                throw new ArgumentNullException("text");
            }
            //await Task.Delay(500);
            //return text.Length;
            return ComputeLengthAsyncImpl(text);
        }

        async static Task<int> ComputeLengthAsyncImpl(string text)
        {
            await Task.Delay(500);
            return text.Length;
        }
        #endregion

        #region Lambda匿名函数
        async static Task MainAsyncLambda()
        {
            Task<int> task = ComputeLengthAsyncLambda(null);
            Console.WriteLine("Fetched the task");
            int length = await task;
            Console.WriteLine("Length: {0}", length);

        }


        static Task<int> ComputeLengthAsyncLambda(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException("text");
            }

            Func<Task<int>> func = async () =>
              {
                  await Task.Delay(500);
                  return text.Length;
              };
            return func();
        }
        #endregion

    }
}
