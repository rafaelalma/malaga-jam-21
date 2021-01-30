using UnityEngine;

public class GenerateObstaclesBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;

    public void Generate(float min, float max, float step)
    {
        for (float f = min; f <= max; f += step)
        {
            Vector2 position = new Vector2(f, min);

            InstantiateObstacle(position);
        }

        for (float f = min; f <= max; f += step)
        {
            Vector2 position = new Vector2(f, max);

            InstantiateObstacle(position);
        }

        for (float f = min; f <= max; f += step)
        {
            Vector2 position = new Vector2(min, f);

            InstantiateObstacle(position);
        }

        for (float f = min; f <= max; f += step)
        {
            Vector2 position = new Vector2(max, f);

            InstantiateObstacle(position);
        }
    }

    private void InstantiateObstacle(Vector2 position)
    {
        Instantiate(obstaclePrefab, position, Quaternion.identity, transform);
    }
}