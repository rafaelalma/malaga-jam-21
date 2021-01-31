using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VictoryUI : MonoBehaviour
{
    public static VictoryUI Instance { get; private set; }

    [SerializeField] private Button playAgainButton;
    [SerializeField] private Button quitButton;
    [SerializeField] private Button mainMenuButton;
    [SerializeField] private TextMeshProUGUI gitPushText;

    private void Awake()
    {
        Instance = this;

        playAgainButton.onClick.AddListener(() => SceneLoader.Load(SceneLoader.Scene.GameScene));

        mainMenuButton.onClick.AddListener(() => SceneLoader.Load(SceneLoader.Scene.MainMenuScene));

        quitButton.onClick.AddListener(() => Application.Quit());

        Hide();
    }

    private void OnEnable()
    {
        Time.timeScale = 0f;
    }

    private void OnDisable()
    {
        Time.timeScale = 1f;
    }

    public void Show()
    {
        gameObject.SetActive(true);

        gitPushText.SetText($"Successful Git Push in {Mathf.RoundToInt(Time.timeSinceLevelLoad)} seconds!");
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}