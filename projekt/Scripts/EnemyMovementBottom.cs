using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using UnityEngine;

public class EnemyMovementBottom : MonoBehaviour
{
    public List<GameObject> path;
    int point = 0;
    public float speed = 4;
    // Start is called before the first frame update
    void Start()
    {
        path = GameObject.FindGameObjectsWithTag("PathBottom").ToList();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position == path[point].transform.position)
        {
            point++;
        }
        else transform.position = Vector3.MoveTowards(transform.position, path[point].transform.position, speed * Time.deltaTime);
        if (point >= path.Count) Destroy(gameObject);

    }
}
