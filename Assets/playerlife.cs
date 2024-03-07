using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerlife : MonoBehaviour
{
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Om man rör dom här man dör
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.CompareTag("trap"))
        {
            Die();
        }

        if (collision.gameObject.CompareTag("enemy"))
        {
            Die();
        }
    }
    private void Die()
    {
        anim.SetTrigger("death");
    }
    
    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
