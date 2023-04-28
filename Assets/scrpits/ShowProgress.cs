using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowProgress : MonoBehaviour
{

    public List<GameObject> mushrooms= new List<GameObject>();
    
    private float score;


    /*float score;*/
    // Start is called before the first frame update
    void Start()
    {

        ShineMushroom();
        /*mangger = GetComponent<UIMangger>();*/
        score = FindObjectOfType<Health>().currentHealth;
    }


    void ShineMushroom()
    {

        


        for (int i = 0; i < 4; i++)
        {
            if (i == score/3)
            {
                mushrooms[i].SetActive(true);
                mushrooms[i].GetComponent<Glow>().Shine();
                
            }
            else
            {
                mushrooms[i].GetComponent<Glow>().StopShine();
                mushrooms[i].SetActive(false);
            }
        }
    }


    void Update()
    {

        //score = FindObjectOfType<Health>().currentHealth;


        //increase score??? colliosn or somehting
        /*if (Input.GetKeyDown(KeyCode.D))
        {
            if (score < 11)
            {
                score++;
            }
            ShineMushroom();
        }

        //show score
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShineMushroom();
        }*/



        /*if (x == 0)
        {
            mangger.GameOver();
        }
        else if (x == 13)
        {
            mangger.Win();
        }*/

    }

   /* private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "mushroom")
        {
            if (collision.tag == "chem")
            {
                if (collision.tag == "bullet")
                {
                    Destroy(collision.gameObject);
                }
                else
                {
                    x = x - 1;
                    Debug.Log(x);
                }


            }
            else 
            {
                x = x + 1;
                Debug.Log(x);
                ShineMushroom();
            }
                
            
        }*/
    }

