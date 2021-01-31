using UnityEngine;

public class GenerateEnemiesBehaviour : MonoBehaviour
{
    [SerializeField] private EnemyController enemyPrefab;
    [SerializeField] private int amount;
    [SerializeField] private int minWaypoints;
    [SerializeField] private int maxWaypoints;

    public void Generate(float min, float max, float step)
    {
        min += step;
        max -= step;

        for (int i = 0; i < amount; i++)
        {
            Vector3 initialPosition = new Vector3(max, max, 0);

            EnemyController enemy = Instantiate(enemyPrefab, initialPosition, Quaternion.identity, transform);
            enemy.Initialize(min, max, minWaypoints, maxWaypoints);
        }
    }
}