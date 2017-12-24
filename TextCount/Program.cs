﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCount
{
        /*Подсчитать, сколько раз каждое слово встречается в за­данном тексте.
        Результат записать в коллекцию Dictio­nary<TKey, TValue>. 
        */

    class Program
    {
        static void Main(string[] args)
        {
            string textPoem = @"Вот дом,
Который построил Джек.
А это пшеница,
Которая в тёмном чулане хранится
В доме,
Который построил Джек.
А это весёлая птица-синица,
Которая часто ворует пшеницу,
Которая в тёмном чулане хранится
В доме,
Который построил Джек.
Вот кот,
Который пугает и ловит синицу,
Которая часто ворует пшеницу,
Которая в тёмном чулане хранится
В доме,
Который построил Джек.
Вот пёс без хвоста,
Который за шиворот треплет кота,
Который пугает и ловит синицу,
Которая часто ворует пшеницу,
Которая в тёмном чулане хранится
В доме,
Который построил Джек.
А это корова безрогая,
Лягнувшая старого пса без хвоста,
Который за шиворот треплет кота,
Который пугает и ловит синицу,
Которая часто ворует пшеницу,
Которая в тёмном чулане хранится
В доме,
Который построил Джек.
А это старушка, седая и строгая,
Которая доит корову безрогую,
Лягнувшую старого пса без хвоста,
Который за шиворот треплет кота,
Который пугает и ловит синицу,
Которая часто ворует пшеницу,
Которая в тёмном чулане хранится
В доме,
Который построил Джек.
А это ленивый и толстый пастух,
Который бранится с коровницей строгою,
Которая доит корову безрогую,
Лягнувшую старого пса без хвоста,
Который за шиворот треплет кота,
Который пугает и ловит синицу,
Которая часто ворует пшеницу,
Которая в тёмном чулане хранится
В доме,
Который построил Джек.
Вот два петуха,
Которые будят того пастуха,
Который бранится с коровницей строгою,
Которая доит корову безрогую,
Лягнувшую старого пса без хвоста,
Который за шиворот треплет кота,
Который пугает и ловит синицу,
Которая часто ворует пшеницу,
Которая в тёмном чулане хранится
В доме,
Который построил Джек.";
            Dictionary<string, int> textCount = new Dictionary<string, int>();
            char[] delimiterChars = { ' ', ',', '.', ':', '\t','\n', '\r', };
            string[] words = textPoem.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in words)
            {
                if (textCount.Count == 0)
                {
                    textCount.Add(s, 1);
                }

                if (textCount.Keys.Contains(s)){
                    textCount[s] += 1;
                }else
                {
                    textCount.Add(s, 1);
                }
            }

            const string format = "{0,-10} {1,10}";
            Console.WriteLine(string.Format(format, "Word", "Number of repetitions"));
            foreach (KeyValuePair<string,int> s in textCount)
            {
                string toDisplay = string.Format(format, s.Key, s.Value);

                Console.WriteLine(toDisplay);
                
            }

                Console.Read();
        }
    }
}
