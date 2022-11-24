using Logic.Interfaces;

namespace BehaviorRealizations
{
    public interface IHasMoving
    {
        IMovable Movable { get; }
    }
    public interface IHasHealth
    {
        IHealth Health { get; }
    }
    public interface IHasHealthChanger
    {
        IHealthChanger HealthChanger { get; }
    }
}
