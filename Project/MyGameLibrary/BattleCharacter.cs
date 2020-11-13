using System;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code {
  public class BattleCharacter : Character {
    public int Health { get; set; }
    public int MaxHealth { get;  set; }

    public event Action<int> AttackEvent;

    public BattleCharacter(Vector2 initPos, Collider collider) : base(initPos, collider) {
      MaxHealth = 20;
      Health = MaxHealth;
    }

    /// <summary>
    /// adds the health modification depending on the amount and strenght (amount * strength = damage)
    /// </summary>
    public void OnAttack(int amount, int strength) {
      AttackEvent((int)(amount * strength));
    }

    /// <summary>
    /// changes the health either damage of healing
    /// </summary>
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
        /// <summary>
        ///  resets the health of player on a global scale
        /// </summary>
        /// <param name="per_health"></param>
        public void ResetWithPersistents(int per_health)
        {
            Health = per_health;
        }
  }
}
