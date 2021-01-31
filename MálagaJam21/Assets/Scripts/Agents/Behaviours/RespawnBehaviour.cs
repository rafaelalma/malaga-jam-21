using UnityEngine;

public class RespawnBehaviour : MonoBehaviour
{
    private Vector2 respawnPosition;

    public void SetRespawnPosition(Vector2 position)
    {
        respawnPosition = position;
    }

    public void Respawn()
    {
        SoundManager.Instance.PlaySound(SoundManager.Sound.PlayerRespawn);

        CinemachineShaker.Instance.ShakeCamera(7f, 0.2f);
        ChromaticAberrationEffect.Instance.SetWeight(1f);

        transform.position = respawnPosition;
    }
}