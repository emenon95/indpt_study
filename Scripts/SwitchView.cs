using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchView : MonoBehaviour {


    [SerializeField] GameObject model;
    [SerializeField] Camera camera;
    [SerializeField] GameObject parent;

	// Use this for initialization
	void Start () {        
	}
	
	// Update is called once per frame
	void Update () {
		if(OVRInput.GetUp(OVRInput.RawButton.A)) {
            if (model.transform.parent.gameObject != parent.gameObject)
            {
                model.transform.parent = parent.transform;
                Debug.Log("detached");
            }
            else
            {
                model.transform.parent = camera.transform;
                Debug.Log("attached");
            }
        }

       //model.transform.rotation.pitch = new Vector3(0, 0, 0);
       //model.transform.localEulerAngles = new Vector3(0, 0, 0); // don't rotate?? -- doesn't work
       model.transform.position = new Vector3(camera.transform.position.x , camera.transform.position.y, camera.transform.position.z); // have model follow camera? -- model + camera floating upwards??

       // model.transform.position = new Vector3(Mathf.Clamp(camera.transform.position.x, camera.transform.position.x - 0.5f, camera.transform.position.x + 0.5f), Mathf.Clamp(camera.transform.position.y, camera.transform.position.y - 0.5f, camera.transform.position.y + 0.5f), Mathf.Clamp(camera.transform.position.z, camera.transform.position.z - 0.5f, camera.transform.position.z + 0.5f)); // less shaky? -- did nothing


        /* IDEAS */
        // camera > model, follow everything but pitch (rotating about x axis)
        // model > camera, follow camera position but offset it i guess? 
        

    }
}
