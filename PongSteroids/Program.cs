using PongSteroids;
using Raylib_cs;

namespace HelloWorld;

class Program
{
    public static void Main()
    {
        Raylib.InitWindow(800, 480, "Hello World");
        float x = 100; //player
        float y = 100;
        float speed = 100;

        GameObject ball = new Ball();
        ball.Start();

        while (!Raylib.WindowShouldClose())
        {
            float delta = Raylib.GetFrameTime();
            float movement = speed * delta;

            if (Raylib.IsKeyDown(KeyboardKey.W))
            {
                //Up Movement
                y -= movement;
                
            }
            if (Raylib.IsKeyDown(KeyboardKey.S))
            {
                //Down Movement
                y += movement;
            }

            // DRAWING 
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);

            Rectangle border = new Rectangle(0, 0, 800, 480);
            Raylib.DrawRectangle((int)x, (int)y, 20,80, Color.Black);
            ball.Draw();
            Raylib.DrawRectangleLinesEx(border, 10, Color.Blue);

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}