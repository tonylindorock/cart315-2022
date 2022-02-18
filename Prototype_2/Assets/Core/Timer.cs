using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float waitTime = 1f;
    public bool auto = false;
    
    public bool done = false;

    public string func;

    float time = 0f;

    void Start()
    {
        time = waitTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (time >= 0f){
            time -= Time.deltaTime;
        }else{
            done = true;
            CallFunc();
        }
    }

    void CallFunc(){
        if (func != null){
            SendMessage(func);
        }
    }
}