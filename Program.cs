using System;
using System.Collections;

namespace tokenized_tweets
{
    class Program
    {
        static void tokenizer1(String vaule,ArrayList account, ArrayList hashtag)
        {
            int i = 0;
            String tokenizer = "";
            while (vaule.Length > i)
            {

                if (vaule[i] == '#')
                {
                    tokenizer = "";
                  
                    i++;
                    while (vaule.Length > i && (Char.IsLetter(vaule[i]) || Char.IsDigit(vaule[i])) )
                    {
                        tokenizer = tokenizer + vaule[i];
                        i++;
                      
                    }

                    hashtag.Add(tokenizer);
                  
                }
                else if (vaule[i] == '@')
                {
                    tokenizer = "";
                   
                    i++;
                    while (vaule.Length > i && (Char.IsLetter(vaule[i]) || Char.IsDigit(vaule[i])))
                    {
                        tokenizer = tokenizer + vaule[i];
                        i++;
                      
                    }

                    account.Add(tokenizer);
                  

                }
                else
                i++;

            }
            Console.WriteLine("account:");
            foreach (Object obj in account)
                Console.Write("   {0}\n", obj);
            Console.WriteLine("");

            Console.WriteLine("hashtag:");
            foreach (Object obj in hashtag)
                Console.Write("   {0}\n", obj);
            Console.WriteLine("");

        }
        static void Main(string[] args)
        {
            
            
            ArrayList arrayList = new ArrayList();
            ArrayList arrayList1 = new ArrayList();
            tokenizer1(" It's now #Asr#athan time 4:50 pm according to London city local time. #London @LondonPrayer", arrayList, arrayList1);
            
    
        }
    }
}
