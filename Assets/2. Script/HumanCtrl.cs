using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HumanCtrl : MonoBehaviour
{
    public float speed = 1f;

    public Rigidbody RB;

    public GameObject CanvusCat1;
    public GameObject CanvusCat2;
    public GameObject CanvusCat3;
    public GameObject CanvusTiger;

    public GameObject EndingCanvus;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            RB.AddForce(Vector3.up * 10f, ForceMode.Impulse);
        }

        // 3���� ������ ����� �� EndingCanvus�� ������ �Ϸ���?
        // ���󿡴� REWARD �±װ� �������
       
 
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "CAT1")
        {
            CanvusCat1.SetActive(true);
        }

        if (collision.transform.tag == "CAT2")
        {
            CanvusCat2.SetActive(true);
        }

        if (collision.transform.tag == "CAT3")
        {
            CanvusCat3.SetActive(true);
        }

        if (collision.transform.tag == "CAT")
        {
            CanvusTiger.SetActive(true);
        }
    }

}
