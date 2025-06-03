using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class AudioChangerManager : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void SetMasterVolume(float masterVolume)
    {
        audioMixer.SetFloat("MasterVolume", masterVolume);

    }
}
