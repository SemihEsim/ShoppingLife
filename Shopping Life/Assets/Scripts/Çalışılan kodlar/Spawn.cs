using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public List<GameObject>araba=new List<GameObject>();
    public GameObject spawn2;
    float timer = 0;
    public bool u�ak;
    // Update is called once per frame

    //Bu de�i�kenler s�n�f�n �yeleridir. araba, sahneye eklenecek olan araba oyun nesnelerini i�eren bir liste.
    //spawn2, oyun nesnelerinin olu�turulaca�� konumu temsil eden bir oyun nesnesi.
    //timer, bir sonraki nesnenin olu�turulmas� i�in geri say�m� tutar.
    //u�ak, e�er true ise, timer'�n u�aklar i�in ayarlanmas� gerekti�ini belirtir



    //Bu metot, her karede bir kez �a�r�l�r ve spawn i�lemini ger�ekle�tirir.
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0 )
        {

            //Bu k�s�mda, her g�ncelleme d�ng�s�nde timer de�eri azalt�l�r.
            //Timer 0'a ula�t���nda, belirtilen aral�kta rastgele bir araba se�ilir ve Instantiate fonksiyonuyla spawn2 konumunda olu�turulur.
            //E�er u�ak spawn ediliyorsa, timer'�n rastgele 30 ile 45 saniye aras�nda ayarlanmas� sa�lan�r.
            //U�ak de�ilse, timer 9 ile 12 saniye aras�nda ayarlan�r.
            //Bu i�lem, belirli aral�klarla nesne olu�turulmas�n� sa�lar.
            int a =0; 
            a = Random.Range( 0,araba.Count );
            Instantiate(araba[a],spawn2.transform.position,Quaternion.identity);
           
            if (u�ak)
            {
                timer = Random.Range(30f, 45f);
            }
            else
            {
                timer = Random.Range(9f, 12f);
            }
                
        }
        
    }
}
