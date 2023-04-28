using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class mushroom : MonoBehaviour
{

    public GameObject mushroom1;
    public GameObject mushroom2;
    public GameObject mushroom3;
    public GameObject mushroom4;

    
    




    float hz;

    // Start is called before the first frame update
    void Start()
    {

        
        mushroom1.gameObject.SetActive(true);
        mushroom2.gameObject.SetActive(false);
        mushroom3.gameObject.SetActive(false);
        mushroom4.gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log("update1");

        hz = FindObjectOfType<Health>().currentHealth;
        
        Debug.Log("hz="+hz);
     
        if (hz == 0)
        {
            Lose();
        }
        else if (hz >= 1 && hz <= 3)
        {
            Debug.Log("level1");
            Level1();
            
        }
        else if (hz >= 4 && hz <= 6)
        {
            Level2();
            Debug.Log("level2");
        }
        else if (hz >= 6 && hz <= 9)
        {
            Level3();

        }
        else if (hz >= 9 && hz <= 12)
        {
            Level4();

        }
        if (hz == 13)
        {
            Win();
        }




    }


    public void Level1()
    {
        Debug.Log("Level1()");
        mushroom2.gameObject.SetActive(false);
        mushroom1.gameObject.SetActive(true);
    }

    public void Level2()
    {
        Debug.Log("Level2()");
        mushroom1.gameObject.SetActive(false);
        mushroom3.gameObject.SetActive(false);
        mushroom2.gameObject.SetActive(true);
     
    }

    public void Level3()
    {
        Debug.Log("Level3()");
        mushroom2.gameObject.SetActive(false);
        mushroom4.gameObject.SetActive(false);
        mushroom3.gameObject.SetActive(true);
    }


    public void Level4()
    {
        Debug.Log("Level4()");

        mushroom3.gameObject.SetActive(false);
        mushroom4.gameObject.SetActive(true);

    }
    public void Win()
    {
        Debug.Log("游戏胜利");
        mushroom4.gameObject.SetActive(false);
        //游戏胜利
    }

    public void Lose()
    {
        Debug.Log("游戏结束");
        mushroom1.gameObject.SetActive(false);
        //游戏结束
    }
}


    
