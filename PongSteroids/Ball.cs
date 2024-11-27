using System.Numerics;
using Raylib_cs;

namespace PongSteroids
{
    public class Ball : GameObject
    {
        private Texture2D ballTex;
        private Vector2 size;
        private Vector2 origin;
        public override void Start()
        {
            ballTex = Raylib.LoadTexture("assets/ball.png");
            origin.X = size.X /2f;
            origin.Y = size.Y /2f;

            float centerX = (Raylib.GetScreenWidth() / 2f) - origin.X;
            float centerY = (Raylib.GetScreenHeight() / 2f) - origin.Y;


            Position.X = centerX;
            Position.Y = centerY;
        }
        public override void Draw()
        {
            //Raylib.DrawTextureEx(ballTex, Position, 0.0f, 0.1f, Color.White);
            Rectangle source = new Rectangle(0, 0, ballTex.Width, ballTex.Height);
            Rectangle destination = new Rectangle(Position.X, Position.Y, size.X, size.Y);


            Raylib.DrawTexturePro(ballTex, source, destination, origin, 0, Color.White);
        }
    }
}
