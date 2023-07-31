using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseResume : MonoBehaviour
{
    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ReusmeGame()
    {
        Time.timeScale = 1;
    }
}
