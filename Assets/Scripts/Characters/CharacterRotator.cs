using UnityEngine;

namespace Characters
{
    public class CharacterRotator : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        private bool _isEnabled;

        private void Awake()
        {
            EnableRotations();
        }

        public void RotateTo(Vector3 direction)
        {
            if (direction.magnitude > 0 && _isEnabled)
                _target.rotation = Quaternion.LookRotation(direction);
        }

        public void EnableRotations() => _isEnabled = true;
        public void DisableRotations() => _isEnabled = false;
    }
}
