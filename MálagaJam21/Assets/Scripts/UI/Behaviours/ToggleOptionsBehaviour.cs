using UnityEngine;
using UnityEngine.UI;

public class ToggleOptionsBehaviour : MonoBehaviour
{
    [SerializeField] OptionsUI optionsUI;

    private Button optionsButton;

    private void Awake()
    {
        optionsButton = GetComponent<Button>();

        optionsButton.onClick.AddListener(() => optionsUI.ToggleVisible());
    }
}