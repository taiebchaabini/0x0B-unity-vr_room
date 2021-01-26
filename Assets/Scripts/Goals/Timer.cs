using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    private float timer;
    private string remainingTime;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = 60 * 25;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 1)
        {
            timer -= Time.deltaTime;
            remainingTime = string.Format("{0:00}:{1:00}", Mathf.FloorToInt(timer / 60), Mathf.FloorToInt(timer % 60));
            this.GetComponent<TMP_Text>().text = remainingTime;
        }
        else
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
        if (timer < 60 * 10)
        {
            this.GetComponent<TMP_Text>().color = new Color(0.9333333f, 0.454902f, 0.145098f);
        }
        else if (timer < 60 * 5)
        {
            this.GetComponent<TMP_Text>().color = Color.red;
        }

    
    }
}
