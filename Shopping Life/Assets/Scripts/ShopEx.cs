using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopEx : MonoBehaviour
{
    public GameObject[] Extra;
    public string[] strings;
    bool Building=false;
    public ExtraSpaceCheck ExtraSpaceCheck;
    public string newtag;
    int j = 0;
    int customer;
    Animator animator;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Human")
        {

            for (int i = 0; i < Extra.Length; i++)
            {
                if (Extra[i].active == true)
                {
                    Building = true;

                }

                if ( Building)
                {
                    if (ExtraSpaceCheck.CurrentCustomer < 3)
                    {
                        if (j == 0)
                        {
                            animator = collision.gameObject.GetComponent<Animator>();
                            animator.SetBool("is_stop", true);
                            collision.gameObject.GetComponent<Yön>().TagName = strings[0];
                            collision.gameObject.GetComponent<Yön>().WaitShop();
                            collision.gameObject.GetComponent<Yön>().newTag = newtag;
                            j = j + 1;
                           
                        }
                        else if (j == 1)
                        {
                            animator = collision.gameObject.GetComponent<Animator>();
                            animator.SetBool("is_stop", true);
                            collision.gameObject.GetComponent<Yön>().TagName = strings[1];
                            collision.gameObject.GetComponent<Yön>().WaitShop();
                            collision.gameObject.GetComponent<Yön>().newTag = newtag;
                            j = j + 1;
                            

                        }
                        else if (j == 2)
                        {
                            animator = collision.gameObject.GetComponent<Animator>();
                            animator.SetBool("is_stop", true);
                            collision.gameObject.GetComponent<Yön>().TagName = strings[2];
                            collision.gameObject.GetComponent<Yön>().WaitShop();
                            collision.gameObject.GetComponent<Yön>().newTag = newtag;
                            j = 0;
                          
                        }

                    }
                    else
                    {
                        collision.gameObject.GetComponent<Yön>().TagName = "HumanFinish";
                    }


                }
                else
                {
                    collision.gameObject.GetComponent<Yön>().TagName = "HumanFinish";
                }



                // collision.gameObject.GetComponent<Yön>().TagName = "HumanFinish";
            }
             
                
        }


    }
}
