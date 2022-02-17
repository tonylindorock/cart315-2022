using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushPlayer : MonoBehaviour
{
    public float pushPower = 50.0f;
    Rigidbody body;
    Vector3 pushDir = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision hit) {
        if (hit.collider.tag == "Player"){

            /*if (body.velocity.y < -0.3){
                return;
            }*/

            pushDir = new Vector3(body.velocity.x, 1f, body.velocity.z);

            hit.gameObject.GetComponent<FPSController>().AddForce(pushDir * pushPower);
            Debug.Log(pushDir * pushPower);
        }
    }
}
