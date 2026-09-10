using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PianoKey : MonoBehaviour
{
    public string noteID;
    public SongManager songManager;

    public AudioClip noteSound;
    public Renderer keyRenderer;

    public Color defaultColor = Color.white;
    public Color pressedColor = Color.green;
    public Color wrongColor = Color.red;

    private AudioSource audioSource;
    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable interactable;
    private Material keyMaterial;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable>();

        if (interactable == null)
            Debug.LogError($"{gameObject.name}: Missing XRSimpleInteractable component.");

        if (audioSource == null)
            Debug.LogWarning($"{gameObject.name}: Missing AudioSource component.");

        if (keyRenderer != null)
        {
            keyMaterial = keyRenderer.material;
            defaultColor = keyMaterial.color;
        }
        else
        {
            Debug.LogWarning($"{gameObject.name}: keyRenderer is not assigned.");
        }
    }

    void OnEnable()
    {
        if (interactable != null)
            interactable.selectEntered.AddListener(OnKeyPressed);
    }

    void OnDisable()
    {
        if (interactable != null)
            interactable.selectEntered.RemoveListener(OnKeyPressed);
    }

    void OnKeyPressed(SelectEnterEventArgs args)
    {
        Debug.Log($"{gameObject.name} pressed. noteID = {noteID}");

        if (audioSource != null && noteSound != null)
        {
            audioSource.Stop();
            audioSource.PlayOneShot(noteSound);
        }

        bool isCorrect = true;

        if (songManager != null)
        {
            isCorrect = songManager.CheckNote(noteID);
            Debug.Log($"CheckNote result: {isCorrect}");
        }
        else
        {
            Debug.LogWarning($"{gameObject.name}: songManager is not assigned.");
        }

        CancelInvoke(nameof(ResetColor));

        if (keyMaterial != null)
        {
            keyMaterial.color = isCorrect ? pressedColor : wrongColor;
            Invoke(nameof(ResetColor), 0.25f);
        }
    }

    void ResetColor()
    {
        if (keyMaterial != null)
            keyMaterial.color = defaultColor;
    }
}