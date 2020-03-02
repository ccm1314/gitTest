using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstScript : MonoBehaviour {

    public GameObject prefabCube;
    bool GetCube = true;
	void Start () {
       GameObject go1= Instantiate(prefabCube, Vector3.zero, Quaternion.identity);
        go1.AddComponent<Rigidbody>();
        StartCoroutine(BronCube());
	}
    public IEnumerator BronCube()
    {
        while(true)
        {
            yield return new WaitForSeconds(1);
           GameObject go= Instantiate(prefabCube, Vector3.zero, Quaternion.identity);
            go.AddComponent<Rigidbody>();
        }
    }
	 
	void Update () {
		
	}
}
