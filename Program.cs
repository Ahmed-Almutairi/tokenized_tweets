using System;
using System.Collections;

namespace tokenized_tweets
{
    class Program
    {
        static void tokenizer1(String vaule,ArrayList accont, ArrayList Hash)
        {
            int i = 0;
            String tokenizer = "";
            while (vaule.Length > i)
            {

                if (vaule[i] == '#')
                {
                    tokenizer = "";
                    //int restNumber = 6;
                    i++;
                    while ((Char.IsLetter(vaule[i]) || Char.IsDigit(vaule[i])) )
                    {//Console.WriteLine(tokenizer);
                        tokenizer = tokenizer + vaule[i];
                        i++;
                        //restNumber--;
                    }

                    Hash.Add(tokenizer);
                    //Console.WriteLine(tokenizer);
                    //restNumber = 6;

                }
                else if (vaule[i] == '@')
                {
                    tokenizer = "";
                    //int restNumber = 6;
                    i++;
                    while ((Char.IsLetter(vaule[i]) || Char.IsDigit(vaule[i])))
                    {//Console.WriteLine(tokenizer);
                        tokenizer = tokenizer + vaule[i];
                        i++;
                        //restNumber--;
                    }
                    //for (int x = 0; x <= restNumber; x++)
                    //{
                    //    tokenizer = tokenizer + "0";
                    //}
                    accont.Add(tokenizer);
                    //Console.WriteLine(tokenizer);
                    //restNumber = 6;

                }
                else
                i++;

            }
            Console.WriteLine("accont:");
            foreach (Object obj in accont)
                Console.Write("   {0}\n", obj);
            Console.WriteLine("");

            Console.WriteLine("Hash:");
            foreach (Object obj in Hash)
                Console.Write("   {0}", obj);
            Console.WriteLine("");

        }
        static void Main(string[] args)
        {
            
            
            ArrayList arrayList = new ArrayList();
            ArrayList arrayList1 = new ArrayList();
            tokenizer1(" It's now Fajer athan time 4:31 am according to London city local time. #London ", arrayList, arrayList1);
            arrayList.Add("HI");
            //Console.WriteLine(arrayList.);
        }
    }
}
