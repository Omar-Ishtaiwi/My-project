using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;

public class NewMonoBehaviourScript : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float ballSpeed = 2f;


    void Start()
    {

    }

    // Update is called once per frame
    public void MoveBall(Vector2 input){
 Vector3 inputXZPlane = new(input.x, 0, input.y);
sphereRigidbody.AddForce(inputXZPlane* ballSpeed);
}



}


