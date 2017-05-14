using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour {

	public float ejeDeRotacion;
		
	// Update is called once per frame
	void Update () {
		
		transform.Rotate (new Vector3 (0, ejeDeRotacion,0));
	}
}
