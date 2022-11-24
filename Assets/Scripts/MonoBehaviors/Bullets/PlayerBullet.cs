using System;

namespace BehaviorRealizations
{
    public class PlayerBullet : Bullet
    {
        protected override void SetTypeToIgnore()
        {
            _typesToIgnore = new Type[]
            {
                typeof(Player),
            };
        }
    }
}
