using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class SetupLocalPlayer : NetworkBehaviour {

    public UnityEngine.Transform mainCam;

    public PlayerController character;
    // Use this for initialization
    void Start () {
        character = GetComponent<PlayerController>();
        //mainCam = transform.GetComponentInChildren<PlayerController>(mainCam).transform;
        if (isLocalPlayer)
        {
            character.isMine = true;
        }
        //else
        //{
        //    mainCam.GetComponent<Camera>().enabled = false;
        //    character.isMine = false;
        //}
	}
	
	// Update is called once per frame
}
