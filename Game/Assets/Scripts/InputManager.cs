using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {
	private GameManager gm;

	void Awake () {
		gm = GetComponent<GameManager>();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)){
			gm.pMoveUp();
		}
		if (Input.GetKey (KeyCode.S)){
			gm.pMoveDown();
		}
		if (Input.GetKey (KeyCode.A)){
			gm.pMoveLeft();
		}
		if (Input.GetKey (KeyCode.D)){
			gm.pMoveRight();
			}
		}
	}
