using Unity.VisualScripting;
using UnityEngine;

public class BusMovement : MonoBehaviour
{
    public float speed ; // Otobüs hýzý
    private bool isPaused = false; // Oyun durdurulmuþ mu?
    private bool is_Start;
    public float time = 7f;
    public int people;
    bool is_Waiting = false;
    public WaveSystem waveSystem;
    public CreateBuild CreateBuild;
    public bool builded ;
    
    void Update()
    {
        

        builded = CreateBuild.Builded;
        active();
        
   
        
     // Burada çarpýþma durumuna göre yapýlacak iþlemleri ekleyebilirsiniz.
    if(is_Waiting==true)
        {

            
            time=time- Time.deltaTime; //otobüsün kaç saniye beklediðini kontrol ediyoruz
            if(time <= 0)
            {
                
                speed = 5f;
                is_Waiting = false;
               
            }

            
        }
    
    }

    // x2 tuþuna basýldýðýnda çaðrýlacak fonksiyon
    public void SpeedUp()
    {
        speed *= 2f; // Hýzý iki katýna çýkar
    }

    // Pause tuþuna basýldýðýnda çaðrýlacak fonksiyon
    public void TogglePause()
    {
        isPaused = !isPaused; // Oyun durumunu tersine çevir
    }
    public void active()
    {
        if (builded == true)
        {
            
            this.gameObject.SetActive(true);

            transform.Translate(Vector3.left * speed * Time.deltaTime);


        }
    }

    // Otobüs collider'ýyla çarpýþma algýlandýðýnda çaðrýlacak fonksiyon
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Bus_Start")
        {
            Debug.Log("Otobüs bir engelle çarpýþtý!");
            is_Start = true;
            // Oyun durdurulmamýþsa otobüsü sola doðru hareket ettir
       
        }
        if (collision.tag == "Bus_End")
        {
           
            speed = 0;
            time = people * 0.5f;
            is_Waiting = true;
        waveSystem.StartWave();
       
                
        }
    }
}
