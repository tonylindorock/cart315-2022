using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IsTriggered(){
        
    }

    private void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Player"){
            //Debug.Log("In Area");
            GetComponent<Trigger>().Triggered();
        }
    }
}
