using UnityEngine;

public class WeaponController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        EnemyController enemy = collision.gameObject.GetComponent<EnemyController>();

        if (enemy != null)
        {
            enemy.Destroy();
        }
    }
}