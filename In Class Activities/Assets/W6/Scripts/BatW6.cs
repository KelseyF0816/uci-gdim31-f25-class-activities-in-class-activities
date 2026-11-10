using UnityEngine;

public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;

    private Transform _target;

    public void StartChasing(Transform target)
    {
        _target = target;
    }

    public void StopChasing()
    {
        _target = null;
    }

    private void Update()
    {
        if (_target != null)
        {
            transform.position = Vector3.MoveTowards(
                transform.position, _target.position, _speed * Time.deltaTime);
        }
    }
}
