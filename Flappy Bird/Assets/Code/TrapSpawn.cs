using UnityEngine;

public class TrapSpawn : MonoBehaviour
{
    [SerializeField] private GameObject Trap;

    [SerializeField] private float _maxTime = 1;
    [SerializeField] private float _height;

    private float _timer = 0;

    private void Start()
    {
        _timer = 2;
    }

    void Update()
    {
        SpawnAndDestroy();
    }

    private void SpawnAndDestroy()
    {
        if (_timer > _maxTime)
        {
            GameObject newTrap = Instantiate(Trap);
            newTrap.transform.position = transform.position + new Vector3(0, Random.Range(-_height, _height), 0);

            Destroy(newTrap, 10);

            _timer = 0;
        }

        _timer += Time.deltaTime;
    }
}
