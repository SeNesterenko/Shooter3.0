using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    [SerializeField] private float _speed = 30;
    [SerializeField] private float _rotationSpeed = 100;

    private void Update()
    {
        var verticalInput = Input.GetAxis("Vertical");
        var horizontalInput = Input.GetAxis("Horizontal");

        var step = Time.deltaTime * _speed;
        var rotationAngle = Time.deltaTime * _rotationSpeed;
        
        transform.Translate(Vector3.forward * _speed * verticalInput);
        transform.Rotate(Vector3.up, rotationAngle * horizontalInput);
    }
}
