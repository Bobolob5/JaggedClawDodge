using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{
    [SerializeField] private int playerHealth;
    [SerializeField] private GameObject[] hearts;
    [SerializeField] private Sprite emptyHeart;
    [SerializeField] private Sprite fullHeart;
    private bool isInvuln = false;

    void Update()
    {
        for (int i = 1; i < hearts.Length + 1; i++)
        {
            if (playerHealth >= i)
            {
                hearts[i-1].GetComponent<SpriteRenderer>().sprite = fullHeart;
            }
            else
            {
                hearts[i-1].GetComponent<SpriteRenderer>().sprite = emptyHeart;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            Destroy(collision.gameObject);
            if (!isInvuln) { 
                isInvuln = true;
                playerHealth--;
                if (playerHealth == 0)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
                Invoke("makeVuln", 2);
            }
        }
    }

    private void makeVuln()
    {
        isInvuln = false;
    }
}
