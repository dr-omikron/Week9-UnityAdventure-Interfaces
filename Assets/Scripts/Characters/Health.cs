using UnityEngine;

namespace Characters
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private int _maxHealth;

        private int _health;

        private void Awake()
        {
            _health = _maxHealth;
        }

        public void TakeDamage(int damage)
        {
            if(damage <= 0)
                Debug.Log("Damage can't be less or equal to zero");

            _health -= damage;

            if (_health <= 0)
                _health = 0;
        }

        public bool IsDead() => _health <= 0;

        public void Kill() => _health = 0;
    }
}
