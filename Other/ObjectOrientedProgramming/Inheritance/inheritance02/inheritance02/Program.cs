﻿using System;

namespace inheritance02
{
    //: points to inherit from Presentation Object
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("we added a link to " + url);

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
