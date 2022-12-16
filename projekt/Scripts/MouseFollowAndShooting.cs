using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MouseFollowAndShooting : MonoBehaviour
{
    public GameObject projectile;
    public float projectileSpeed = 10f;
    public float shootDalaySeconds = 1;
    float time;
    Vector3 mousePos;
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 0.5f;
    private void Start()
    {
        
    }
    void FixedUpdate()
    {
        //rotation
        mousePos = Input.mousePosition;
        mousePos.z = 0;

        Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);
        mousePos.x = mousePos.x - objectPos.x;
        mousePos.y = mousePos.y - objectPos.y;

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        if (Input.GetMouseButton(0))
        {
            if (Time.time > time + shootDalaySeconds)
            {
                time = Time.time;
                audioSource.PlayOneShot(clip, volume);
                GameObject shoot = Instantiate(projectile, transform.position, transform.rotation);
                shoot.GetComponentInChildren<Rigidbody2D>().velocity = mousePos.normalized * projectileSpeed;

            }
        }
    }
}
