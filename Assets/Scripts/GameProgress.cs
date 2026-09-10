using UnityEngine;

public class GameProgress : MonoBehaviour
{
    public static bool level1Completed = false;

    private void Awake()
    {
        Debug.Log("Level 1 Completed = " + level1Completed);
    }
}