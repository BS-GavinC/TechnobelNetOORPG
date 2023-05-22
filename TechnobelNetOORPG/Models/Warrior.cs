using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnobelNetOORPG.Interfaces;

namespace TechnobelNetOORPG.Models
{
    public class Warrior : Personnage, IMelee, ITank
    {
        public Warrior(string name, int hP, int attack) : base(name, hP, attack)
        {
            group += MeleeAttack;
        }

        delegate void Group(Personnage ennemy);

        Group group = null;

        public double ResistanceBuff { get ; set ; }

        public void MeleeAttack(Personnage ennemy)
        {
            
            ennemy.HP -= Attack;
            Console.WriteLine($"{Name} lance une attaque au corps a corps sur {ennemy.Name}"
                + $" lui infligeant {Attack} points de degat et le laissant à {ennemy.HP} points de vie.");
        }

        public void Resist()
        {
            ResistanceBuff += 0.05;
        }

        public void AddAttacker(Personnage allies) 
        {
            if (allies is IRange)
            {
                IRange persoRange = (IRange)allies;
                group += persoRange.RangeAttack;
            }
            else if(allies is IMelee)
            {
                IMelee persoMelee = (IMelee)allies;
                group += persoMelee.MeleeAttack;
            }
        }

        public void RemoveAttacker(Personnage allies)
        {
            if (allies is IRange)
            {
                IRange persoRange = (IRange)allies;
                group -= persoRange.RangeAttack;
            }
            else if (allies is IMelee)
            {
                IMelee persoMelee = (IMelee)allies;
                group -= persoMelee.MeleeAttack;
            }
        }

        public void GroupAttack(Personnage ennemy)
        {
            group(ennemy);
        }
    }
}
