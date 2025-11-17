using UnityEngine;

namespace Characters
{
    public class CharacterMover : MonoBehaviour
    {
        [SerializeField] private CharacterController _characterController;
        [SerializeField] private float _moveSpeed;

        private bool _isEnabled;

        private void Awake()
        {
            EnableMovement();
        }

        public void MoveTo(Vector3 direction)
        {
            if (_isEnabled == false)
                return;

            _characterController.Move(direction * _moveSpeed * Time.deltaTime);
        }

        public bool IsMoving() => _characterController.velocity.magnitude > 0;

        public void EnableMovement() => _isEnabled = true;
        public void DisableMovement() => _isEnabled = false;
    }
}
