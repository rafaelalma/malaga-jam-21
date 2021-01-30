using UnityEngine;

public class GeneratorController : MonoBehaviour
{
    [SerializeField] private float min;
    [SerializeField] private float max;
    [SerializeField] private float step;

    private GenerateObstaclesBehaviour generateObstaclesBehaviour;
    private GenerateEnemiesBehaviour generateEnemiesBehaviour;
    private GenerateSemiObstaclesBehaviour generateSemiObstaclesBehaviour;
    private GenerateWeaponBehaviour generateWeaponBehaviour;

    private void Awake()
    {
        generateObstaclesBehaviour = GetComponent<GenerateObstaclesBehaviour>();
        generateEnemiesBehaviour = GetComponent<GenerateEnemiesBehaviour>();
        generateSemiObstaclesBehaviour = GetComponent<GenerateSemiObstaclesBehaviour>();
        generateWeaponBehaviour = GetComponent<GenerateWeaponBehaviour>();
    }

    private void Start()
    {
        generateObstaclesBehaviour.Generate(min, max, step);

        generateEnemiesBehaviour.Generate(min, max, step);

        generateSemiObstaclesBehaviour.Generate(min, max, step);

        generateWeaponBehaviour.Generate(min, max, step);
    }
}