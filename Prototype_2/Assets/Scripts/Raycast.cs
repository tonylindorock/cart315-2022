using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public float range = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void FixedUpdate()
    {
        RaycastHit hit;

        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * 5);

        if (Physics.Raycast(ray, out hit, range)){
            if (hit.collider.tag == "WeaponPickup"){
                // call highlighter
                //print("Hit!");
            }
        }  
    }
}
