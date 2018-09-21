using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_Contorller : MonoBehaviour {

    private float TimeLeft = 0.5f;
    private float NextTime = 0.0f;
    public float Speed;
    int bullet_num = 5;
    public GameObject Shoot;
    public Transform shootpos;
    public GameObject cha;
    Vector3 movement;

	void Start () {
		
	}

    void Update()
    {
        if (cha.transform.position.x < -10f || cha.transform.position.x > 9.5f)
            Destroy(cha);
        if (cha.transform.position.y < -6f || cha.transform.position.y > 5f)
            Destroy(cha);
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * Speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * Speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Speed);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(Shoot).transform.position = shootpos.position;
        }
        Autoshoot();
    }
    void Autoshoot()
    {
        if(Time.time > NextTime)
        {
            NextTime = TimeLeft + Time.time;
                Debug.Log(bullet_num);
                Instantiate(Shoot).transform.position = shootpos.position;
                //if(bullet_num == 1)
                //{
                 //   Debug.Log(bullet_num);
                //}
                //bullet_num += -1;
        }
    }
}
