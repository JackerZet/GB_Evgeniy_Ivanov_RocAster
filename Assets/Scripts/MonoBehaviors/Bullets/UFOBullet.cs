using System;

namespace BehaviorRealizations
{
    public class UFOBullet : Bullet
    {
        protected override void SetTypeToIgnore()
        {
            _typesToIgnore = new Type[]
            {
                typeof(UFO),
            };
        }
    }
}
