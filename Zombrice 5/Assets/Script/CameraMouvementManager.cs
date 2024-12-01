using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    private float scroll;
    private float scrollValue = 0;

    void Update()
    {

        scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll > 0f)
        {

            scrollValue += (float)1;
            this.transform.position = new Vector3(0, scrollValue, -10);

        }
        else if (scroll < 0f)
        {

            scrollValue -= (float)1;
            this.transform.position = new Vector3(0, scrollValue, -10);

        }

        Debug.Log(scrollValue);

    }
}

