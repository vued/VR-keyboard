using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CreateKeys : MonoBehaviour {

	public GameObject key;
	private GameObject[] keys;

	public string characters = "aeioubcdfghjklmnpqrstvwxyz";
	public float radius = 10.0f;

	// Use this for initialization
		void Start () {


		int l = characters.Length;
		keys = new GameObject[l];
			
		for (int i = 0; i < l; i++)
		{
			float angle = i * Mathf.PI * 2 / l;
			keys [i] = (GameObject) Instantiate(key, this.transform.position, this.transform.rotation, this.transform);
			keys [i].transform.Translate (new Vector3 (Mathf.Cos (angle), 0, Mathf.Sin (angle)) * radius);
			((TextMesh) keys [i].transform.GetChild (1).GetComponent (typeof(TextMesh))).text = "" + characters [i];
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
