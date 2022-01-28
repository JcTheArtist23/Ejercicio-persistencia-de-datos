using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Checkpoint : MonoBehaviour
{
    public Text checkPointChecker;
    public string CheckpointName;
    public float positionX;
    public float positionY;
    public float positionZ;
    // Start is called before the first frame update
    void Start()
    {
    
    }


    //cuando el jugador pase por el checkpoint guarde la localización del jugador

    public void OnTriggerEnter(Collider other) 
    {
        PlayerPrefs.SetFloat("positionX", other.transform.position.x);
        PlayerPrefs.SetFloat("positionY", other.transform.position.y);
        PlayerPrefs.SetFloat("positionZ", other.transform.position.z);
        Debug.Log("Te he guardado tu localizacion, guapo");
        PlayerPrefs.SetString("checkPointChecker", CheckpointName);
        checkPointChecker.text = CheckpointName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
