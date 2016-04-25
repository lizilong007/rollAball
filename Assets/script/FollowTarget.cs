using UnityEngine;
using System.Collections;

public class FollowTarget : MonoBehaviour {
    public Transform ball;
    private Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = ball.position - transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = ball.position - offset;
	}
}
