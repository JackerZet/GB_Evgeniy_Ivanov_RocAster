using Logic.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Logic.Player
{
    public class PlayerManagment : IMovable
    {       
        public float Speed { get; }
        public Vector2 Direction { get; private set; }

        private const float Delay = 0.15f;
        private readonly Rigidbody2D _rigidbody;
        public PlayerManagment(Rigidbody2D rigidbody, float speed)
        {
            _rigidbody = rigidbody;
            Speed = speed;
        }
      
        public void Move(float horisontalAxis, float verticalAxis, float deltaTime = 1)
        {
            //float curentSpeed = Speed * Time.deltaTime;
            Direction = Vector2.Lerp(Direction, Speed * Time.deltaTime * new Vector2(horisontalAxis, verticalAxis), Delay);
            _rigidbody.velocity = Direction;
        }
    }
}
