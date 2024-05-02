using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SignalBall : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _power=20f;

    private void Start()
    {
        _rigidbody=GetComponent<Rigidbody>();
    }

    public void MoveBall()
    {
        _rigidbody.AddForce(Vector3.right * _power, ForceMode.Impulse);
    }
    
    public void ResizeBall()
    {
        transform.localScale = new Vector3(2, 2, 2);
    }

    public void RemoveObject()
    {
        if (gameObject!=null)
        {
            Destroy(this.gameObject);
        }
    }
}
