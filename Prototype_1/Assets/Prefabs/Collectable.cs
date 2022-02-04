using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Player"){
            Debug.Log("Touched");
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            FPSController script = player.GetComponent<FPSController>();
            script.addWeapon();
            transform.parent.gameObject.GetComponent<Trigger>().Triggered();
            Destroy(transform.parent.gameObject);
        }
    }
}
