using UnityEngine;

public class GenerateSemiObstaclesBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject semiObstaclePrefab;
    [SerializeField] private int amount;

    public void Generate(float min, float max, float step)
    {
        min += step;
        max -= step;

        for (int i = 0; i < amount; i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range(min, max), Random.Range(min, max), 0);

            Instantiate(semiObstaclePrefab, randomPosition, Quaternion.identity, transform);
        }
    }
}