using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TotalGold : MonoBehaviour
{
    public static int CurrentGold = 5050;
    int EarnGold;
    public static int TotalEarnGold=0;
    int CurrentCustomer; 
    public ShopSpaceCheck ShopSpaceCheck;
    public GameObject[] Shop;
    bool Building;
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI CustomerText;

    //Bu deðiþkenler sýnýfýn üyeleridir. CurrentGold, toplam altýn miktarýný tutar.
    //EarnGold, maðazadan kazanýlacak altýn miktarýný tutar.
    //CurrentCustomer, þu anda maðazada bulunan müþteri sayýsýný tutar.
    //ShopSpaceCheck, maðaza alanýndaki müþteri kontrolünü saðlayan bir ShopSpaceCheck nesnesi.
    //Shop, oyun nesnelerini temsil eden bir dizi. Building, maðazanýn inþa edilip edilmediðini belirten bir bayrak.
    //goldText, toplam altýn miktarýný gösteren bir TextMeshProUGUI nesnesi.
    //CustomerText, müþteri sayýsýný gösteren bir TextMeshProUGUI nesnesi.




    //Bu kýsýmda, çýkýþ yapýlan çarpýþma alanýndaki maðazanýn aktif olup olmadýðý kontrol edilir ve eðer aktifse, maðazadan kazanýlacak altýn miktarý alýnýr.
    //Daha sonra, toplam altýn miktarý güncellenir ve altýn miktarý metni güncellenir (UpdateGoldText() metodu kullanýlarak).
    //Eðer maðazada müþteri bulunuyorsa, maðazadaki müþteri sayýsý bir azaltýlýr ve müþteri sayýsý metni güncellenir (UptadeCustomer() metodu kullanýlarak).

    private void Start()
    {
        UpdateGoldText(CurrentGold);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        for (int i = 0; i < Shop.Length; i++)
        {
            if (Shop[i].active == true)
            {
                Building = true;
                EarnGold = Shop[i].GetComponent<ShopInfo>().EarnGold;

                //diðerleri de buray
            }
        }
        TotalEarnGold += EarnGold; //oyunu bitirmek için gerekli olan para 
        CurrentGold = CurrentGold + EarnGold; //sað üstteki güncel para
        UpdateGoldText(CurrentGold);

        
        if (ShopSpaceCheck.CurrentCustemer > 0) //eðer içeride müþteri varsa çýktýðýnda bir eksilt ve bunu yaz
        {
            
            
                ShopSpaceCheck.CurrentCustemer--;
                UptadeCustomer(ShopSpaceCheck.CurrentCustemer);
              
        }
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        //Bu kýsýmda, giren çarpýþma alanýndaki nesne bir müþteri ise, maðazadaki müþteri sayýsý bir arttýrýlýr ve müþteri sayýsý metni güncellenir (UptadeCustomer() metodu kullanýlarak).

        ShopSpaceCheck.CurrentCustemer++;                          
        UptadeCustomer(ShopSpaceCheck.CurrentCustemer);
    }
   string UpdateGoldText(int gld)
    {
       return goldText.text =  "            "+ gld.ToString();
    }
    string UptadeCustomer(int a)
    {
       return CustomerText.text = a + "/" + ShopSpaceCheck.MaxCustomer.ToString();
    }

}
