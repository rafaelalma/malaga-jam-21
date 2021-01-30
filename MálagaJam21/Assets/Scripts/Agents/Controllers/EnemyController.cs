using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private const float MinDistance = 0.1f;

    private Vector2[] waypoints;
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

    private void Update()
    {
        myPosition = new Vector2(transform.position.x, transform.position.y);

        if (Vector2.SqrMagnitude(nextPosition - myPosition) < MinDistance)
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

    public void Initialize(float min, float max, int minWaypoints, int maxWaypoints)
    {
        RandomizeWaypoints(min, max, minWaypoints, maxWaypoints);

        nextPosition = waypoints[index];
    }

    private void RandomizeWaypoints(float min, float max, int minWaypoints, int maxWaypoints)
    {
        waypoints = new Vector2[Random.Range(minWaypoints, maxWaypoints)];

        for (int i = 0; i < waypoints.Length; i++)
        {
            waypoints[i] = new Vector2(Random.Range(min, max), Random.Range(min, max));
        }
    }
}