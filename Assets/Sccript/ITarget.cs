interface ITarget
{
   TargetType TargetType { get; }
}
public enum TargetType
{
    EnemyOneShot,
    EnemyAllRange,
    Player,
}
