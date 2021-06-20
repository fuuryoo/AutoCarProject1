using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CarStopforPeople3 : MonoBehaviour
{





    public GameObject chara1target3;



    bool InArea = false;


    Tween SpecialMove = null;

    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        Animator anim = GetComponent<Animator>();
        //charaMove = this.transform.DOPath(new Vector3[] {chara1target1.transform.position}, 0f);
        if (InArea)
        {
            if (TriggarManagement.Triggar3)
            {
                
                SpecialMove = this.transform.DOPath(new Vector3[] { chara1target3.transform.position }, 15f).SetDelay(4f).SetLoops(-1, LoopType.Restart).SetEase(Ease.OutSine);
                anim.SetBool("IsWalk", true);
                ProcessTimer.Start();
            }

            /*if (TriggarManagement.Triggar2)
            {
                SpecialMove = this.transform.DOPath(new Vector3[] { chara1target2.transform.position }, 55f).SetDelay(3f).SetLoops(-1, LoopType.Restart).SetEase(Ease.OutSine);
                anim.SetBool("IsWalk", true);
            }*/

        }
        else
        {
            anim.SetBool("IsWalk", false);
            this.SpecialMove.Kill();
        }

        /*if (Input.GetKeyDown("KeyCode.D"))
        {
            transform.Rotate(0,2,0);
            
        }
 
        if (Input.GetKey("left"))
        {
            transform.Rotate(0, -2, 0);
        }
        Vector3 direction = Target.position - this.transform.position;
        direction = direction.normalized;

        Vector3 Apos = this.transform.position;
        Vector3 Bpos = Target.transform.position;
        float distance = Vector3.Distance(Apos, Bpos);

        if (distance > DetecDist)
        {
            InArea = false;
        }

        if(Input.GetKey("space")){
            anim.SetBool("IsWalk", true);
        }
        else{
            anim.SetBool("IsWalk", false);
        }
    }
        */
    }
    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            InArea = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            InArea = false;
        }
    }

}