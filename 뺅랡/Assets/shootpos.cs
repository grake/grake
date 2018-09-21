using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootpos : MonoBehaviour {

    public Transform Shootpos;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        Orbit();
    }

    void Orbit()
    {
        if (Shootpos.transform.position.y >= -0.073f)
        {
            Shootpos.transform.Translate(Vector3.down);
        }
        if(Shootpos.transform.position.y <= -0.073f)
        {
            Shootpos.transform.Translate(Vector3.left);
        }
        if (Shootpos.transform.position.y <= 0.073f)
        {
            Shootpos.transform.Translate(Vector3.right);
        }
        if(Shootpos.transform.position.x <= -0.07f)
        {
            Shootpos.transform.Translate(Vector3.up);
        }
    }
}
