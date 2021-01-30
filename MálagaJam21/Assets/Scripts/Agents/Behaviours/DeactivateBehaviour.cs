using UnityEngine;

public class DeactivateBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject enemyParticles;

    public void Deactivate()
    {
        Instantiate(enemyParticles, transform.position, Quaternion.identity);
        gameObject.SetActive(false);
    }
}