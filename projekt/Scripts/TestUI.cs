using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class TestUI : MonoBehaviour
{
    public Sprite sprite; 
    public GameObject ParentPanel; 
    private int counter;
    List<GameObject> list;
    // Use this for initialization
    void Start()
    {
        for (counter = 0; counter < PlayerHealth.health; counter++)
        {
            GameObject NewObj = new GameObject(); 
            Image NewImage = NewObj.AddComponent<Image>(); 
            NewImage.sprite = sprite; 
            NewObj.GetComponent<RectTransform>().SetParent(ParentPanel.transform.transform);
            NewObj.GetComponent<RectTransform>().localPosition = new Vector2(0+(counter*50), 0);
            NewObj.GetComponent<RectTransform>().localScale = new Vector2(0.5f, 0.5f);
            NewObj.SetActive(true);
            NewObj.tag = "healthUi";
        }
        list = GameObject.FindGameObjectsWithTag("healthUi").ToList();
    }

    void FixedUpdate()
    {
        if (PlayerHealth.health < counter)
        {
            Destroy(list[counter - 1]);
            counter--;
        }
    }
}
