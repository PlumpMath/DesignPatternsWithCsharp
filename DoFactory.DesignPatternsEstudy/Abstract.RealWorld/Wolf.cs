﻿using System;

namespace Abstract.RealWorld
{
    /// <summary>
    /// The 'ProductB2' class
    /// </summary>
    public class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Bison
            Console.WriteLine(this.GetType().Name +
              " eats " + h.GetType().Name);
        }
    }
}
