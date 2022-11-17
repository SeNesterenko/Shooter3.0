using System;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField] private float _speed = 1;

    private Transform _target;

    public void Initialize(Transform target)
    {
        _target = target;
    }

    private void Update()
    {
        var step = Time.deltaTime * _speed;
        
        transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, step);
        transform.LookAt(_target.transform);
    }
}
