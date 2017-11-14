using UnityEngine;

public static class GizmosUtil
{
	public static void DrawArrow(Vector3 position, Vector3 direction, Color color, float arrowHeadAngle = 20f, float arrowHeadLength = 0.25f)
	{
		var oldColor = Gizmos.color;
		Gizmos.color = color;

		var tip = position + direction;
		Gizmos.DrawLine(position, tip);

		var right = Quaternion.LookRotation(direction) * Quaternion.Euler(0, 180 + arrowHeadAngle, 0) * new Vector3(0, 0, 1);
		var left = Quaternion.LookRotation(direction) * Quaternion.Euler(0, 180 - arrowHeadAngle, 0) * new Vector3(0, 0, 1);

		Gizmos.DrawLine(tip, tip + right * arrowHeadLength);
		Gizmos.DrawLine(tip, tip + left * arrowHeadLength);
		Gizmos.color = oldColor;
	}
}