using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mudZ.Core.Model.Domain.Player;

namespace mudZ.Core.Model.Domain
{
    public class BaseGameObject : IGameObject
    {
        public string Name { get; set; }
        public double Dexterity { get; private set; }
        public double HitPoints { get; private set; }
        public GameObjectTypes GameObjectType { get; private set; }
        public bool IsDestructbable { get; private set; }

        public virtual void TakeDamage(double dmg)
        {
            HitPoints = HitPoints - dmg;
        }

        public virtual void Heal(double health)
        {
            HitPoints = HitPoints + health;
        }

    }
}
