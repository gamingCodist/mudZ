namespace mudZ.Core.Model.Domain.Player
{
    public class Medic:Player
    {
        public Medic(string name)
        {
            Name = name;
            PlayerType = PlayerType.Medic;
        }
        public override void Repair()
        {
            throw new System.NotImplementedException();
        }

        public override void Attack()
        {
            throw new System.NotImplementedException();
        }

        public override void Heal()
        {
            throw new System.NotImplementedException();
        }

        public override void Negotiate()
        {
            throw new System.NotImplementedException();
        }

        public override void Move()
        {
            throw new System.NotImplementedException();
        }
    }
}
