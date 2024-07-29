using Unity.VisualScripting;
using UnityEngine;

public class BusMovement : MonoBehaviour
{
    public float speed ; // Otob�s h�z�
    private bool isPaused = false; // Oyun durdurulmu� mu?
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
        
   
        
     // Burada �arp��ma durumuna g�re yap�lacak i�lemleri ekleyebilirsiniz.
    if(is_Waiting==true)
        {

            
            time=time- Time.deltaTime; //otob�s�n ka� saniye bekledi�ini kontrol ediyoruz
            if(time <= 0)
            {
                
                speed = 5f;
                is_Waiting = false;
               
            }

            
        }
    
    }

    // x2 tu�una bas�ld���nda �a�r�lacak fonksiyon
    public void SpeedUp()
    {
        speed *= 2f; // H�z� iki kat�na ��kar
    }

    // Pause tu�una bas�ld���nda �a�r�lacak fonksiyon
    public void TogglePause()
    {
        isPaused = !isPaused; // Oyun durumunu tersine �evir
    }
    public void active()
    {
        if (builded == true)
        {
            
            this.gameObject.SetActive(true);

            transform.Translate(Vector3.left * speed * Time.deltaTime);


        }
    }

    // Otob�s collider'�yla �arp��ma alg�land���nda �a�r�lacak fonksiyon
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Bus_Start")
        {
            Debug.Log("Otob�s bir engelle �arp��t�!");
            is_Start = true;
            // Oyun durdurulmam��sa otob�s� sola do�ru hareket ettir
       
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
