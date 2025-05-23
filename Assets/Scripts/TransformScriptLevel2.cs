using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TransformScriptLevel2 : MonoBehaviour
{
    public ObjectScriptLevel2 objectScript;

    void Update()
    {
        if (objectScript.lastDragged != null)
        {
            if (Input.GetKey(KeyCode.Z))// Ļauj pagriezt mašīnu uz leju
            {
                objectScript.lastDragged.GetComponent<RectTransform>().transform.Rotate(0, 0, Time.deltaTime * 20f);
            }

            if (Input.GetKey(KeyCode.X)) // Ļauj pagriezt mašīnu uz augšu
            {
                objectScript.lastDragged.GetComponent<RectTransform>().transform.Rotate(0, 0, -Time.deltaTime * 20f);
            }

            if (Input.GetKeyDown(KeyCode.R))// Ļauj invertot mašīnu otrādi
            {
                objectScript.lastDragged.GetComponent<RectTransform>().transform.localScale = new Vector2
                    (objectScript.lastDragged.GetComponent<RectTransform>().transform.localScale.x * -1f, objectScript.lastDragged.GetComponent<RectTransform>().transform.localScale.y);
            }

            if (Input.GetKey(KeyCode.UpArrow))//Paaugstina mašīnu
            {
                if (objectScript.lastDragged.GetComponent<RectTransform>().transform.localScale.y < 1.5f)
                {
                    objectScript.lastDragged.GetComponent<RectTransform>().transform.localScale = new Vector2
                        (objectScript.lastDragged.GetComponent<RectTransform>().transform.localScale.x,
                        objectScript.lastDragged.GetComponent<RectTransform>().transform.localScale.y + 0.001f);
                }
            }

            if (Input.GetKey(KeyCode.DownArrow))//Pazemina mašīnu
            {
                if (objectScript.lastDragged.GetComponent<RectTransform>().transform.localScale.y > 0.5f)
                {
                    objectScript.lastDragged.GetComponent<RectTransform>().transform.localScale = new Vector2
                        (objectScript.lastDragged.GetComponent<RectTransform>().transform.localScale.x,
                        objectScript.lastDragged.GetComponent<RectTransform>().transform.localScale.y - 0.001f);
                }
            }

            if (Input.GetKey(KeyCode.LeftArrow))//Saspiež mašīnu
            {
                if (objectScript.lastDragged.GetComponent<RectTransform>().transform.localScale.x > 0.5f)
                {
                    objectScript.lastDragged.GetComponent<RectTransform>().transform.localScale = new Vector2
                        (objectScript.lastDragged.GetComponent<RectTransform>().transform.localScale.x - 0.001f,
                        objectScript.lastDragged.GetComponent<RectTransform>().transform.localScale.y);
                }
            }

            if (Input.GetKey(KeyCode.RightArrow))//Palielina mašīnu
            {
                if (objectScript.lastDragged.GetComponent<RectTransform>().transform.localScale.x < 1.5f)
                {
                    objectScript.lastDragged.GetComponent<RectTransform>().transform.localScale = new Vector2
                        (objectScript.lastDragged.GetComponent<RectTransform>().transform.localScale.x + 0.001f,
                        objectScript.lastDragged.GetComponent<RectTransform>().transform.localScale.y);
                }
            }
        }
    }
}
