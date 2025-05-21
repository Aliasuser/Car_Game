using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScriptLevel2 : MonoBehaviour
{
    //Sagatavo mašīnas mainīgos
    public GameObject convertible;
    public GameObject towTruck;
    public GameObject oppressor;
    public GameObject horse;
    public GameObject lamborghini;
    public GameObject luxuryCar;
    public GameObject pickupTruck;

    //Sagatavo mašīnas pozīcijas
    [HideInInspector]
    public Vector2 convertiblePos;
    [HideInInspector]
    public Vector2 towTruckPos;
    [HideInInspector]
    public Vector2 oppressorPos;
    [HideInInspector]
    public Vector2 horsePos;
    [HideInInspector]
    public Vector2 lamborghiniPos;
    [HideInInspector]
    public Vector2 luxuryCarPos;
    [HideInInspector]
    public Vector2 pickupTruckPos;

    //Ievieša audio un mašīnas pārbaudes mainīgos
    public AudioSource audioSource;
    public AudioClip[] audioClips;
    [HideInInspector]
    public bool rightPlace = false;
    public GameObject lastDragged = null;

    // Start is called before the first frame update
    void Start() // Iegūst mašīnas pašreizējo pozīciju
    {
        convertiblePos = convertible.GetComponent<RectTransform>().localPosition;
        towTruckPos = towTruck.GetComponent<RectTransform>().localPosition;
        oppressorPos = oppressor.GetComponent<RectTransform>().localPosition;

        horsePos = horse.GetComponent<RectTransform>().localPosition;
        lamborghiniPos = lamborghini.GetComponent<RectTransform>().localPosition;
        luxuryCarPos = luxuryCar.GetComponent<RectTransform>().localPosition;

        pickupTruckPos = pickupTruck.GetComponent<RectTransform>().localPosition;

    }


}
