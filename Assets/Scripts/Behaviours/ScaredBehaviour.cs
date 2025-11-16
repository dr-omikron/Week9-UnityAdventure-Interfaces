using Characters;
using Interfaces;

namespace Behaviours
{
    public class ScaredBehaviour : IBehaviour
    {
        private readonly Health _health;

        public ScaredBehaviour(Health health)
        {
            _health = health;
        }

        public void Enter() => _health.Kill();

        public void Update() {}

        public void Exit() {}
    }
}
