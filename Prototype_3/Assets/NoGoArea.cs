using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NoGoArea : MonoBehaviour
{
    public Transform teleportPoint;
    public enum Axis {X, Y, Z};
    public Axis keepAxis;

    public bool canAdvance = false;

    private bool carHidden = false;

    private GameObject plot;

    void Start()
    {
        plot = GameObject.Find("Plot");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Teleport(){
        var player = GameObject.FindGameObjectWithTag("Player");
        Vector3 pos = new Vector3();
        switch(keepAxis){
                case Axis.X:
                    pos = new Vector3(player.transform.position.x, teleportPoint.position.y, teleportPoint.position.z);
                    break;
                case Axis.Y:
                    pos = new Vector3(teleportPoint.position.x, player.transform.position.y, teleportPoint.position.z);
                    break;
                case Axis.Z:
                    pos = new Vector3(teleportPoint.position.x, teleportPoint.position.y, player.transform.position.z);
                    break;
            }
        GameObject.FindGameObjectWithTag("Player").transform.position = pos;

        if (canAdvance){
            Advance();
        }
    }

    public void Advance(){
        GameObject text = GameObject.Find("TextThought");
        text.GetComponent<TextAnim>().Fade(1);

        text.GetComponent<TextMeshProUGUI>().text = plot.GetComponent<Plot>().Advance();

        if (!carHidden){
            GameObject.Find("FiatStrada_low").SetActive(false);
            carHidden = true;
        }
    }
}
