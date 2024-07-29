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


    //Bu de�i�kenler s�n�f�n �yeleridir. Shop, ma�azan�n o anki durumunu temsil eden oyun nesneleri dizisidir.
    //tagname, ma�azaya giren m��terilerin etiketi.
    //newtag, ma�azadan ��kan m��terilerin alaca�� etiket.
    //MaxCustomer, ma�azan�n maksimum m��teri kapasitesi.
    //CurrentCustomer, �u anda ma�azada bulunan m��teri say�s�.
    //Building, ma�azan�n in�a edilip edilmedi�ini belirten bir bayrak.
    //Spendtime, m��terinin ma�azada harcayaca�� zaman miktar�.





    //Bu k�s�mda, e�er �arp��an nesnenin etiketi "Human" ise, ma�azaya giren m��teri kontrol� yap�l�r.
    //E�er ma�aza in�a ediliyorsa ve maksimum m��teri kapasitesi hen�z dolmam��sa, m��teriye etiket atan�r ve ma�aza i�in bekleme s�resi azalt�l�r

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

                    //di�erleri de buray
                }
            }
           
            if (MaxCustomer > CurrentCustemer && Building)
            {
                collision.gameObject.GetComponent<Y�n>().WaitTime = Spendtime;
                collision.gameObject.GetComponent<Y�n>().TagName = tagname;
                collision.gameObject.GetComponent<Y�n>().WaitShop();
                collision.gameObject.GetComponent<Y�n>().newTag = newtag;
            }
          
         
            

        }
    }
    

   

}
