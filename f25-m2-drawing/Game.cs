// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            //Sets Window Title
            Window.SetTitle("My Cool Title");
            //Sets Window Size
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            //Sets Background Color
            Window.ClearBackground(Color.OffWhite);
            //Mouse follow thingy color fill, line color, line size
            Draw.FillColor = Color.Red;
            Draw.LineColor = Color.Black;
            Draw.LineSize = 1;
            //tells to follow mouse
            Draw.Circle(Input.GetMouseX(), Input.GetMouseY(), 25);
        }
    }

}
