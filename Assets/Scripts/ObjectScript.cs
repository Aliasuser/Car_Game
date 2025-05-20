using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScript : MonoBehaviour
{
    public GameObject garbageTruck;
    public GameObject schoolBus;
    public GameObject ambulance;
    public GameObject excavator;
    public GameObject cementTruck;
    public GameObject police;
    public GameObject tractor;
    public GameObject fireTruck;
    public GameObject tractor2;
    public GameObject E46;
    public GameObject E61;
    public GameObject B2;

    [HideInInspector]
    public Vector2 gTruckPos;
    [HideInInspector]
    public Vector2 sBusPos;
    [HideInInspector]
    public Vector2 ambulancePos;
    [HideInInspector]
    public Vector2 excavatorPos;
    [HideInInspector]
    public Vector2 cementTruckPos;
    [HideInInspector]
    public Vector2 policePos;
    [HideInInspector]
    public Vector2 tractorPos;
    [HideInInspector]
    public Vector2 fireTruckPos;
    [HideInInspector]
    public Vector2 tractor2Pos;
    [HideInInspector]
    public Vector2 E46Pos;
    [HideInInspector]
    public Vector2 E61Pos;
    [HideInInspector]
    public Vector2 B2Pos;

    public AudioSource audioSource;
    public AudioClip[] audioClips;
    [HideInInspector]
    public bool rightPlace = false;
    public GameObject lastDragged = null;

    // Start is called before the first frame update
    void Start()
    {
        gTruckPos = garbageTruck.GetComponent<RectTransform>().localPosition;
        sBusPos = schoolBus.GetComponent<RectTransform>().localPosition;
        ambulancePos = ambulance.GetComponent<RectTransform>().localPosition;

        excavatorPos = excavator.GetComponent<RectTransform>().localPosition;
        cementTruckPos = cementTruck.GetComponent<RectTransform>().localPosition;
        policePos = police.GetComponent<RectTransform>().localPosition;

        tractorPos = tractor.GetComponent<RectTransform>().localPosition;
        fireTruckPos = fireTruck.GetComponent<RectTransform>().localPosition;
        tractor2Pos = tractor2.GetComponent<RectTransform>().localPosition;

        E46Pos = E46.GetComponent<RectTransform>().localPosition;
        E61Pos = E61.GetComponent<RectTransform>().localPosition;
        B2Pos = B2.GetComponent<RectTransform>().localPosition;
    }

    
}
