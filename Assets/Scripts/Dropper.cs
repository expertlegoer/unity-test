using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 5f;

    MeshRenderer myMesh;
    Rigidbody myGravity;

    void Start()
    {
        myMesh = GetComponent<MeshRenderer>();
        myGravity = GetComponent<Rigidbody>();

        myMesh.enabled = false;
        myGravity.useGravity = false;        
    }

    void Update()
    {
        if (Time.time > timeToWait);
        {
            myMesh.enabled = true;
            myGravity.useGravity = true;
        }
    }
}
