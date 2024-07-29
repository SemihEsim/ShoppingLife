using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
    
    public Button pauseButton;
    public Button x2Button; //x2 butonu olarak kullan�l�yor isimlendirme yanl��.

    private bool isPaused = false;
    private bool isRunning = false; //h�zland�rma


    //Bu de�i�kenler, s�n�f�n �yeleridir. pauseButton ve resumeButton, oyun duraklatma ve devam ettirme butonlar�n� temsil eder.
    //isPaused, oyunun duraklat�l�p duraklat�lmad���n� belirtir.
    //isRunning, oyunun h�zland�r�l�p h�zland�r�lmad���n� belirtir.





    //Bu metod, oyunu duraklatma i�levini ger�ekle�tirir. isPaused durumunu tersine �evirir ve buna g�re Time.timeScale de�erini ayarlar.
    //E�er oyun duraklat�ld�ysa, zaman �l�e�i (Time.timeScale) s�f�ra ayarlan�r ve oyun durur.
    //E�er oyun zaten duraklat�lm��sa, ve e�er oyun h�zland�r�lm��sa, zaman �l�e�i 4 olarak ayarlan�r, aksi takdirde 1 olarak ayarlan�r.
    public void PauseGameFunction()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0f; //oyundaki zaman� durdurur
        }
        else if (isRunning)
        {
            Time.timeScale = 4f;  //e�er x2 ye al�nd�ysa x2 devam eder
        }
        else
        {
            Time.timeScale = 1f;  //normal h�zda devam eder 
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

