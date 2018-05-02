using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight : MonoBehaviour {
    public DistanceJoint2D distJoint;
    public LineRenderer line;
	// Use this for initialization
	void Start () {
        distJoint = GetComponent<DistanceJoint2D>();
        line = GetComponent<LineRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        line.SetPosition(0, transform.position); //se coloca la posicion inicial del objeto
        //se coloca la posicion final del objeto haciendo referencia al peso que esta conectado
        line.SetPosition(1,distJoint.connectedBody.transform.position); 
    }
}
