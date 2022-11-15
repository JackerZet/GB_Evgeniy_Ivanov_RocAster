namespace Logic.Interfaces
{
    public interface IShooting : IHealthChanger
    {
        public IShootable Shootable { get; }
        public void Shoot();
    }
}
