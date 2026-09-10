using UnityEngine;

public class NoteBox : MonoBehaviour
{
    public string correctNoteID;
    public Renderer boardRenderer;
    public PuzzleManager puzzleManager;

    public Color defaultColor = Color.white;
    public Color correctColor = Color.green;
    public Color wrongColor = Color.red;

    public bool hasBlock = false;
    public bool isCorrect = false;

    public AudioClip noteSound;

    public Transform attachPoint;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        NoteBlock block = other.GetComponent<NoteBlock>();
        if (block == null) return;

        hasBlock = true;

        if (block.noteID == correctNoteID)
        {
            if (!isCorrect)
            {
                boardRenderer.material.color = correctColor;

                if (audioSource != null && noteSound != null)
                    audioSource.PlayOneShot(noteSound);

                isCorrect = true;
            }
        }
        else
        {
            boardRenderer.material.color = wrongColor;
            isCorrect = false;
        }

        if (puzzleManager != null)
            puzzleManager.CheckAllBoxes();
    }

    private void OnTriggerExit(Collider other)
    {
        NoteBlock block = other.GetComponent<NoteBlock>();
        if (block == null) return;

        boardRenderer.material.color = defaultColor;
        hasBlock = false;
        isCorrect = false;

        if (puzzleManager != null)
            puzzleManager.CheckAllBoxes();
    }
}