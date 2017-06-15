using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mudZ.Core.Model.Domain.Player
{
    public abstract class Player: BaseGameObject, IPlayer
    {
        public PlayerType PlayerType { get; set; }
        public abstract void Repair();
        public abstract void Attack();
        public abstract void Heal();
        public abstract void Negotiate();
        public abstract void Move();
    }
}
