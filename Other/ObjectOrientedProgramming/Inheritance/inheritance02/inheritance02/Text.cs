﻿using System;

namespace inheritance02
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("we added a link to " + url);

        }

    }
}