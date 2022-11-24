using Logic.Enemies;
using Logic.Interfaces;
using UnityEngine;

namespace Logic.Infrastructure.FactoryMethod
{
    public interface ICreator
    {
        T FactoryMethod<T>(T gameObject) where T : MonoBehaviour, IInitable;

    }
}
