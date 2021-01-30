using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] float min;
    [SerializeField] float max;
    [SerializeField] float step;

    private GenerateObstaclesBehaviour generateObstaclesBehaviour;
    private GenerateEnemiesBehaviour generateEnemiesBehaviour;
    private GenerateSemiObstaclesBehaviour generateSemiObstaclesBehaviour;

    private void Awake()
    {
        generateObstaclesBehaviour = GetComponent<GenerateObstaclesBehaviour>();
        generateEnemiesBehaviour = GetComponent<GenerateEnemiesBehaviour>();
        generateSemiObstaclesBehaviour = GetComponent<GenerateSemiObstaclesBehaviour>();
    }

    private void Start()
    {
        generateObstaclesBehaviour.Generate(min, max, step);

        generateEnemiesBehaviour.Generate(min, max, step);

        generateSemiObstaclesBehaviour.Generate(min, max, step);
    }
}