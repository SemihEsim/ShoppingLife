using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yön : MonoBehaviour
{

    public GameObject araba;
    GameObject FinishFront;
    public float speed;
    public string TagName;
    public float DestroyTime;
    public float WaitTime=5f;
    public bool HeisWaiting;
    public string newTag;
    
    
    
    void Start()
    {
        Destroy(this.gameObject, DestroyTime);

       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (HeisWaiting == true)
        {
          
            WaitTime -= Time.deltaTime;
            if (WaitTime < 0)
            {
                TagName = newTag; //gideceği yerin tagName ini alıyor 
                WaitTime = 5f;
                HeisWaiting = false;

            }
        }
        FinishFront = GameObject.FindGameObjectWithTag(TagName);
        araba.transform.position = Vector2.MoveTowards(transform.position, FinishFront.transform.position, speed * Time.deltaTime);
    }

    public void WaitShop()
    {
        HeisWaiting = true;
    }

}
