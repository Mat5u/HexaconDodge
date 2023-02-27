using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour
{

    public void ChangeScene()
    {
        SceneManager.LoadScene("Game");
    }

}
