namespace Desafio_POO.src.Entities
{
    public abstract class Hero
    {
    public Hero(string Name, int Level, string HeroType, int HP, int MP)
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        this.HP = HP;
        this.MP = MP;

    }
        public string Name;
        public int Level;
        public string HeroType;
        public int HP;
        public int MP;

        public Hero(){

            }   
        public override string ToString(){
            return this.Name + " "+ this.Level + " " + this.HeroType;
        }
    
        public virtual string Attack(){
            return this.Name + " Atacou com sua espada";

        }
    }
}