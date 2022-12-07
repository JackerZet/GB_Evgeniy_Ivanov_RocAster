using Logic.Generic;
using System;
using UnityEngine;
namespace Logic.Enemies.UFO
{
    public class UFOMoving : Moving
    {
        private readonly Enumerator _enumeratorForAction;
        private const float time = 1;

        public UFOMoving(Rigidbody2D rigidbody, float speed) : base(rigidbody, speed)
        {
            _enumeratorForAction = new Enumerator(time);
        }

        public override void Move(Vector2 direction = new Vector2())
        {
            if (_enumeratorForAction.CanDo())
            {
                var random = new System.Random();
                direction = Const.directions[random.Next(0, 3)];
           
                Rigidbody.velocity = Speed * Time.deltaTime * direction; 
            }
        }
    }
}