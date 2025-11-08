using Game;
using UnityEngine;

namespace Characters
{
    public class PlayerCharacter : Character
    {
        private InputManager _inputManager;
        private void Update()
        {
            Vector3 direction = GetInputDirection();
            ProcessMove(direction);
        }

        public void Initialize(InputManager inputManager)
        {
            _inputManager = inputManager;
        }

        private Vector3 GetInputDirection()
        {
            float xDirection = _inputManager.XMovementInput;
            float zDirection = _inputManager.ZMovementInput;

            Vector3 direction = new Vector3(xDirection, 0, zDirection).normalized;
            return direction;
        }
    }
}
