using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOrb : MonoBehaviour
{
    public GameObject orb;
    // Start is called before the first frame update
    void Start()
    {
        SpawnNewOrb();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnNewOrb(){
        GameObject orbObj = Instantiate(orb, RandPointInBox(GetComponent<BoxCollider>().bounds), Quaternion.identity);
        orbObj.GetComponent<Collectable>().setTrigger(this.gameObject);
        GetComponent<AudioSource>().Play();
    }

    public Vector3 RandPointInBox(Bounds bounds) {
    return new Vector3(
        Random.Range(bounds.min.x, bounds.max.x),
        Random.Range(bounds.min.y, bounds.max.y),
        Random.Range(bounds.min.z, bounds.max.z)
    );
}
}