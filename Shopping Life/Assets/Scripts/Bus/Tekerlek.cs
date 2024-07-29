using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tekerlek : MonoBehaviour
{
    public GameObject Teker;
    public float z;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Teker.GetComponent<Transform>().transform.Rotate(0, 0, z);
    }
}
