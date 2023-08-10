using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;


public class MousrUI : MonoBehaviour
{
    public bool isGameActive;

    public TextMeshProUGUI gameOverButtom;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI Timetext;

    private TextMeshProUGUI UI;
    float timer = 0f;
    string timermeter;


    // Start is called before the first frame update
    void Start()
    {
        
        UI = GameObject.Find("Text_time").GetComponent<TextMeshProUGUI>();
        isGameActive = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (isGameActive)
        {
            timer += Time.deltaTime;
            timermeter = timer.ToString("0.00");
            UI.text = "Depth:" + timermeter;
        }

        RestartGame();
    }
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        gameOverButtom.gameObject.SetActive(true);
        isGameActive = false;
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cube")
        {
            GameOver();
            isGameActive = false;
        }
        
    }
    public void RestartGame()
    {

        if (!isGameActive && Input.GetKeyDown(KeyCode.G))
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(0);
        }
    }
}
