using UnityEngine;

public class LevelConstructor : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] float min, max, step;

    private void Start()
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