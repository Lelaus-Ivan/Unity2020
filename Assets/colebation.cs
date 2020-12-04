using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colebation : MonoBehaviour
{
    public float x0=0;
	public float y0=0;
	public float m=0;
	public float c=0;
	private float a=0;
	private float k=0;
	private float t=0;
	private float alfa=0;
	
    void Start()
    {
			k = Mathf.Sqrt(c/m);
			alfa = Mathf.Atan(x0*k/y0);
			a = Mathf.Sqrt(x0*x0 + y0*y0/(k*k));
			
    }

    void Update()
    {
        t= t+Time.deltaTime;
		transform.position= new Vector3(a*Mathf.Sin(k*t+alfa), 0.5f, 0);
    }
}
