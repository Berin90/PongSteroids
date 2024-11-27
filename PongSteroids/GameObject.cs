using System.Numerics;

namespace PongSteroids
{
    public class GameObject
    {
        public Vector2 Position;
        public virtual void Update(float dt) { }
        public virtual void Draw() { }
        public virtual void Start() { }


    }
}
