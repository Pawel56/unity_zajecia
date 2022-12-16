using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    static public int health = 5;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (health > 1) health--;
        else Destroy(gameObject);
        Destroy(collision.gameObject);
        Score.score+=1;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "EnemyProjectile")
        {
            if (health > 1) health--;
            else
            {
                health--;
                Destroy(gameObject);
            }
            Destroy(collision.gameObject);
        }
    }

}
