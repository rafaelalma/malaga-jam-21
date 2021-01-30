using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private MoveBehaviour moveBehaviour;
    private DestroyBehaviour destroyBehaviour;
    private Vector2 moveDirection;

    private void Awake()
    {
        moveBehaviour = GetComponent<MoveBehaviour>();
        destroyBehaviour = GetComponent<DestroyBehaviour>();
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

    public void Destroy()
    {
        destroyBehaviour.Destroy();
    }
}