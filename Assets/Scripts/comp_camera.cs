using UnityEngine;
using System.Collections;

public class comp_camera : MonoBehaviour 
{

public Transform ball;
public Transform transformCamera;
public float distanciaX;
public float distanciaY;

	// Use this for initialization
	void Start () 
	{
	ball=GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
	transformCamera=GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () 
	{
//	transformCamera.transform.position.x=ball.transform.position.x+10;
//	transformCamera.transform.position.y=ball.transform.position.y;
//	transformCamera.transform.position.z=ball.transform.position.z;
		transform.LookAt(ball);
		transformCamera.transform.position=new Vector3(ball.transform.position.x+distanciaX,ball.transform.position.y+distanciaY,ball.transform.position.z);

	}
}
