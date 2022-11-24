using Logic.Generic;
using System;

namespace Logic.Bullets
{
    public class BulletHitting : Hitting
    {
        public BulletHitting(int damage, params Type[] typesIgnore) : base(damage, typesIgnore)
        { }
    }
}
