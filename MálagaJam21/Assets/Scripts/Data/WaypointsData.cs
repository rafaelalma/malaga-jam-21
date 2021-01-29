using UnityEngine;

[CreateAssetMenu(fileName = "NewWaypointsSO", menuName = "ScriptableObject/Waypoints")]
public class WaypointsData : ScriptableObject
{
    public Vector2[] Waypoints => waypoints;

    [SerializeField] private Vector2[] waypoints;
}