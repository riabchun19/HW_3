﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLambdaExpressions
{ 
    class Program
    {   // 3. *Дан фрагмент программы:
        // а) Свернуть обращение к OrderBy с использованием лямбда-выражения$        
        static void Main()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
            {"four",4 },
            {"two",2 },
            { "one",1 },
            {"three",3 },
            };

            var d = dict.OrderBy(e => e.Value);

            foreach (var pair in d)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }
            Console.ReadKey();
        }
    } 
}
