using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject canvas;

    private GameObject image;
    private float a;
    private bool startAnim = false;
    // Start is called before the first frame update
    void Start()
    {
        image = GameObject.Find("Canvas/Bg");
    }

    void Update(){
        if (startAnim){
            if (image != null){
                a += 0.4f * Time.deltaTime;
                a = Mathf.Clamp(a, 0f, 1f);
                image.GetComponent<Image>().color = new Color(1f, 1f, 1f, a);

                if (a == 1f){
                    GetComponent<Timer>().StartTimer();
                    startAnim = false;
                }
            }
        }
    }

    public void EndGame(){
        if (canvas != null){
            startAnim = true;
        }
    }

    public void GoToScene(int id){
        if(id == 0){
            Cursor.lockState = CursorLockMode.None;
        }
        SceneManager.LoadScene(id);
    }
}
