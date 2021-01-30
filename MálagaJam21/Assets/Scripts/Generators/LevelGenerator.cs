using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private EnemyController enemyPrefab;
    [SerializeField] private GameObject playerPrefab;
    [SerializeField] private GameObject weaponPrefab;
    [SerializeField] private GameObject goalPrefab;
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private GameObject semiObstaclePrefab;
    [SerializeField] float min;
    [SerializeField] float max;
    [SerializeField] float step;

    private void Start()
    {
        EnemyController enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        enemy.Initialize(min + 0.25f, max - 0.25f);

        GenerateBorders();
    }

    private void GenerateBorders()
    {
        for (float f = min; f <= max; f += step)
        {
            Vector2 position = new Vector2(f, min);

            Instantiate(obstaclePrefab, position, Quaternion.identity);
        }

        for (float f = min; f <= max; f += step)
        {
            Vector2 position = new Vector2(f, max);

            Instantiate(obstaclePrefab, position, Quaternion.identity);
        }

        for (float f = min; f <= max; f += step)
        {
            Vector2 position = new Vector2(min, f);

            Instantiate(obstaclePrefab, position, Quaternion.identity);
        }

        for (float f = min; f <= max; f += step)
        {
            Vector2 position = new Vector2(max, f);

            Instantiate(obstaclePrefab, position, Quaternion.identity);
        }
    }
}