using UnityEngine;

public class LevelConstructor : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] float min, max, step;

    private void Start()
    {
        for (float f = min; f <= max; f += step)
        {
            Vector2 position = new Vector2(f, min);

            Instantiate(prefab, position, Quaternion.identity);
        }

        for (float f = min; f <= max; f += step)
        {
            Vector2 position = new Vector2(f, max);

            Instantiate(prefab, position, Quaternion.identity);
        }

        for (float f = min; f <= max; f += step)
        {
            Vector2 position = new Vector2(min, f);

            Instantiate(prefab, position, Quaternion.identity);
        }

        for (float f = min; f <= max; f += step)
        {
            Vector2 position = new Vector2(max, f);

            Instantiate(prefab, position, Quaternion.identity);
        }
    }
}