using UnityEngine;

public class GenerateWeaponBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject weaponPrefab;

    public void Generate(float min, float max, float step)
    {
        min = (min + step) / 2;
        max = (max - step) / 2;

        Vector3 randomPosition = new Vector3(Random.Range(min, max), Random.Range(min, max), 0);

        Instantiate(weaponPrefab, randomPosition, Quaternion.identity, transform);
    }
}