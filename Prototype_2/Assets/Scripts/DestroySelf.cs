using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
    public float waitTime = 1f;

    float timeLeft = 0f;
    // Start is called before the first frame update
    void Start()
    {
        timeLeft = waitTime;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft < 0f){
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "DestroyArea"){
            Destroy(this.gameObject);
        }
    }
}
