using Logic.Generic;
using UnityEngine;

namespace Logic.Players
{
    public class PlayerMoving : Moving
    {   
        public Vector2 Direction { get; private set; }

        private const float Delay = 0.15f;

        public PlayerMoving(Rigidbody2D rigidbody, float speed) : base(rigidbody, speed) { }
      
        public override void Move(Vector2 direction = new Vector2())
        {
            direction = new Vector2(Input.GetAxis(Const.Horizontal), Input.GetAxis(Const.Vertical));
            
            Direction = Vector2.Lerp(Direction, Speed * Time.deltaTime * direction, Delay);

            Rigidbody.velocity = Speed * Time.deltaTime * direction;
        }
    }     
}
