using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OptionsUI : MonoBehaviour
{
    [Header("Managers")]
    [SerializeField] private SoundManager soundManager;
    [SerializeField] private MusicManager musicManager;

    [Header("Buttons")]
    [SerializeField] private Button musicDecreaseButton;
    [SerializeField] private Button musicIncreaseButton;
    [SerializeField] private Button soundDecreaseButton;
    [SerializeField] private Button soundIncreaseButton;
    [SerializeField] private Button continueButton;
    [SerializeField] private Button mainMenuButton;
    [SerializeField] private Button quitButton;

    [Header("Text")]
    [SerializeField] private TextMeshProUGUI musicVolumeText;
    [SerializeField] private TextMeshProUGUI soundVolumeText;

    private const int EaseReading = 10;

    private void Awake()
    {
        musicDecreaseButton.onClick.AddListener(() =>
        {
            musicManager.DecreaseVolume();
            UpdateMusicVolumeText();
        });

        musicIncreaseButton.onClick.AddListener(() =>
        {
            musicManager.IncreaseVolume();
            UpdateMusicVolumeText();
        });

        soundDecreaseButton.onClick.AddListener(() =>
        {
            soundManager.DecreaseVolume();
            UpdateSoundVolumeText();
        });

        soundIncreaseButton.onClick.AddListener(() =>
        {
            soundManager.IncreaseVolume();
            UpdateSoundVolumeText();
        });

        continueButton.onClick.AddListener(() => ToggleVisible());

        mainMenuButton.onClick.AddListener(() => SceneLoader.Load(SceneLoader.Scene.MainMenuScene));

        quitButton.onClick.AddListener(() => Application.Quit());
    }

    private void Start()
    {
        gameObject.SetActive(false);

        UpdateMusicVolumeText();
        UpdateSoundVolumeText();
    }

    private void OnEnable()
    {
        Time.timeScale = 0f;
    }

    private void OnDisable()
    {
        Time.timeScale = 1f;
    }

    public void ToggleVisible()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }

    private void UpdateMusicVolumeText()
    {
        musicVolumeText.SetText(Mathf.RoundToInt(musicManager.Volume * EaseReading).ToString());
    }

    private void UpdateSoundVolumeText()
    {
        soundVolumeText.SetText(Mathf.RoundToInt(soundManager.Volume * EaseReading).ToString());
    }
}