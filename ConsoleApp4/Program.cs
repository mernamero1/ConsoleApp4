namespace ConsoleApp4
{
    class player
    {
        public string Name { private get; init; }

        public int Health {get ; set ;}
        public  double exp { get; set; }
        
        public string Name {  get =>this. ;
            
            init; }

        public int Health {get ; set ;}
        public  double exp { get; set; }


        public player(string name=" ", int health = 10, double exp = 100)
        {
            this.name = name;
            this.health = health;
            this.exp = exp;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            player p1 = new("merna" , 100 , 105);
            player p2 = new();
        }
    }
}
