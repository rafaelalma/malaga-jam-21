using UnityEngine;

public class GoalController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        WeaponController weapon = collision.gameObject.GetComponent<WeaponController>();

        if (weapon != null)
        {
            VictoryUI.Instance.Show();
        }
    }
}