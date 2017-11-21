using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleTransform : MonoBehaviour
{
	public Vector3 position = Vector3.zero;
	public Vector3 rotation = Vector3.zero;
	public Vector3 scale = Vector3.one;

	public Vector3 v;

	private void OnDrawGizmos()
	{
//		var tmpV = transform.TransformPoint(v);
//		var tmpV = transform.TransformDirection(v);
		var tmpV = new Vector4(v.x, v.y, v.z, 1);

		var scaleMatrix = Matrix4x4.identity;
		scaleMatrix[0, 0] = scale.x;
		scaleMatrix[1, 1] = scale.y;
		scaleMatrix[2, 2] = scale.z;

		// scaleMatrix = Matrix4x4.Scale(scale);

		var rotationXMatrix = Matrix4x4.identity;
		var angleX = Mathf.Deg2Rad * rotation.x;
		rotationXMatrix[1, 1] = Mathf.Cos(angleX); rotationXMatrix[1, 2] = -Mathf.Sin(angleX);
		rotationXMatrix[2, 1] = Mathf.Sin(angleX); rotationXMatrix[2, 2] = Mathf.Cos(angleX);

		var rotationYMatrix = Matrix4x4.identity;
		var angleY = Mathf.Deg2Rad * rotation.y;
		rotationYMatrix[0, 0] = Mathf.Cos(angleY);  rotationYMatrix[0, 2] = Mathf.Sin(angleY);
		rotationYMatrix[2, 0] = -Mathf.Sin(angleY); rotationYMatrix[2, 2] = Mathf.Cos(angleY);

		var rotationZMatrix = Matrix4x4.identity;
		var angleZ = Mathf.Deg2Rad * rotation.z;
		rotationZMatrix[0, 0] = Mathf.Cos(angleZ); rotationZMatrix[0, 1] = -Mathf.Sin(angleZ);
		rotationZMatrix[1, 0] = Mathf.Sin(angleZ); rotationZMatrix[1, 1] = Mathf.Cos(angleZ);

		var translationMatrix = Matrix4x4.identity;
		translationMatrix[0, 3] = position.x;
		translationMatrix[1, 3] = position.y;
		translationMatrix[2, 3] = position.z;

		Debug.Log(translationMatrix);

		GizmosUtil.Draw2DArrow(transform.position, scaleMatrix * rotationXMatrix * rotationYMatrix * rotationZMatrix * translationMatrix * tmpV, Color.cyan);
	}
}
