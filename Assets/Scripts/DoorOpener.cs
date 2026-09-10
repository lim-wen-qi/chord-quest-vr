using UnityEngine;
using System.Collections;

public class DoorOpener : MonoBehaviour
{
    [Header("Door Settings")]
    public Transform door;
    public float openAngle = 90f;
    public float openSpeed = 1f;

    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip doorOpenSound;

    [Header("UI")]
    public GameObject doorUnlockedUI;

    [Header("Debug")]
    public bool debugLogs = true;

    private bool isUnlocked = false;
    private bool isOpened = false;
    private bool isOpening = false;

    private Quaternion closedRotation;
    private Quaternion targetRotation;

    private Coroutine unlockMessageCoroutine;
    private Coroutine openDoorCoroutine;

    private void Start()
    {
        if (door == null)
        {
            Debug.LogError($"{gameObject.name}: Door reference is missing.");
            enabled = false;
            return;
        }

        closedRotation = door.rotation;
        targetRotation = closedRotation * Quaternion.Euler(0f, openAngle, 0f);

        if (doorUnlockedUI != null)
        {
            doorUnlockedUI.SetActive(false);
        }
        else if (debugLogs)
        {
            Debug.LogWarning($"{gameObject.name}: doorUnlockedUI is not assigned.");
        }

        if (audioSource == null && debugLogs)
        {
            Debug.LogWarning($"{gameObject.name}: AudioSource is not assigned.");
        }
    }

    public void UnlockDoor(bool unlocked)
    {
        if (isUnlocked == unlocked)
        {
            if (debugLogs)
                Debug.Log($"{gameObject.name}: UnlockDoor called, but state is already {isUnlocked}.");
            return;
        }

        isUnlocked = unlocked;

        if (debugLogs)
            Debug.Log($"{gameObject.name}: Door unlocked state changed to {isUnlocked}.");

        if (isUnlocked && doorUnlockedUI != null)
        {
            if (unlockMessageCoroutine != null)
                StopCoroutine(unlockMessageCoroutine);

            unlockMessageCoroutine = StartCoroutine(ShowDoorUnlockedMessage());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (debugLogs)
            Debug.Log($"{gameObject.name}: Trigger entered by {other.gameObject.name}.");

        if (!isUnlocked)
        {
            if (debugLogs)
                Debug.Log($"{gameObject.name}: Door is still locked.");
            return;
        }

        if (isOpened || isOpening)
        {
            if (debugLogs)
                Debug.Log($"{gameObject.name}: Door is already opened or opening.");
            return;
        }

        openDoorCoroutine = StartCoroutine(OpenDoor());
    }

    private IEnumerator OpenDoor()
    {
        isOpening = true;

        if (debugLogs)
            Debug.Log($"{gameObject.name}: Opening door.");

        if (audioSource != null && doorOpenSound != null)
        {
            audioSource.PlayOneShot(doorOpenSound);
        }

        Quaternion startRotation = door.rotation;
        float t = 0f;

        while (t < 1f)
        {
            t += Time.deltaTime * openSpeed;
            door.rotation = Quaternion.Slerp(startRotation, targetRotation, t);
            yield return null;
        }

        door.rotation = targetRotation;
        isOpening = false;
        isOpened = true;

        if (debugLogs)
            Debug.Log($"{gameObject.name}: Door fully opened.");
    }

    private IEnumerator ShowDoorUnlockedMessage()
    {
        doorUnlockedUI.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        doorUnlockedUI.SetActive(false);
        unlockMessageCoroutine = null;
    }
}