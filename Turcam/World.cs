﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turcam.Controller;

namespace Turcam
{
    public static class World
    {
        public static ControlBoard ControlBoard { get; set; }
        public static List<Axis> Axes { get; set; }
        public static List<Motor> Motors { get; set; }

        public static void Initialize()
        {
            if (Axes == null)
            {
                Axes = new List<Axis>()
                {
                    new Axis('X'),
                    new Axis('Y'),
                    new Axis('Z'),
                    new Axis('A'),
                    new Axis('B')
                };
            }

            if (Motors == null)
            {
                Motors = new List<Motor>()
                {
                    new Motor(Axes[0]),
                    new Motor(Axes[1]),
                    new Motor(Axes[2]),
                    new Motor(Axes[3]),
                    new Motor(Axes[4])
                };
            }

            Controllers.Initialize();
        }
    }
}
