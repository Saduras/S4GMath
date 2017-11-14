using UnityEngine;

public class Example : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}


	private void OnDrawGizmos()
	{
		var direction = transform.forward;
		var color = Color.red;

		GizmosUtil.DrawArrow(transform.position, direction, color);
	}
}
