using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ui : MonoBehaviour
{
    public GameObject Gameover;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale= 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Lost()
    {
        Gameover.SetActive(true);
        Time.timeScale = 0;
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
        
    }
    public void Quit()
    {
        Application.Quit();
    }
}
