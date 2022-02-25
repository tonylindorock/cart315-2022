using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hide(){
        GetComponent<Text>().enabled = false;
    }

    public void Show(){
        GetComponent<Text>().enabled = true;
    }
}
