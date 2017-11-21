using UnityEngine;

public class ExampleDotProduct : MonoBehaviour {

    public Vector3 v;
    public Vector3 w;

    public float v_dot_w;
    public float v_dot_w_normalized;
    public float alpha;
    public float alpha2;


	private void OnDrawGizmos()
    {
        GizmosUtil.Draw3DArrow(transform.position, v, Color.magenta);
        GizmosUtil.Draw3DArrow(transform.position, w, Color.cyan);

        v_dot_w = Vector3.Dot(v, w);
        v_dot_w_normalized = Vector3.Dot(v.normalized, w.normalized);

        GizmosUtil.Draw3DArrow(transform.position, v.normalized, Color.red);

        alpha = Mathf.Rad2Deg * Mathf.Acos(v_dot_w /(v.magnitude * w.magnitude));
        alpha2 = Vector3.Angle(v, w);
    }
}
