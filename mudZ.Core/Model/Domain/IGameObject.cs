
namespace mudZ.Core.Model.Domain
{
    public interface IGameObject
    {
        string Name { get; }

        double Dexterity { get; }
        double HitPoints { get; }

        GameObjectTypes GameObjectType { get; }

        bool IsDestructbable { get; }
    }
 }
