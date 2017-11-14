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

		var m = new Matrix4x4();
		m[0, 0] = 0.1f;
		m.m00 = 0.1f;

		GizmosUtil.DrawArrow(transform.position, direction, color);
	}
}
