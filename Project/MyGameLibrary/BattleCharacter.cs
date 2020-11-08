using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code {
  public class BattleCharacter : Character {
    public int Health { get; set; }
    public int MaxHealth { get;  set; }
    private int strength;

    public event Action<int> AttackEvent;

    public BattleCharacter(Vector2 initPos, Collider collider) : base(initPos, collider) {
      MaxHealth = 20;
      strength = 2;
      Health = MaxHealth;
    }

    public void OnAttack(int amount) {
      AttackEvent((int)(amount * strength));
    }

    public void AlterHealth(int amount, string act = null) {
            if (act == "heal")
            {

                if (Health <= (MaxHealth - amount))
                {
                    Health += amount;
                }
                else
                {
                    Health += (MaxHealth - Health);
                }
            }
            else
            {
                Health += amount;
            }

    }
    public void ResetWithPersistents(int per_health)
        {
            Health = per_health;
        }
  }
}
