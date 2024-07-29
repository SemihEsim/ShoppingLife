using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
    
    public Button pauseButton;
    public Button x2Button; //x2 butonu olarak kullanýlýyor isimlendirme yanlýþ.

    private bool isPaused = false;
    private bool isRunning = false; //hýzlandýrma


    //Bu deðiþkenler, sýnýfýn üyeleridir. pauseButton ve resumeButton, oyun duraklatma ve devam ettirme butonlarýný temsil eder.
    //isPaused, oyunun duraklatýlýp duraklatýlmadýðýný belirtir.
    //isRunning, oyunun hýzlandýrýlýp hýzlandýrýlmadýðýný belirtir.





    //Bu metod, oyunu duraklatma iþlevini gerçekleþtirir. isPaused durumunu tersine çevirir ve buna göre Time.timeScale deðerini ayarlar.
    //Eðer oyun duraklatýldýysa, zaman ölçeði (Time.timeScale) sýfýra ayarlanýr ve oyun durur.
    //Eðer oyun zaten duraklatýlmýþsa, ve eðer oyun hýzlandýrýlmýþsa, zaman ölçeði 4 olarak ayarlanýr, aksi takdirde 1 olarak ayarlanýr.
    public void PauseGameFunction()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0f; //oyundaki zamaný durdurur
        }
        else if (isRunning)
        {
            Time.timeScale = 4f;  //eðer x2 ye alýndýysa x2 devam eder
        }
        else
        {
            Time.timeScale = 1f;  //normal hýzda devam eder 
        }
    }
    public void FastGameFunction()
    {
        isRunning = !isRunning;

        if (isRunning)
        {
            Time.timeScale = 4f;
        }
        else
        {
            Time.timeScale = 1f;
        }

    } 
}

