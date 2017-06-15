using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mudZ.Core.Model.Domain.Player
{
    public class PlayerFactory
    {
        public static IPlayer Create(string name, PlayerType playerType)
        {
            switch (playerType)
            {
                case PlayerType.Medic:
                    return new Medic(name);
                case PlayerType.ArmyVet:
                    return new ArmyVet(name);
                default:
                    throw new NotImplementedException("Sorry, this type isn't supported.");
              
            }
        }

       
    }
}