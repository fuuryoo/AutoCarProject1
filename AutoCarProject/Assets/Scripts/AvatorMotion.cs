using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;  //DOTweenを使うときはこのusingを入れる

public class AvatorMotion : MonoBehaviour
{

    
    CharacterController Controller;
    Transform Target;
    GameObject Player;
    public GameObject chara1target1;

    [SerializeField]
    bool InArea = false;
    int DetecDist = 1;

    private Tween charaMove = null;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");

        DG.Tweening.DOTween.SetTweensCapacity(tweenersCapacity: 800, sequencesCapacity: 200);
    }

    // Update is called once per frame
    void Update()
    {
        Animator anim = GetComponent<Animator>();
        //charaMove = this.transform.DOPath(new Vector3[] {chara1target1.transform.position}, 0f);
        if(InArea)
        {
            charaMove = this.transform.DOPath(new Vector3[] {chara1target1.transform.position}, 400f);
            anim.SetBool("IsWalk", true);
        }
        else
        {
            anim.SetBool("IsWalk", false);
        }
 
        /*if (Input.GetKeyDown("KeyCode.D"))
        {
            transform.Rotate(0,2,0);
            
        }
 
        if (Input.GetKey("left"))
        {
            transform.Rotate(0, -2, 0);
        }*/
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

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            InArea = true;
        }
    }
    
}
