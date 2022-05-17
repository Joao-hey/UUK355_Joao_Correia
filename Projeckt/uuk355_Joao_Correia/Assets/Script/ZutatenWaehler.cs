using UnityEngine;

public class ZutatenWaehler : MonoBehaviour
{
    public float offsetWidth = 0.05f;
    public float plateLeft = 0.3f;
    public float zone2h = 0.5f;

    // Start is called before the first frame update
    void Start()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            //checkIfPressed(touch);
        }
    }

    /*void checkIfPressed(Touch touch)
    {
        if (touch.position.x < Screen.width * zone2w && touch.position.y > Screen.height * zone2h) ;
    }*/
    // Update is called once per frame
    void Update()
    {
        
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Touch touch = Input.GetTouch(0);
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(touch.position.x, touch.position.y, 0));
            RaycastHit hit;

            Debug.Log("hellu");

            if (Physics.Raycast(ray, out hit, 100))
            {
                Debug.Log(hit.transform.gameObject.name);
            }
        }
    }
}

