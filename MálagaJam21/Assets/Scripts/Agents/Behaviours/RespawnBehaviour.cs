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
        transform.position = respawnPosition;
    }
}