using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class lab3_zad3_square_slide : MonoBehaviour
{
    List<Vector3> points = new List<Vector3>();
    public int point = 0;
    public float speed = 2.0f;
    float degreesPerSecond;
    // Start is called before the first frame update
    void Start()
    {
        points.Add(new Vector3(10f, 0f, 0f));
        points.Add(new Vector3(10f, 0f, 10f));
        points.Add(new Vector3(0f, 0f, 10f));
        points.Add(new Vector3(0f, 0f, 0f));

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position == points[point])
        {
            Vector3 direction = points[(point + 1) % 4] - transform.localPosition;
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            degreesPerSecond = 90 * Time.deltaTime;
            if (!transform.rotation.Equals(targetRotation))
            {
                transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, degreesPerSecond);
            }
            else point = (point + 1) % 4;
        }
        else transform.position = Vector3.MoveTowards(transform.position, points[point], speed * Time.deltaTime);
    }
}
