using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private Vector2[] waypoints;

    private const float MinDistance = 0.1f;

    private DestroyBehaviour destroyBehaviour;
    private MoveBehaviour moveBehaviour;
    private Vector2 myPosition;
    private Vector2 nextPosition;
    private int index;

    private void Awake()
    {
        destroyBehaviour = GetComponent<DestroyBehaviour>();
        moveBehaviour = GetComponent<MoveBehaviour>();
    }

    private void Start()
    {
        index = 0;
        nextPosition = waypoints[index];
    }

    private void Update()
    {
        myPosition = new Vector2(transform.position.x, transform.position.y);

        if(Vector2.SqrMagnitude(nextPosition - myPosition) < MinDistance)
        {
            index = (index + 1) % waypoints.Length;
            nextPosition = waypoints[index];
        }
    }

    private void FixedUpdate()
    {
        moveBehaviour.Move((nextPosition - myPosition).normalized);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerController player = collision.gameObject.GetComponent<PlayerController>();

        if (player != null)
        {
            player.Destroy();
        }
    }

    public void Destroy()
    {
        destroyBehaviour.Destroy();
    }
}