using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SongManager : MonoBehaviour
{
    public string[] correctSequence;
    private int currentIndex = 0;

    public GameObject completionPanel;
    public GameObject retryPanel;

    public AudioSource wrongAudioSource;
    public AudioClip wrongSound;

    private bool isRetryShowing = false;
    private bool isCompleted = false;

    void Start()
    {
        if (completionPanel != null)
            completionPanel.SetActive(false);

        if (retryPanel != null)
            retryPanel.SetActive(false);
    }

    public bool CheckNote(string playedNote)
    {
        if (isCompleted) return false;
        if (currentIndex >= correctSequence.Length) return false;

        if (playedNote == correctSequence[currentIndex])
        {
            Debug.Log("Correct note: " + playedNote);
            currentIndex++;

            if (currentIndex >= correctSequence.Length)
            {
                CompleteSong();
            }

            return true;
        }
        else
        {
            Debug.Log("Wrong note: " + playedNote);
            currentIndex = 0;

            if (!isRetryShowing)
            {
                StartCoroutine(ShowRetryPanel());
            }

            if (wrongAudioSource != null && wrongSound != null)
            {
                wrongAudioSource.Stop();
                wrongAudioSource.PlayOneShot(wrongSound);
            }

            return false;
        }
    }

    void CompleteSong()
    {

        isCompleted = true;

        if (completionPanel != null)
        {
            Debug.Log("Song completed! Returning to Home scene...");
            completionPanel.SetActive(true);
        }

        GameProgress.level1Completed = true;
        StartCoroutine(ReturnHome());
    }

    IEnumerator ShowRetryPanel()
    {
        isRetryShowing = true;

        if (retryPanel != null)
        {
            Debug.Log("Wrong note! Showing retry panel.");
            retryPanel.SetActive(true);
        }

        yield return new WaitForSeconds(2f);

        if (retryPanel != null)
        {
            retryPanel.SetActive(false);
        }

        isRetryShowing = false;
    }

    IEnumerator ReturnHome()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Home");
    }
}