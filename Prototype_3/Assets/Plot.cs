using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plot : MonoBehaviour
{
    private int id = 0;

    public string[] thoughts;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string Advance(){
        if (id < thoughts.Length - 1){
            id += 1;
        }
        return thoughts[id].Replace("\\n", "\n");;
    }
}
