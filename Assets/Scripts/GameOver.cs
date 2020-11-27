using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public bool isGameOver = false;
    public GameObject GameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        GameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            GameOverPanel.SetActive(false);
            Time.timeScale = 1;
        }
        if (isGameOver == true)
        {
            Application.LoadLevel(0);
            GameOverPanel.SetActive(true);
            

            
                

            
        }
        if(Time.timeScale == 0)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Application.Quit();
            }
        }
    }
}
