using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private MoveBehaviour moveBehaviour;
    private RespawnBehaviour respawnBehaviour;
    private Vector2 moveDirection;

    private void Awake()
    {
        moveBehaviour = GetComponent<MoveBehaviour>();

        respawnBehaviour = GetComponent<RespawnBehaviour>();
        Vector2 initialPosition = new Vector2(transform.position.x, transform.position.y);
        respawnBehaviour.SetRespawnPosition(initialPosition);
    }

    private void Update()
    {
        float horizontalMovement = Input.GetAxisRaw("Horizontal");
        float verticalMovement = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(horizontalMovement, verticalMovement).normalized;
    }

    private void FixedUpdate()
    {
        moveBehaviour.Move(moveDirection);
    }

    public void Respawn()
    {
        respawnBehaviour.Respawn();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        WeaponController weapon = collision.gameObject.GetComponent<WeaponController>();

        if (weapon != null)
        {
            weapon.gameObject.layer = 0; // Default
        }
    }
}