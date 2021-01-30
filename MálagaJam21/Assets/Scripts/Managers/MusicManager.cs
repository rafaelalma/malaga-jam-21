using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public float Volume { get => audioSource.volume; }

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();

        audioSource.volume = 0.5f;
    }

    public void IncreaseVolume()
    {
        audioSource.volume += 0.1f;
        audioSource.volume = Mathf.Clamp01(audioSource.volume);
    }

    public void DecreaseVolume()
    {
        audioSource.volume -= 0.1f;
        audioSource.volume = Mathf.Clamp01(audioSource.volume);
    }
}