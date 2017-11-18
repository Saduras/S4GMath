using UnityEditor;
using UnityEngine;

public class ExampleDotProduct : MonoBehaviour {

    public Vector3 v;
    public Vector3 w;

    public float v_dot_w;


	private void OnDrawGizmos()
    {
        DrawArrow(transform.position, v, new Color(0.7f, 0.3f, 0.3f));
        DrawArrow(transform.position, w, new Color(0.3f, 0.7f, 0.3f));

        v_dot_w = Vector3.Dot(v, w);
    }

    private void DrawArrow(Vector3 startPosition, Vector3 vector, Color color)
    {
        Handles.color = color;
        Handles.ArrowHandleCap(0, startPosition, Quaternion.LookRotation(vector), vector.magnitude, Event.current.type);
    }
}
