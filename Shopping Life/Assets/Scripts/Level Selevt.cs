using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    // Butonlar�n sahne adlar�n� tutmak i�in bir dizi
    public string[] hedefSahneAdlari;
    int gold = 5050;
    int current_gold=0;

    // Butonlar�n indeksine g�re sahne de�i�tirme i�lemi
    public void SahneDegistir(int butonIndex)
    {
        // Ge�erli buton indeksi, hedef sahne adlar� dizisinin boyutundan b�y�kse ��k
        if (butonIndex >= hedefSahneAdlari.Length)
        {
            Debug.LogError("Hedef sahne ad� bulunamad�!");
            return;
        }
        // Belirtilen sahneye ge�i� yap
        SceneManager.LoadScene(hedefSahneAdlari[butonIndex]);
        TotalGold.CurrentGold = gold;
        TotalGold.TotalEarnGold= current_gold;
    }
}
