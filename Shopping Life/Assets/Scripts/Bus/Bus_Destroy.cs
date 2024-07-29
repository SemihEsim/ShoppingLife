using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bus_Destroy : MonoBehaviour
{



    //Bu metod, 2D bir �arp��ma alan�na bir nesne girdi�inde �al���r.
    //collision parametresi, �arp��ma alan�na giren nesneyi temsil eder.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Bus")
        {
            collision.gameObject.transform.position = new Vector3(10.189f,-1.099f, -0.02977074f);
            collision.gameObject.SetActive(false);
        }
    }
}
//Destroy fonksiyonu, parametre olarak verilen oyun nesnesini sahneden kald�r�r ve bellekten temizler.