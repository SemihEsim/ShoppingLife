using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Tutorial : MonoBehaviour
{

    public GameObject Click;
    public GameObject Click2;
    public GameObject Click3;
    public GameObject Click4;
    public GameObject Click5;   
    public GameObject Click6;
    public GameObject Click7;
    public GameObject Click8;
    public UnityEngine.UI.Button Button1;
    public UnityEngine.UI.Button Button2;
    public UnityEngine.UI.Button Button3;
    public UnityEngine.UI.Button Button4;
    public UnityEngine.UI.Button Button5;
    public UnityEngine.UI.Button Button6;
    public UnityEngine.UI.Button Button7;    
    public UnityEngine.UI.Button Button9;
    public UnityEngine.UI.Button Button10;
    public bool close = true;
    public bool close1 = true;
    public bool close2 = true;
    public bool close3 = true;
    public bool close4 = true;
    public bool close5 = false;
    // Start is called before the first frame update


    public void FirstClick()
    {

        if (close)
        {
            Click.SetActive(false);
            Click2.SetActive(true);
            close = false;
            
        }
    }
    public void SecondClick()
    {
        
        Click2.SetActive(false);
        Click3.SetActive(true);
    }
    public void ThirdClick()
    {
        Button1.enabled = true;
        if (close1)
        {
            Click3.SetActive(false);
            Click4.SetActive(true);
            close1 = false;
    }


}
    public void FourthClick()
    {
        Button2.enabled = true;
        if (close2)
        {
            Click4.SetActive(false);
            Click5.SetActive(true);
            close2 = false;

        }

}
    public void FifthClick()
    {
       
        if (close3)
        {
            Click5.SetActive(false);
            Click6.SetActive(true);
            close3 = false;
        }

    }
    public void SixthClick() 
    {
        Button3.enabled = true;
        Button4.enabled = true;
        Button5.enabled = true; 
        Button6.enabled = true;
        Button7.enabled = true;
        Button9.enabled = true;
        Button10.enabled = true;



        Click6.SetActive(false);
            Click7.SetActive(true);
         
    }
    public void SeventhClick()
    {
        if (close4)
        {
            Click7.SetActive(false);
            Click4.SetActive(true);
            close4 = false;
            close5 = true;
        }
    }
    public void EighthClick()
    {
       
        Click4.SetActive(false);
        if (close5)
        Click8.SetActive(true);
    }




}
