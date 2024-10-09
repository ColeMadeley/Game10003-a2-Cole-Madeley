
using System;
using System.Numerics;



namespace Game10003
{

    
    public class Game
    {
        
        //Declare arrays for x and y coordinates
        int[] myArrayX = new int[2];
        int[] myArrayY = new int[3];

        public void Setup()
        {
            //Create Window within set parameters 
            Window.SetSize(600, 800);
            Window.TargetFPS = 60;
            Window.SetTitle("Drawing Window");

            //Initialize integer values within arrays
            myArrayX[0] = 300;
            myArrayX[1] = 200;
            myArrayY[0] = 400;
            myArrayY[1] = 195;
            myArrayY[2] = 200;

        }

        public void Update()
        {
            //Clears previous version of window 
            Window.ClearBackground(Color.OffWhite);

            //If the user presses A, draw a circle using a function call
            if (Input.IsKeyboardKeyDown(KeyboardInput.A))
            {
                DrawCircle(myArrayX[0], myArrayY[0]);
            }

            //If the user presses S, draw a crosshair using a function call
            if (Input.IsKeyboardKeyDown(KeyboardInput.S))
            {
                DrawCrosshair(myArrayX[1], myArrayY[1]);
            }

            //If the user presses D, draw a pumpkin compound drawing using a function call
            if (Input.IsKeyboardKeyDown(KeyboardInput.D))
            {
                DrawPumpkin(myArrayX[1], myArrayY[2]);
            }

            //If the user presses F, draw a square using a function call
            if (Input.IsKeyboardKeyDown(KeyboardInput.F))
            {
                DrawSquare(myArrayX[1], myArrayY[2]);
            }

            //If the user presses G, draw a capsule using a function call
            if (Input.IsKeyboardKeyDown(KeyboardInput.G))
            {
                DrawCapsule(myArrayX[1], myArrayY[2]);
            }

            //If the user presses H, draw a quad using a function call
            if (Input.IsKeyboardKeyDown(KeyboardInput.H))
            {
                DrawQuad(myArrayX[1], myArrayY[2]);
            }

        }

        void DrawCrosshair(int x, int y) //Function call to draw crosshair using 2 passed ints
        {

            //Sets drawing colour and line thickness
            Draw.LineColor = Color.Red;
            Draw.LineSize = 2;

            // Draw a crosshair 3 times at a shifting position using a loop
            for (int i = 0; i < 3; i++)
            {
                Draw.Line(x - 19, y, x + 19, y); 
                Draw.Line(x, y - 19, x, y + 19); 

                //shift x and y coordinates every loop
                x += 100; 
                y += 100;
            }
        }
        void DrawCircle(int x, int y) //Function call to draw circle using 2 passed ints
        {
            //set drawing colour
            Draw.FillColor = Color.Green;
            
            //Draw a circle 3 times at a shifting position using a loop
            for (int i = 0; i < 3; i++)
            {
                Draw.Circle(x, y, 25);

                //shift x and y coordinates every loop
                x += 100;
                y += 100;
            }
        }

        void DrawPumpkin(int x, int y) //Function call to draw a pumpkin using 2 passed ints
        {
            //set colour for body of pumpkin
            Draw.FillColor = Color.Black;

            //Draw body of pumpkin at specific coordinates
            Draw.Ellipse(x, y, x + 100, y + 10);

            //Set colour and draw eyes and nose of pumpkin at specific coordinates
            Draw.FillColor = Color.Red;
            Draw.Triangle(x - 10, y + 10, x + 10, y + 10, x, y - 30);
            Draw.Triangle(x - 60, y - 40, x - 40, y + -40, x - 50, y - 80);
            Draw.Triangle(x + 40, y - 40, x + 60, y + -40, x + 50, y - 80);

            //Draw mouth of pumpkin at specific coordinates
            Draw.Line(x + 75, y + 55, x - 75, y + 55);
            Draw.Line(x + 75, y + 55, x + 90, y + 20);
            Draw.Line(x - 75, y + 55, x - 90, y + 20);
        }

        void DrawSquare(int x, int y) //Function call to draw square using 2 passed ints
        {
            //Set drawing colour and draw at a specific coordinate
            Draw.FillColor = Color.Yellow;
            Draw.Square(x + 300, y + 20, 70);
        }

        void DrawCapsule(int x, int y) //Function call to draw capsule using 2 passed ints
        {
            //Set drawing colour and draw at a specific coordinate
            Draw.FillColor = Color.Cyan;
            Draw.Capsule(x + 200, y + 159, x + 250, y + 200, 50);

        }

        void DrawQuad(int x, int y) //Function call to draw quad using 2 passed ints
        {
            //Set drawing colour and draw at a specific coordinate
            Draw.FillColor = Color.Gray;
            Draw.Quad(x + 37, y + 24, x + 76, y + 140, x + 190, y + 35, x + 178, y + 200);
        }


    }
}
