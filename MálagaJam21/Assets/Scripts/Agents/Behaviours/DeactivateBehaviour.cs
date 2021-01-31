using UnityEngine;

public class DeactivateBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject enemyParticles;

    public void Deactivate()
    {
        SoundManager.Instance.PlaySound(SoundManager.Sound.EnemyDeactivate);

        Instantiate(enemyParticles, transform.position, Quaternion.identity);

        CinemachineShaker.Instance.ShakeCamera(5f, 0.1f);
        ChromaticAberrationEffect.Instance.SetWeight(1f);

        gameObject.SetActive(false);
    }
}