using UnityEngine;
using System.Collections;

public class comp_cameraMikel : MonoBehaviour {

    public GameObject ball;
    public float cameraDistance = 10.0f;
	public float cameraSpeed = 5.0f;
	public Vector3 distanceY;
	//private CharacterMovement cm;
	private Vector3 newPosition;
	// Use this for initialization
	void Start () {
        if (!ball)
        {
            Debug.LogWarning("Is necessary to attach a character to CameraBehaviour component");
        }
		//cm = character.GetComponent<CharacterMovement> ();
		transform.position = ball.transform.position - transform.forward * cameraDistance;

		newPosition = transform.position;
        Physics.gravity = new Vector3(0, -9.81F, 0);
    }

	void FixedUpdate () {
		Vector3 transf = ball.transform.position - transform.forward * cameraDistance;
		/*if (!cm.bJumping) {
			transf.y = transform.position.y;
		}*/
		transf=transf+distanceY;
		transform.position = Vector3.Lerp(newPosition, transf, Time.deltaTime * cameraSpeed);
		newPosition = transform.position;
		//transform.position = transf;
	}
}
