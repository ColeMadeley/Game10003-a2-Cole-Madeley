// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;


// The namespace your code is in.
namespace Game10003
{

    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        int[] myArrayX = new int[2];
        int[] myArrayY = new int[3];

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(600, 800);
            Window.TargetFPS = 60;
            Window.SetTitle("The Window");
            myArrayX[0] = 300;
            myArrayX[1] = 200;
            myArrayY[0] = 400;
            myArrayY[1] = 195;
            myArrayY[2] = 200;

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Clear previous image
            Window.ClearBackground(Color.OffWhite);

            if (Input.IsKeyboardKeyDown(KeyboardInput.A))
            {
                DrawCircle(myArrayX[0], myArrayY[0]);
            }

            if (Input.IsKeyboardKeyDown(KeyboardInput.S))
            {
                DrawCrosshair(myArrayX[1], myArrayY[1]);
            }

            if (Input.IsKeyboardKeyDown(KeyboardInput.D))
            {
                DrawPumpkin(myArrayX[1], myArrayY[2]);
            }

            if (Input.IsKeyboardKeyDown(KeyboardInput.F))
            {
                DrawSquare(myArrayX[1], myArrayY[2]);
            }

            if (Input.IsKeyboardKeyDown(KeyboardInput.G))
            {
                DrawCapsule(myArrayX[1], myArrayY[2]);
            }

            if (Input.IsKeyboardKeyDown(KeyboardInput.H))
            {
                DrawQuad(myArrayX[1], myArrayY[2]);
            }
            // Draw the circle in the center of the window

        }

        void DrawCrosshair(int x, int y)
        {

            // Set crosshair color
            Draw.LineColor = Color.Red;
            Draw.LineSize = 3;
            // Draw a crosshair at position (x,y) ±25 pixels
            for (int i = 0; i < 3; i++)
            {
                Draw.Line(x - 25, y, x + 25, y); // Horizontal line
                Draw.Line(x, y - 25, x, y + 25); // Vertical line
                x += 100;
                y += 100;
            }
        }
        void DrawCircle(int x, int y)
        {
            // Set crosshair color
            for (int i = 0; i < 3; i++)
            {
                Draw.FillColor = Color.Green;
                Draw.Circle(x, y, 25);
                x += 100;
                y += 100;
            }
        }

        void DrawPumpkin(int x, int y)
        {
            Draw.FillColor = Color.Black;
            Draw.Ellipse(x, y, x + 100, y + 10);

            Draw.FillColor = Color.Red;
            Draw.Triangle(x - 10, y + 10, x + 10, y + 10, x, y - 30);
            Draw.Triangle(x - 60, y - 40, x - 40, y + -40, x - 50, y - 80);
            Draw.Triangle(x + 40, y - 40, x + 60, y + -40, x + 50, y - 80);

            Draw.Line(x + 75, y + 55, x - 75, y + 55);
            Draw.Line(x + 75, y + 55, x + 90, y + 20);
            Draw.Line(x - 75, y + 55, x - 90, y + 20);
        }

        void DrawSquare(int x, int y)
        {
            Draw.FillColor = Color.Yellow;
            Draw.Square(x + 300, y + 20, 70);
        }

        void DrawCapsule(int x, int y)
        {
            Draw.FillColor = Color.Cyan;
            Draw.Capsule(x + 200, y + 159, x + 250, y + 200, 50);

        }

        void DrawQuad(int x, int y)
        {
            Draw.FillColor = Color.Gray;
            Draw.Quad(x + 37, y + 24, x + 76, y + 140, x + 190, y + 35, x + 178, y + 200);
        }


    }
}
