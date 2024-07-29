using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public List<GameObject>araba=new List<GameObject>();
    public GameObject spawn2;
    float timer = 0;
    public bool uçak;
    // Update is called once per frame

    //Bu deðiþkenler sýnýfýn üyeleridir. araba, sahneye eklenecek olan araba oyun nesnelerini içeren bir liste.
    //spawn2, oyun nesnelerinin oluþturulacaðý konumu temsil eden bir oyun nesnesi.
    //timer, bir sonraki nesnenin oluþturulmasý için geri sayýmý tutar.
    //uçak, eðer true ise, timer'ýn uçaklar için ayarlanmasý gerektiðini belirtir



    //Bu metot, her karede bir kez çaðrýlýr ve spawn iþlemini gerçekleþtirir.
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0 )
        {

            //Bu kýsýmda, her güncelleme döngüsünde timer deðeri azaltýlýr.
            //Timer 0'a ulaþtýðýnda, belirtilen aralýkta rastgele bir araba seçilir ve Instantiate fonksiyonuyla spawn2 konumunda oluþturulur.
            //Eðer uçak spawn ediliyorsa, timer'ýn rastgele 30 ile 45 saniye arasýnda ayarlanmasý saðlanýr.
            //Uçak deðilse, timer 9 ile 12 saniye arasýnda ayarlanýr.
            //Bu iþlem, belirli aralýklarla nesne oluþturulmasýný saðlar.
            int a =0; 
            a = Random.Range( 0,araba.Count );
            Instantiate(araba[a],spawn2.transform.position,Quaternion.identity);
           
            if (uçak)
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
