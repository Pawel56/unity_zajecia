using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class lab3_zad5 : MonoBehaviour
{
    class Position
    {
        public float x;
        public float z;
        public Position(float x, float z)
        {
            this.x = x;
            this.z = z;
        }
    }
    public GameObject block;
    bool added;
    List<Position> placed = new List<Position>();
    public int blocks = 10;
    // Start is called before the first frame update
    void Start()
    {
        added = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (placed.Count < blocks)
        {
            added = false;
            while (!added)
            {
                float positionX = Random.Range(0, 10);
                float positionZ = Random.Range(0, 10);
                //Debug.Log("Random Number is = " + positionX);
                added = true;
                for (int i = 0; i < placed.Count; i++)
                {
                    if (positionX > placed[i].x - 0.5  && positionX < placed[i].x + 0.5 && positionZ > placed[i].z - 0.5 && positionZ < placed[i].z + 0.5) added = false;
                }
                if (added)
                {
                    placed.Add(new Position(positionX, positionZ));
                    
                    Instantiate(block, new Vector3(positionX, 0, positionZ), Quaternion.identity);
                }
            }
            
        }
    }
}
