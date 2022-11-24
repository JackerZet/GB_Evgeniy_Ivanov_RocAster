using Logic.Generic;
using Logic.Interfaces;
using UnityEngine;

namespace Logic.Bullets
{
    public class BulletFlying : Moving
    {
        //public Vector2 Direction { get; set; }
        public BulletFlying(Rigidbody2D rigidbody, float speed) : base(rigidbody, speed) 
        { 
        }
        public override void Move(Vector2 direction = new Vector2())
        {

            Rigidbody.velocity = Speed * Time.deltaTime * direction;
        }
    }
}
