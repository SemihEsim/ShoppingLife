using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildSystem : MonoBehaviour
{
   
    public List<GameObject> builds= new List<GameObject>();
    public List<GameObject> close = new List<GameObject>();
    public int SelectedObject;
    //Bu de�i�kenler s�n�f�n �yeleridir. builds ve close
    //GameObject t�r�nden nesneleri i�eren listelerdir. SelectedObject, �u an se�ilen nesnenin dizininin (index) tutar.



    //Bu metod, yap�lacak bir in�aat� a�ar. WhichObject, a��lacak nesnenin indeksini belirtir.
    //Metod, listedeki her nesneyi dola�arak aktif durumunu tersine �evirir ve SelectedObject de�i�kenini g�nceller.
    public void OpenBuild(int WhichObject) // hangi binan�n dikilece�ini se�memize yarar // bina dikilme b�lgelerini kapat�r
    {   
        for (int i = 0; i < builds.Count; i++)
        {
           
            if (builds[i].active == true) //binalar�n dikilece�i b�lgelerin setActive k�s�mlar� 
            {
              
                builds[i].SetActive(false);  //bina dikildiyse bina dikilme sistemini kapat�r
            }
            else
            {
                builds[i].SetActive(true);
            }
        } 
        SelectedObject = WhichObject;
        //hangi d�kkan� kuraca��m�z� se�iyor
    }


    //Bu metod, in�aat� kapat�r. close listesindeki her nesneyi kontrol eder ve baz� ko�ullara g�re onlar� aktifle�tirir veya deaktifle�tirir.
    //Bu ko�ullar, nesnenin aktif olmamas� ve bir yap� in�a edilmemi� olmas�d�r.
    //Bu durumlar sa�land���nda, ilgili nesne aktif hale getirilir ve bir debug mesaj� yazd�r�l�r.
    public void CloseBuild() //art�lar� kapat�ypr
    {   
        for (int i = 0; i < close.Count; i++)
        {
           
            if (close[i].active == false && close[i].GetComponent<CreateBuild>().Builded == false)
            {
                close[i].SetActive(true);
                Debug.Log(close[i] + "AKtif Oldu");  //build yap�lmad�ysa ve art�lar a��k de�ilse hepsini a�ar
            }
            else
            {
                close[i].SetActive(false);  //kapat�r 
            }
        } 
    }
}


