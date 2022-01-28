namespace Desafio_POO.src.Entities
{
      public class Ninja : Hero
    {
         public Ninja(string Name, int Level, string HeroType, int HP, int MP)
         {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;

         }    
                public override string Attack(){
            return this.Name + " Lançou uma shuriken";
    
        }
            public string Attack(int Bonus){

                if (Bonus>6){
                    return this.Name + " Fez um acerto critico com bonus de ataque de " + Bonus ;
                }else {
                     return this.Name + " Fez um corte suave com bonus de ataque de " + Bonus ;
                }
         }
    }
}