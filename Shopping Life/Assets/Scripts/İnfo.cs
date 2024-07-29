using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class İnfo : MonoBehaviour
{
    public GameObject[] infotext;
    public void Info()
    {

        for (int i = 0; i < infotext.Length; i++) //bilgilendirmeleri açar 
        {
            // Objeyi aktifse pasif, pasifse aktif yapar.
            infotext[i].SetActive(!infotext[i].activeSelf);
            
        }
       
    }
}
