using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oyunBitti : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Application.LoadLevel(0);
    }

    // Update is called once per frame
    void Update()
    {
        Application.LoadLevel(0);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
