using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndGame(){
        if (canvas != null){
            canvas.transform.Find("Text_1").GetComponent<Text>().text = "THE END";
            canvas.transform.Find("Text_1").GetComponent<TextManager>().Show();
        }
    }
}
