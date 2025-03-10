using UnityEngine;

public class DragTshirt : MonoBehaviour
{
    private Vector3 offset;
    private Camera cam;
    private bool isDragging = false;
    private bool isInsideTarget = false;
    private Vector3 targetPosition;

    public GameObject tshirt_left;
    public GameObject tshirt_right;
    public GameObject tshirt_middle;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = Camera.main;
    }

    void OnMouseDown(){
        offset = transform.position - cam.ScreenToWorldPoint(Input.mousePosition);
        isDragging = true;
    }

    void OnMouseDrag(){
        if(!isInsideTarget){      
        Vector3 newPosition = cam.ScreenToWorldPoint(Input.mousePosition) + offset;
        transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
    }
        else{
        isDragging = false;    
        transform.position = targetPosition;
    }
    }

    void OnTriggerEnter2D(Collider2D other){
        if(gameObject.CompareTag("TshirtMiddle") && other.CompareTag("TargetZoneMiddle")){
            isInsideTarget = true;
            targetPosition = tshirt_middle.transform.position;
        }
        else if((gameObject.CompareTag("TshirtLeft") || gameObject.CompareTag("TshirtRight")) && other.CompareTag("TargetZoneLeft")){
            isInsideTarget = true;
            targetPosition = tshirt_left.transform.position;
        }
        else if((gameObject.CompareTag("TshirtRight") || gameObject.CompareTag("TshirtLeft")) && other.CompareTag("TargetZoneRight")){
            isInsideTarget = true;
            targetPosition = tshirt_right.transform.position;
        }
        //üç parça yerlerine koyulunca sabitleniyor
        //bundan sonraki görev üç parça yerine konulunca görevin tamamlandığına dair bir geri bildirim almak 
        //ve yapılan tişörtü oyun ekranında görünür kılmak 
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
