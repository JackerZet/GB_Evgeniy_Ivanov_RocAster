namespace Logic.Interfaces
{
    public interface IHealth
    {
        public int Health { get; }
        public void ChangeHealth(IHealthChanger healthChanger);
    }
}