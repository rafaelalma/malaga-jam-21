using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MoveBehaviour : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody2D myRigidbody2D;

    private void Awake()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        myRigidbody2D.gravityScale = 0f;
        myRigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    public void Move(Vector2 direction)
    {
        myRigidbody2D.MovePosition(myRigidbody2D.position + direction * speed * Time.fixedDeltaTime);
    }
}