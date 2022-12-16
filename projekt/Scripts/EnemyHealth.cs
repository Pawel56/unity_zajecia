using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 10;
    // Start is called before the first frame update
    void Start()
    {
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "FriendlyProjectile")
        {
            if (health > 1) health--;
            else
            {
                Destroy(gameObject);
                Score.score += 1;
            }
            Destroy(other.gameObject);
            
        }
    }
}
