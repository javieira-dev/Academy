﻿using System;
using MetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos.Entities
{
    class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

    }
}
