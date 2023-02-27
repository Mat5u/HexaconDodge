using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgain1 : MonoBehaviour
{

    public void ChangeScene()
    {
        SceneManager.LoadScene("Game1");
    }

}
