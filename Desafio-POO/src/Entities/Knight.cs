namespace Desafio_POO.src.Entities
{
      public class Knight : Hero
    {
         public Knight(string Name, int Level, string HeroType, int HP, int MP)
         {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
    
         }
                public override string Attack(){
            return this.Name + " Golpeou com sua espada";
    
        }
         
            public string Attack(int Bonus){

                if (Bonus>6){
                    return this.Name + " Deu um golpe critico com a espada com bonus de ataque de" + Bonus ;
                }else {
                     return this.Name + " Deu um golpe fraco com a espada com bonus de ataque de " + Bonus ;
                }
         }
    }
}