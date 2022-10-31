using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slide : MonoBehaviour
{
    public float speed = 2.0f;
    float starting_position_x;

    bool platform_switch = false;
    // Start is called before the first frame update
    void Start()
    {
        starting_position_x = gameObject.transform.position.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 velocity = new Vector3(speed, 0, 0);
        velocity = velocity.normalized * speed * Time.deltaTime;
        
        if(platform_switch == false){
            if(gameObject.transform.position.x <= starting_position_x+10){
                gameObject.transform.position += velocity;
            }
            else{
                platform_switch = true;
            }    
        }
        else{
            if(gameObject.transform.position.x >= starting_position_x){
                gameObject.transform.position -= velocity;
            }
            else{
                platform_switch = false;
            }    
        }
    }
}
