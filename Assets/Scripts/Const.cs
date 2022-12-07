using UnityEngine;

public static class Const
{
    public const string Horizontal = nameof(Horizontal);
    public const string Vertical = nameof(Vertical);

    public const string ScriptableObjectsPath = "SO/";
    public static class Keys
    {
        public static readonly KeyCode shoot = KeyCode.Mouse0;
    }
    public static class Layers
    {
        public const int PlayerLayer = 6;
    }
    public static readonly Vector2[] directions = new Vector2[]
    {
        Vector2.up,
        Vector2.down,
        Vector2.left,
        Vector2.right,
    };
}

