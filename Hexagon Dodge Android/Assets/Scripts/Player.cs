using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;


public class Player : MonoBehaviour
{
    public float moveSpeed = 950f;

    float movement = 0f;
    //tän paskan saa purkaa jos ei toimi (alapuoli)
    //private Vector2 touchOringin = -Vector2.one;

    // Update is called once per frame
    void Update()
    {
        //movement = Input.GetAxisRaw("Horizontal");
        movement = CrossPlatformInputManager.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        FindObjectOfType<GameManager>().EndGame();
        
    }
}
