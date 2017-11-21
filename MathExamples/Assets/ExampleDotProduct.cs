using UnityEngine;

public class ExampleDotProduct : MonoBehaviour {

    public Vector3 v;
    public Vector3 w;

    public float v_dot_w;


	private void OnDrawGizmos()
    {
        GizmosUtil.Draw3DArrow(transform.position, v, Color.magenta);
        GizmosUtil.Draw3DArrow(transform.position, w, Color.cyan);

        v_dot_w = Vector3.Dot(v, w);
    }
}
