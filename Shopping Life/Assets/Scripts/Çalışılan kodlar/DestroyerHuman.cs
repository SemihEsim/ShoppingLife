using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerHuman : MonoBehaviour
{



    //Bu metod, 2D bir çarpýþma alanýna bir nesne girdiðinde çalýþýr.
    //collision parametresi, çarpýþma alanýna giren nesneyi temsil eder.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            Destroy(collision.gameObject); //gelen objeleri yok et 
        }
    }
}
//Destroy fonksiyonu, parametre olarak verilen oyun nesnesini sahneden kaldýrýr ve bellekten temizler.