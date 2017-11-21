using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleReflection : MonoBehaviour
{
	public Vector3 v;

	private void OnDrawGizmos()
	{
		var normal = Vector3.up;
		GizmosUtil.Draw3DArrow(transform.position, normal, Color.white);
		GizmosUtil.Draw3DArrow(transform.position - v.normalized, v.normalized, Color.cyan);

		var angle = 180 - Vector3.Angle(normal, v);
		var axis = Vector3.Cross(normal, v);

		GizmosUtil.Draw3DArrow(transform.position, axis.normalized, Color.green);
		var rotation = Quaternion.AngleAxis(angle, axis);

		var reflect = rotation * normal;

		GizmosUtil.Draw3DArrow(transform.position, reflect.normalized, Color.yellow);
	}
}
