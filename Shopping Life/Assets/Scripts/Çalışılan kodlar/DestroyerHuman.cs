using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerHuman : MonoBehaviour
{



    //Bu metod, 2D bir �arp��ma alan�na bir nesne girdi�inde �al���r.
    //collision parametresi, �arp��ma alan�na giren nesneyi temsil eder.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            Destroy(collision.gameObject); //gelen objeleri yok et 
        }
    }
}
//Destroy fonksiyonu, parametre olarak verilen oyun nesnesini sahneden kald�r�r ve bellekten temizler.