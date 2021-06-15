using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;  //DOTweenを使うときはこのusingを入れる

public class AvatorMotion : MonoBehaviour
{

   
    
    public GameObject chara1target1;

    
    bool InArea = false;
    

    Tween charaMove = null;

    // Start is called before the first frame update
    void Start()
    {

        charaMove = this.transform.DOPath(new Vector3[] { chara1target1.transform.position }, 400f).SetLoops(-1, LoopType.Restart).SetEase(Ease.OutSine).SetLookAt(0.01f);
        charaMove.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        Animator anim = GetComponent<Animator>();
        //charaMove = this.transform.DOPath(new Vector3[] {chara1target1.transform.position}, 0f);
        if (InArea)
        {
            charaMove.Play();
            anim.SetBool("IsWalk", true);
            
        }
        else
        {
            anim.SetBool("IsWalk", false);
            this.charaMove.Pause();
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

        Vector3 Apos = this.transform.position;z
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
