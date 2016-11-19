using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

    public bool ortho;

	// Use this for initialization
	void Start () {
        ortho = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if(ortho)
            {
                ortho = false;
            }
            else
            {
                ortho = true;
            }
            
            
        }
        Camera.main.orthographic = ortho;
    }
}
