using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UIHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hearth;
    private int counter;
    List<GameObject> list;
    private GameObject temp;
    void Start()
    {
        for(counter = 0;counter < PlayerHealth.health; counter++)
        {
            temp = Instantiate(hearth, new Vector2(transform.position.x+(2f*counter), transform.position.y), transform.rotation);
            temp.transform.parent = transform;
        }
        list = GameObject.FindGameObjectsWithTag("healthUi").ToList();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(PlayerHealth.health < counter)
        {
            Destroy(list[counter-1]);
            counter--;
        }
    }
}
