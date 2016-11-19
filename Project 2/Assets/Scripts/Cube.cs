using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {

    public Material[] materials;
    public float rotationSpeed;
    Renderer rend;
    Shader shade;

	// Use this for initialization
	void Start () {
        rotationSpeed = 50f;
        shade = GetComponent<Shader>();
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        
        //rend.sharedMaterial = materials[0];
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);

        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            rend.sharedMaterial = materials[1];
        }
        else if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            rend.sharedMaterial = materials[2];
        }
        else if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            rend.sharedMaterial = materials[3];
        }
        else if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            rend.sharedMaterial = materials[4];
        }
        else if (Input.GetKeyUp(KeyCode.Alpha5))
        {
            rend.sharedMaterial = materials[5];
        }
        else if (Input.GetKeyUp(KeyCode.Alpha6))
        {
            rend.sharedMaterial = materials[6];
        }
    }
}
