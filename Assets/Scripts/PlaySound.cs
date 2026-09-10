using UnityEngine;

public class PlaySound : MonoBehaviour
{
    void OnEnable()
    {
        AudioSource audio = GetComponent<AudioSource>();
        if (audio != null)
        {
            audio.Play();
        }
    }
}