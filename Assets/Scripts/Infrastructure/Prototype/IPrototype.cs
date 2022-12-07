
using System;
using UnityEditor.PackageManager;

namespace Logic.Infrastructure.Prototype
{
    public interface IPrototype
    {
        public IPrototype ShallowCopy();
        public IPrototype DeepCopy();
    }
}
