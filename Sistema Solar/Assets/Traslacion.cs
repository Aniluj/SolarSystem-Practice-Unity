using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traslacion : MonoBehaviour {

	public Transform posicionDelObjetoARotar;
	public float velocidad;

	// Update is called once per frame
	void Update () {

		transform.RotateAround (posicionDelObjetoARotar.position, Vector3.up, velocidad);
	}
}
