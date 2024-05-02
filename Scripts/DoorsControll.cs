using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class DoorsControll : MonoBehaviour
{
    [SerializeField] private ParticleSystem _fire1;
    [SerializeField] private ParticleSystem _fire2;
    [SerializeField] private AudioSource _audioSource;

    [SerializeField] private PointLight _lightFire1;
    [SerializeField] private PointLight _lightFire2;

    [SerializeField] private Animator _animator;

    private void Start()
    {
        _animator=GetComponent<Animator>();   
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetBool("ActiveDoor", true);
            StartCoroutine(PlayFire());
            _audioSource.Play();
        }
    }

    private IEnumerator PlayFire()
    {
        yield return new WaitForSeconds(1.5f);
        _fire1.gameObject.SetActive(true);
        _fire2.gameObject.SetActive(true);
    }

}
