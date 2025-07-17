using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public bl_Joystick joyStick;
    public float moveSpeed;
    float hInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -5f)
        {
            //restart or reload the scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
    private void FixedUpdate()
    {
        hInput = joyStick.Horizontal * moveSpeed;
        print(joyStick.Horizontal);
        //* Time.deltaTime
        transform.Translate(hInput, 0, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Stone" )
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //call the coroutine to delay a little. Since we can't have
            //our player to rotate, we need to just comment this and restart the game.
            //StartCoroutine(NextLevelAfterWait());
            
            
        }
    }
    //IEnumerator NextLevelAfterWait()
    //{
    //    yield return new WaitForSeconds(1.0f);
    //    //restart or reload the scene
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //}

}
