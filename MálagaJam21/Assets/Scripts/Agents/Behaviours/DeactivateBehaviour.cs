using UnityEngine;

public class DeactivateBehaviour : MonoBehaviour
{
    public void Deactivate()
    {
        gameObject.SetActive(false);
    }
}