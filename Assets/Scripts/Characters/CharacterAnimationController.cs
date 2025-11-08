using UnityEngine;

namespace Characters
{
    public class CharacterAnimationController : MonoBehaviour
    {
        private readonly int _isMoving = Animator.StringToHash("IsMoving");

        [SerializeField] private Animator _animator;
        [SerializeField] private Character _character;

        private void Update()
        {
            UpdateAnimationFlags();
        }

        private void UpdateAnimationFlags()
        {
            bool isMoving = _character.IsMoving();
            SetIsMoving(isMoving);
        }

        private void SetIsMoving(bool value) => _animator.SetBool(_isMoving, value);
    }
}
