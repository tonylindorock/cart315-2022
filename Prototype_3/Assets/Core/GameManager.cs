using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void EndGame(){
        if (canvas != null){
            
        }
    }

    public void GoToScene(int id){
        SceneManager.LoadScene(id);
    }
}
