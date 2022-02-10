using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    public string func;

    public void StartEvent(){
        SendMessage(func);
    }
}