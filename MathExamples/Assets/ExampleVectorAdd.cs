using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleVectorAdd : MonoBehaviour
{
	public Vector3 v;
	public Vector3 w;

	private void OnDrawGizmos()
	{
		GizmosUtil.Draw2DArrow(transform.position, v, Color.yellow);
		GizmosUtil.Draw2DArrow(v, w, Color.blue);
		GizmosUtil.Draw2DArrow(v, - w, Color.cyan);

		GizmosUtil.Draw2DArrow(transform.position, v - w, Color.red);

	}
}
