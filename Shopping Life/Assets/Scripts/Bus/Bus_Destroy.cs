using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bus_Destroy : MonoBehaviour
{



    //Bu metod, 2D bir çarpýþma alanýna bir nesne girdiðinde çalýþýr.
    //collision parametresi, çarpýþma alanýna giren nesneyi temsil eder.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Bus")
        {
            collision.gameObject.transform.position = new Vector3(10.189f,-1.099f, -0.02977074f);
            collision.gameObject.SetActive(false);
        }
    }
}
//Destroy fonksiyonu, parametre olarak verilen oyun nesnesini sahneden kaldýrýr ve bellekten temizler.