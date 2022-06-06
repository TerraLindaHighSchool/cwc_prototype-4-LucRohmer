using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

 public class GameManager : MonoBehaviour
{
    public bool gameActive = false;
    public GameObject titleScreen;
    private SpawnManager spawnManager;
    public Button startButton;
    public Button restartButton;
    public 


    // Start is called before the first frame update
    void Start()
    {
        spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        startButton.onClick.AddListener(startGame);
        restartButton.onClick.AddListener(RestartGame);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void startGame()
    {
        gameActive = true;
        titleScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
