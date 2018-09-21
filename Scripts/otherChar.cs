using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otherChar : MonoBehaviour {

    private float TimeLeft = 1.0f;
    private float NextTime = 0.0f;
    public float Speed;
    int bullet_num = 5;
    public GameObject Shoot;
    public Transform shootpos;
    public GameObject cha;
    Vector3 movement;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (cha.transform.position.x < -10f || cha.transform.position.x > 9.5f)
            Destroy(cha);
        if (cha.transform.position.y < -6f || cha.transform.position.y > 5f)
            Destroy(cha);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * Speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * Speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Speed);
        }
        if (Input.GetKey(KeyCode.L))
        {
            Instantiate(Shoot).transform.position = shootpos.position;
        }
    }
}
