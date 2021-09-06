﻿using System;
using MysticHorizonsLib;

namespace MysticHorizons
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCharacter player = new("Hero", health: 100);

            // Simulate a hit to HP:
            player.Health.Value = 25;

            player.AboutMe();

            Console.WriteLine("The boss you are looking for is in another dungeon..."); // FIXME: Remove when any form of gameplay is actually implemented.
        }
    }
}
