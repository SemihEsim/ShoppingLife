using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShopSpaceCheck : MonoBehaviour
{
    public GameObject[] Shop;
    public string tagname;
    public string newtag;
     public int MaxCustomer;
    public int CurrentCustemer = 0;
    bool Building;
    float  Spendtime;


    //Bu deðiþkenler sýnýfýn üyeleridir. Shop, maðazanýn o anki durumunu temsil eden oyun nesneleri dizisidir.
    //tagname, maðazaya giren müþterilerin etiketi.
    //newtag, maðazadan çýkan müþterilerin alacaðý etiket.
    //MaxCustomer, maðazanýn maksimum müþteri kapasitesi.
    //CurrentCustomer, þu anda maðazada bulunan müþteri sayýsý.
    //Building, maðazanýn inþa edilip edilmediðini belirten bir bayrak.
    //Spendtime, müþterinin maðazada harcayacaðý zaman miktarý.





    //Bu kýsýmda, eðer çarpýþan nesnenin etiketi "Human" ise, maðazaya giren müþteri kontrolü yapýlýr.
    //Eðer maðaza inþa ediliyorsa ve maksimum müþteri kapasitesi henüz dolmamýþsa, müþteriye etiket atanýr ve maðaza için bekleme süresi azaltýlýr

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Human")
        {

            for (int i = 0; i < Shop.Length; i++)
            {
                if (Shop[i].active == true)
                {
                    Building= true;
                    MaxCustomer = Shop[i].GetComponent<ShopInfo>().MaxCustomer;
                    Spendtime = Shop[i].GetComponent<ShopInfo>().SpendTime;

                    //diðerleri de buray
                }
            }
           
            if (MaxCustomer > CurrentCustemer && Building)
            {
                collision.gameObject.GetComponent<Yön>().WaitTime = Spendtime;
                collision.gameObject.GetComponent<Yön>().TagName = tagname;
                collision.gameObject.GetComponent<Yön>().WaitShop();
                collision.gameObject.GetComponent<Yön>().newTag = newtag;
            }
          
         
            

        }
    }
    

   

}
