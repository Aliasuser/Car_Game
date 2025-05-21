using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlaceScriptLevel2 : MonoBehaviour, IDropHandler
{
    //Uzstāda mašīnas salīdzināšas mainīgos
    private float placeZRotation, carZRotation, difZRotation;
    private Vector2 placeSize, carSize;
    private float xSizeDif, ySizeDif;
    public ObjectScriptLevel2 objectScript;
    public void OnDrop(PointerEventData eventData) // Pārbauda vai mašīna tiek vilkta un dabū rotāciju, izmēru un atšķirību
    {
        if ((eventData.pointerDrag != null) && Input.GetMouseButtonUp(0) && Input.GetMouseButton(2) == false)
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

                if ((difZRotation <= 10 || (difZRotation >= 350 && difZRotation <= 360)) && (xSizeDif <= 0.1 && ySizeDif <= 0.1))
                {
                    Debug.Log("Right Place");
                    objectScript.rightPlace = true;
                    //Izcentre poziciju
                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                    //Pielago rotaciju
                    eventData.pointerDrag.GetComponent<RectTransform>().localRotation = GetComponent<RectTransform>().localRotation;
                    //Pielago izmeru
                    eventData.pointerDrag.GetComponent<RectTransform>().localScale = GetComponent<RectTransform>().localScale;
                    switch (eventData.pointerDrag.tag) // Atskaņo audio failus, kad mašīnas tiek ievietotas pareizās vietās
                    {
                        case "Convertible":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClips[0]);
                            break;
                        case "Tow":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClips[1]);
                            break;
                        case "Oppressor":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClips[2]);
                            break;
                        case "Horse":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClips[3]);
                            break;
                        case "Lamborghini":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClips[4]);
                            break;
                        case "Luxury":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClips[5]);
                            break;
                        case "Pickup":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClips[6]);
                            break;
                        default:
                            Debug.LogError("Unknown tag!");
                            break;
                    }
                }

            }
            else //Pārliecinas, ka mašīna nav pareizā vietā un atskaņo error audio
            {
                objectScript.rightPlace = false;
                objectScript.audioSource.PlayOneShot(objectScript.audioClips[7]);

                switch (eventData.pointerDrag.tag) //Atgriež mašīnas ja nav pareizajās vietās, pārbaude
                {
                    case "Convertible":
                        objectScript.convertible.GetComponent<RectTransform>().localPosition = objectScript.convertiblePos;
                        break;
                    case "Tow":
                        objectScript.towTruck.GetComponent<RectTransform>().localPosition = objectScript.towTruckPos;
                        break;
                    case "Oppressor":
                        objectScript.oppressor.GetComponent<RectTransform>().localPosition = objectScript.oppressorPos;
                        break;
                    case "Horse":
                        objectScript.horse.GetComponent<RectTransform>().localPosition = objectScript.horsePos;
                        break;
                    case "Lamborghini":
                        objectScript.lamborghini.GetComponent<RectTransform>().localPosition = objectScript.lamborghiniPos;
                        break;
                    case "Luxury":
                        objectScript.luxuryCar.GetComponent<RectTransform>().localPosition = objectScript.luxuryCarPos;
                        break;
                    case "Pickup":
                        objectScript.pickupTruck.GetComponent<RectTransform>().localPosition = objectScript.pickupTruckPos;
                        break;
                    default:
                        Debug.LogError("Unknown tag!");
                        break;
                }

            }




        }
    }
}
