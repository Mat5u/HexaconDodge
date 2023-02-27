using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultiesChange : MonoBehaviour
{
    
    public void HardDifficultyChange()
    {
        SceneManager.LoadScene("Game");
    }

    public void MediumDifficultyChange()
    {
        SceneManager.LoadScene("Game1");
    }

    public void EasyDifficultyChange()
    {
        SceneManager.LoadScene("Game2");
    }
}
