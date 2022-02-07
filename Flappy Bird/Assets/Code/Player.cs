using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private GameManager _gameMananger;

    [SerializeField] private Text _textScore;

    [SerializeField] private float _velocity = 1;

    private Rigidbody2D _rigidbody;

    private int _score = 0;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Jump()
    {
        _rigidbody.velocity = Vector2.up * _velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _gameMananger.GameOver();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ScoreZone"))
        {
            _score++;

            _textScore.text = _score.ToString();
        }
    }
}
