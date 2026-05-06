public class EntityDiedEventArgs
{ 
    public enum EntityID
    {
        Player,
        Enemy
    }

    public EntityID id;
    public int level;
}
