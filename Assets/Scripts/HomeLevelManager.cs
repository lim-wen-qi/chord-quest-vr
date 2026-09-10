using UnityEngine;

public class HomeLevelManager : MonoBehaviour
{
    public GameObject level1Board;
    public GameObject level2Board;

    public GameObject playButton;
    public GameObject exitButton;

    void Start()
    {
        if (GameProgress.level1Completed)
        {
            if (level1Board != null)
                level1Board.SetActive(false);

            if (level2Board != null)
                level2Board.SetActive(true);

            if (playButton != null)
                playButton.SetActive(false);

            if (exitButton != null)
                exitButton.SetActive(true);
        }
        else
        {
            if (level1Board != null)
                level1Board.SetActive(true);

            if (level2Board != null)
                level2Board.SetActive(false);

            if (playButton != null)
                playButton.SetActive(true);

            if (exitButton != null)
                exitButton.SetActive(false);
        }
    }
}