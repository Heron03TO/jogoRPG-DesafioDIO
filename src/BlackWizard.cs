namespace Jogo_rpg.src
{
    public class BlackWizard : Hero
    {
         public BlackWizard(string Name, int Level, string HeroType, int HP, int MP) 
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;     
        }
        public override string Attack()
        {
            return this.Name + " Sumonou um Minotauro e lançou magia de drenagem de HP";
        }
    }
}