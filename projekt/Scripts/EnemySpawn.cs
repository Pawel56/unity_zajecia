using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject spawnersUfoTop;
    public GameObject spawnersUfoBottom;
    public float spawnDelay = 14;
    float savedTime = -14;
    public GameObject ufoTop;
    public GameObject ufoBottom;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        List<GameObject> player = GameObject.FindGameObjectsWithTag("Player").ToList();
        if (player.Count > 0 )
        {
            if (Time.time > savedTime + spawnDelay)
            {
                savedTime = Time.time;
                Instantiate(ufoTop, spawnersUfoTop.transform.position, transform.rotation);
                Instantiate(ufoBottom, spawnersUfoBottom.transform.position, transform.rotation);
            }
            if (Time.time % 20 == 0 && spawnDelay > 2)
            {
                spawnDelay -= 2;
            }
        }
    }
}
