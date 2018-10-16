
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{

    public AudioMixer audioMixer;

    public void SetVolume(float volume)
    {
        this.audioMixer.SetFloat("volume", volume);
    }
}
