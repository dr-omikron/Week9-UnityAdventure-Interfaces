using UnityEngine;

namespace Characters
{
    [RequireComponent(typeof(CharacterMover))]
    [RequireComponent(typeof(CharacterRotator))]

    public abstract class Character : MonoBehaviour
    {
        private CharacterRotator _rotator;
        private CharacterMover _mover;

        private void Awake()
        {
            _rotator = GetComponent<CharacterRotator>();
            _mover = GetComponent<CharacterMover>();
        }

        public void ProcessMove(Vector3 direction)
        {
            _mover.MoveTo(direction);
            _rotator.RotateTo(direction);
        }

        public bool IsMoving() => _mover.IsMoving();
    }
}
