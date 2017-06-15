using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mudZ.Core.Model.Domain.Player
{
    public interface IPlayer
    {
        PlayerType PlayerType { get; set; }
        void Repair();
        void Attack();
        void Heal();
        void Negotiate();
        void Move();
    }
}
