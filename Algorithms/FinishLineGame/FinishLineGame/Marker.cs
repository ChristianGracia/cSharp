﻿using System;

namespace FinishLineGame
{
    public class Marker
    {
        public int Position;
        public string Name;
        public bool Stopped;

        public Marker(string name)
        {
            this.Position = 0;
            this.Name = name;
            this.Stopped = false;
        }

        public void Move(int spaces)
        {
            this.Position += spaces;
        }
    }
}