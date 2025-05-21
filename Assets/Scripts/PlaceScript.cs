using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlaceScript : MonoBehaviour, IDropHandler
{

    private float placeZRotation, carZRotation, difZRotation;
    private Vector2 placeSize, carSize;
    private float xSizeDif, ySizeDif;
    public ObjectScript objectScript;
    public void OnDrop(PointerEventData eventData)
    {
       if((eventData.pointerDrag != null) && Input.GetMouseButtonUp(0) && Input.GetMouseButton(2) == false)
        {
            if (eventData.pointerDrag.tag.Equals(tag))
            {
                placeZRotation = eventData.pointerDrag.GetComponent<RectTransform>().transform.eulerAngles.z;
                carZRotation = GetComponent<RectTransform>().transform.eulerAngles.z;

                difZRotation = Mathf.Abs(placeZRotation - carZRotation);
                Debug.Log("Dif Z Rotation: " + difZRotation);

                placeSize = eventData.pointerDrag.GetComponent<RectTransform>().localScale;
                carSize = GetComponent<RectTransform>().localScale;
                xSizeDif = Mathf.Abs(placeSize.x - carSize.x);
                ySizeDif = Mathf.Abs(placeSize.y - carSize.y);
                Debug.Log("Dif X Size: " + xSizeDif + "\nDif Y Size: " + ySizeDif);

                if((difZRotation <=5 || (difZRotation >= 355 && difZRotation <= 360)) && (xSizeDif <= 0.1 && ySizeDif <= 0.1)){
                    Debug.Log("Right Place");
                    objectScript.rightPlace = true;
                    //Izcentre poziciju
                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                    //Pielago rotaciju
                    eventData.pointerDrag.GetComponent<RectTransform>().localRotation = GetComponent<RectTransform>().localRotation;
                    //Pielago izmeru
                    eventData.pointerDrag.GetComponent<RectTransform>().localScale = GetComponent<RectTransform>().localScale;
                    switch (eventData.pointerDrag.tag)
                    {
                        case "Garbage":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClips[2]);
                            break;
                        case "Medic":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClips[4]);
                            break;
                        case "School":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClips[3]);
                            break;
                        case "Cement":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClips[10]);
                            break;
                        case "Police":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClips[12]);
                            break;
                        case "Tractor":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClips[7]);
                            break;
                        case "Fire":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClips[11]);
                            break;
                        case "Excavator":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClips[8]);
                            break;
                        case "Tractor2":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClips[13]);
                            break;
                        case "E46":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClips[5]);
                            break;
                        case "E61":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClips[11]);
                            break;
                        case "B2":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClips[6]);
                            break;
                        default:
                            Debug.LogError("Unknown tag!");
                            break;
                    }
                }

            }
            else
            {
                objectScript.rightPlace = false;
                objectScript.audioSource.PlayOneShot(objectScript.audioClips[1]);

                switch (eventData.pointerDrag.tag)
                {
                    case "Garbage":
                        objectScript.garbageTruck.GetComponent<RectTransform>().localPosition = objectScript.gTruckPos;
                        break;
                    case "Medic":
                        objectScript.ambulance.GetComponent<RectTransform>().localPosition = objectScript.ambulancePos;
                        break;
                    case "School":
                        objectScript.schoolBus.GetComponent<RectTransform>().localPosition = objectScript.sBusPos;
                        break;
                    case "Cement":
                        objectScript.cementTruck.GetComponent<RectTransform>().localPosition = objectScript.cementTruckPos;
                        break;
                    case "Police":
                        objectScript.police.GetComponent<RectTransform>().localPosition = objectScript.policePos;
                        break;
                    case "Tractor":
                        objectScript.tractor.GetComponent<RectTransform>().localPosition = objectScript.tractorPos;
                        break;
                    case "Fire":
                        objectScript.fireTruck.GetComponent<RectTransform>().localPosition = objectScript.fireTruckPos;
                        break;
                    case "Excavator":
                        objectScript.excavator.GetComponent<RectTransform>().localPosition = objectScript.excavatorPos;
                        break;
                    case "Tractor2":
                        objectScript.tractor2.GetComponent<RectTransform>().localPosition = objectScript.tractor2Pos;
                        break;
                    case "E46":
                        objectScript.E46.GetComponent<RectTransform>().localPosition = objectScript.E46Pos;
                        break;
                    case "E61":
                        objectScript.E61.GetComponent<RectTransform>().localPosition = objectScript.E61Pos;
                        break;
                    case "B2":
                        objectScript.B2.GetComponent<RectTransform>().localPosition = objectScript.B2Pos;
                        break;
                    default:
                        Debug.LogError("Unknown tag!");
                        break;
                }

            }
            

          

        }
    }
}
