using System.Collections;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public GameObject player;
	private Vector3 offset;
	void start()	 
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}