using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEffector : MonoBehaviour {

    private float time = 0;
    public GameObject go;
 

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        time = time + Time.deltaTime;
        go.SetActive(true);

        if (time > 3) { //Cuando el tiempo pasa de 3 segundos, se desactiva la cascada.
            go.SetActive(false);
            time = 0;
        }
        
    }
}
