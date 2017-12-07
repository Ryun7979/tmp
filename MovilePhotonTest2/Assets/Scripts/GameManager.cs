using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float x = Random.Range(-8f, 8f);
        float y = Random.Range(1f, 10f);
//        float z = Random.Range(-5f, 5f);
        Vector3 pos = new Vector3(x, y, 0);

        if (Input.GetMouseButtonDown(0))
        {
            GameObject obj = PhotonNetwork.Instantiate("BOX", pos, Quaternion.identity, 0);

            Rigidbody objRB = obj.GetComponent<Rigidbody>();
            objRB.AddForce(Vector3.forward * 20.0f, ForceMode.Impulse);
        }



    }
}
