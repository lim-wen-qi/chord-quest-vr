using UnityEngine;
using System.Collections;

public class PuzzleManager : MonoBehaviour
{
    public NoteBox[] noteBoxes;
    public DoorOpener doorOpener;

    public AudioSource audioSource;
    public AudioClip unlockSound;

    private bool hasPlayedSound = false;

    public void CheckAllBoxes()
    {
        if (noteBoxes == null || noteBoxes.Length == 0)
        {
            return;
        }

        // Check if all boxes have a block
        foreach (NoteBox box in noteBoxes)
        {
            if (box == null)
            {
                continue;
            }

            if (!box.hasBlock)
            {
                if (doorOpener != null)
                    doorOpener.UnlockDoor(false);

                hasPlayedSound = false;
                return;
            }
        }

        Debug.Log("All boxes have blocks.");

        // Check if all placed blocks are correct
        foreach (NoteBox box in noteBoxes)
        {
            if (box == null)
            {
                continue;
            }

            if (!box.isCorrect)
            {
                Debug.Log("Wrong block in box: " + box.name);

                if (doorOpener != null)
                    doorOpener.UnlockDoor(false);

                hasPlayedSound = false;
                return;
            }
        }

        Debug.Log("Puzzle solved! All blocks are correct.");

        // All boxes correct
        if (doorOpener != null)
            doorOpener.UnlockDoor(true);

        if (!hasPlayedSound)
        {
            hasPlayedSound = true;
            StartCoroutine(PlayUnlockSound());
        }
    }

    IEnumerator PlayUnlockSound()
    {
        yield return new WaitForSeconds(1f);

        if (audioSource != null && unlockSound != null)
        {
            audioSource.PlayOneShot(unlockSound);
        }
    }
}