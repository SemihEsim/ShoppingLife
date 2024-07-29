using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildSystem : MonoBehaviour
{
   
    public List<GameObject> builds= new List<GameObject>();
    public List<GameObject> close = new List<GameObject>();
    public int SelectedObject;
    //Bu deðiþkenler sýnýfýn üyeleridir. builds ve close
    //GameObject türünden nesneleri içeren listelerdir. SelectedObject, þu an seçilen nesnenin dizininin (index) tutar.



    //Bu metod, yapýlacak bir inþaatý açar. WhichObject, açýlacak nesnenin indeksini belirtir.
    //Metod, listedeki her nesneyi dolaþarak aktif durumunu tersine çevirir ve SelectedObject deðiþkenini günceller.
    public void OpenBuild(int WhichObject) // hangi binanýn dikileceðini seçmemize yarar // bina dikilme bölgelerini kapatýr
    {   
        for (int i = 0; i < builds.Count; i++)
        {
           
            if (builds[i].active == true) //binalarýn dikileceði bölgelerin setActive kýsýmlarý 
            {
              
                builds[i].SetActive(false);  //bina dikildiyse bina dikilme sistemini kapatýr
            }
            else
            {
                builds[i].SetActive(true);
            }
        } 
        SelectedObject = WhichObject;
        //hangi dükkaný kuracaðýmýzý seçiyor
    }


    //Bu metod, inþaatý kapatýr. close listesindeki her nesneyi kontrol eder ve bazý koþullara göre onlarý aktifleþtirir veya deaktifleþtirir.
    //Bu koþullar, nesnenin aktif olmamasý ve bir yapý inþa edilmemiþ olmasýdýr.
    //Bu durumlar saðlandýðýnda, ilgili nesne aktif hale getirilir ve bir debug mesajý yazdýrýlýr.
    public void CloseBuild() //artýlarý kapatýypr
    {   
        for (int i = 0; i < close.Count; i++)
        {
           
            if (close[i].active == false && close[i].GetComponent<CreateBuild>().Builded == false)
            {
                close[i].SetActive(true);
                Debug.Log(close[i] + "AKtif Oldu");  //build yapýlmadýysa ve artýlar açýk deðilse hepsini açar
            }
            else
            {
                close[i].SetActive(false);  //kapatýr 
            }
        } 
    }
}


