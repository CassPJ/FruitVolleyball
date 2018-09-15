using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour {

    public Rigidbody p1;
    public Rigidbody p2;
    private Rigidbody rb;
    public int wPoints = 0;
    public int oPoints = 0;
    public Text oPointsText;
    public Text wPointsText;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        oPointsText.text = ("Orange: " + oPoints);
        wPointsText.text = ("Watermelon: " + wPoints);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Base_002")
        {
            if (transform.position.x <= -0.06f)
            {
                oPoints++;
            }
            else
            {
                wPoints++;
            }
            transform.position = new Vector3(1.98f, 3.65f, 0.583f);
            rb.velocity = Vector3.zero;
            p1.transform.position = new Vector3(1.985091f, 0.96f, 0.583f);
            p1.velocity = Vector3.zero;
            p2.transform.position = new Vector3(-1.994487f, 0.96f, 0.3427706f);
            p2.velocity = Vector3.zero;
        }
    }
}
