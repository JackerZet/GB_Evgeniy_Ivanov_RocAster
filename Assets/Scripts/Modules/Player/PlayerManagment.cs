using Logic.Generic;
using UnityEngine;

namespace Logic.Player
{
    public class PlayerManagment : Moving
    {   
        public Vector2 Direction { get; private set; }

        private const float Delay = 0.15f;

        public PlayerManagment(Rigidbody2D rigidbody, float speed) : base(rigidbody, speed) { }
      
        public override void Move(Vector2 direction = new Vector2())
        {
            direction = new Vector2(Input.GetAxis(GameData.Horizontal), Input.GetAxis(GameData.Vertical));
            
            Direction = Vector2.Lerp(Direction, Speed * Time.deltaTime * direction, Delay);

            Rigidbody.velocity = Speed * Time.deltaTime * direction;
        }
    }     
}
