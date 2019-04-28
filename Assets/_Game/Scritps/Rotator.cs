using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Vector3 rotate = new Vector3(30f, 40f, 50f);

    private void Update()
    {
        transform.Rotate(rotate * Time.deltaTime);
    }
}