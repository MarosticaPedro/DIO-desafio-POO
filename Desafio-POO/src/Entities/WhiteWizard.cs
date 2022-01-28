namespace Desafio_POO.src.Entities
{
    public class WhiteWizard : Hero
    {
         public WhiteWizard(string Name, int Level, string HeroType, int HP, int MP)
         {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
    
         }
                public override string Attack(){
            return this.Name + " Lançou magia";
    
        }
            public string Attack(int Bonus){

                if (Bonus>6){
                    return this.Name + " Lançou magia super efetiva com bonus de ataque de " + Bonus ;
                }else {
                     return this.Name + " Lançou magia fraca com bonus de ataque de " + Bonus ;
                }
    }}

}