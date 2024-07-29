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

    //Bu de�i�kenler s�n�f�n �yeleridir. CurrentGold, toplam alt�n miktar�n� tutar.
    //EarnGold, ma�azadan kazan�lacak alt�n miktar�n� tutar.
    //CurrentCustomer, �u anda ma�azada bulunan m��teri say�s�n� tutar.
    //ShopSpaceCheck, ma�aza alan�ndaki m��teri kontrol�n� sa�layan bir ShopSpaceCheck nesnesi.
    //Shop, oyun nesnelerini temsil eden bir dizi. Building, ma�azan�n in�a edilip edilmedi�ini belirten bir bayrak.
    //goldText, toplam alt�n miktar�n� g�steren bir TextMeshProUGUI nesnesi.
    //CustomerText, m��teri say�s�n� g�steren bir TextMeshProUGUI nesnesi.




    //Bu k�s�mda, ��k�� yap�lan �arp��ma alan�ndaki ma�azan�n aktif olup olmad��� kontrol edilir ve e�er aktifse, ma�azadan kazan�lacak alt�n miktar� al�n�r.
    //Daha sonra, toplam alt�n miktar� g�ncellenir ve alt�n miktar� metni g�ncellenir (UpdateGoldText() metodu kullan�larak).
    //E�er ma�azada m��teri bulunuyorsa, ma�azadaki m��teri say�s� bir azalt�l�r ve m��teri say�s� metni g�ncellenir (UptadeCustomer() metodu kullan�larak).

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

                //di�erleri de buray
            }
        }
        TotalEarnGold += EarnGold; //oyunu bitirmek i�in gerekli olan para 
        CurrentGold = CurrentGold + EarnGold; //sa� �stteki g�ncel para
        UpdateGoldText(CurrentGold);

        
        if (ShopSpaceCheck.CurrentCustemer > 0) //e�er i�eride m��teri varsa ��kt���nda bir eksilt ve bunu yaz
        {
            
            
                ShopSpaceCheck.CurrentCustemer--;
                UptadeCustomer(ShopSpaceCheck.CurrentCustemer);
              
        }
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        //Bu k�s�mda, giren �arp��ma alan�ndaki nesne bir m��teri ise, ma�azadaki m��teri say�s� bir artt�r�l�r ve m��teri say�s� metni g�ncellenir (UptadeCustomer() metodu kullan�larak).

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
