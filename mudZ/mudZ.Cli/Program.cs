using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mudZ.Core.Model.Domain.Player;

namespace mudZ.Cli
{
    public class Program
    {
        static void Main(string[] args)
        {
            var gary = PlayerFactory.Create("Gary", PlayerType.ArmyVet);

           
        }
    }
}
