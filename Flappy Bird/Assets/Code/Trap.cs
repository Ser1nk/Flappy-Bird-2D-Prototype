using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }
}
