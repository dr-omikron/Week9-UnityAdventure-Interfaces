using UnityEngine;

namespace Characters
{
    public class CharacterMover : MonoBehaviour
    {
        [SerializeField] private CharacterController _characterController;
        [SerializeField] private float _moveSpeed;

        public void MoveTo(Vector3 direction) => _characterController.Move(direction * _moveSpeed * Time.deltaTime);
        public bool IsMoving() => _characterController.velocity.magnitude > 0;
    }
}
