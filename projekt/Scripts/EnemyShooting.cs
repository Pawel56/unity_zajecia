using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject projectile;
    public float projectileSpeed = 10f;
    public float shootDalaySeconds = 1;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time > time + shootDalaySeconds)
        {
            time = Time.time;
            GameObject shoot = Instantiate(projectile, transform.position, transform.rotation);
            shoot.GetComponentInChildren<Rigidbody2D>().velocity = new Vector2(-1f,0f) * projectileSpeed;

        }
    }
}
