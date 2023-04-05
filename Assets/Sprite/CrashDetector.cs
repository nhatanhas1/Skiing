using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{

    [SerializeField]
    ParticleSystem particleSystem;
    public float delay = 1f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Snow")
        {
            //particleSystem.Play();
            Invoke("RestartGame", delay);
            Debug.Log("dead");
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
