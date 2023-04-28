using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMangger : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private GameObject WinScreen;
   float hz;
    

    private void Awake()
    {
        gameOverScreen.SetActive(false);
        WinScreen.SetActive(false);
    }

    //Activate game over screen
    public void GameOver()
    {
        gameOverScreen.SetActive(true);

    }
    public void Win()
    {
        WinScreen.SetActive(true);

    }

    //Game over functions
    public void Resart()
    {
       
         SceneManager.LoadScene(0); 
        
    }

    public void Quit()
    {
        /*Application.Quit();*/
        UnityEditor.EditorApplication.isPlaying = false;//Exits play mode

    }

    public void Close()
    {
        Application.Quit();//ÍË³öÓ¦ÓÃ
    }



    private void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Z))
        { gameOverScreen.SetActive(true); }*/

    }


}