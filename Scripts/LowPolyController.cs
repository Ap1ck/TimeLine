using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class LowPolyController : MonoBehaviour
{
    [SerializeField] private PlayableDirector _plDirector;

    private void Start()
    {
        _plDirector = GetComponent<PlayableDirector>();
    }

    private void Update()
    {
            _plDirector.Play();
    }
}
