using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    bool gameHasEnded = false;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Restart();
        }


    }

    void Restart()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //SceneManager.LoadScene("TryAgain");
        SceneManager.LoadScene("TryAgain1");
    }
}
