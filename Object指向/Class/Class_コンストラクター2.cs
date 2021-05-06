using System;

namespace Class_コンストラクター2
{
    class Class_コンストラクター2
    {
        static void Main(string[] args)
        {
            var adventurer = new Adventurer("冒険者");
            var wizard = new Adventurer("ウィザード");
            var crusader = new Adventurer("クルセイダー");
            var priest = new Adventurer("プリースト");

            Adventurer[] party = { adventurer, wizard, crusader, priest };

            foreach (Adventurer player in party)
            {
                player.Attack();
            }
        }
    }

    public class Adventurer
    {
        private string job;

        public Adventurer(string job)
        {
            this.job = job;
        }
        public void Attack()
        {
            Console.WriteLine(job + "は魔王を攻撃した");
        }
    }
}

