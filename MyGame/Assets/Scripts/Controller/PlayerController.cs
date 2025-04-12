using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonobehaviourSingleton<PlayerController>
{
    [SerializeField]
    private float moveCoroutineTick = 0.1f;

    private Champion champion;
    private Rigidbody champRigid;

    private LayerMask mouseLayerMask;

    private const string MoveCoroutineName = "MoveCoroutine";
    private const string AttackCoroutineName = "AttackCoroutine";

    private bool isMoveCoroutineDoing = false;

    private Vector3 moveDir;
    private Quaternion lookTarget;
    private Vector3 dest = default;

    protected override void Awake()
    {
        base.Awake();
        mouseLayerMask = 1 << LayerMask.NameToLayer("Ground");
    }

    public void SetChampion(GameObject champObject){
        champion = champObject.GetComponent<Champion>();
        champRigid = champObject.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if(Input.GetMouseButtonDown(0)){ // 좌클릭 
            ClickLeft();
        }else if(Input.GetMouseButtonDown(1)){ // 우클릭
            ClickRight();
        }
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Q)){
            AbilityManager.Instance.UseAbility(KeyCode.Q);
        }
        if(Input.GetKey(KeyCode.W)){
            AbilityManager.Instance.UseAbility(KeyCode.W);
        }
        if(Input.GetKey(KeyCode.E)){
            AbilityManager.Instance.UseAbility(KeyCode.E);
        }
        if(Input.GetKey(KeyCode.R)){
            AbilityManager.Instance.UseAbility(KeyCode.R);
        }
    }

    // 그냥 클릭, 정보보기, A-좌클릭 시 공격 
    private void ClickLeft(){
        Debug.Log($"Left Click:");

        
    }

    // 이동, 공격
    private void ClickRight(){
        Debug.Log($"Right Click:");

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, Mathf.Infinity, mouseLayerMask)){
            MovePosition(hit.point);
        }
    }

    

    public void MovePosition(Vector3 vector){
        if(isMoveCoroutineDoing){
            isMoveCoroutineDoing = false;
            StopCoroutine(MoveCoroutineName);
        }
        isMoveCoroutineDoing = true;
        dest = new Vector3(vector.x, champRigid.transform.position.y, vector.z);
        Debug.Log("Dest: " + dest);
        StartCoroutine(MoveCoroutineName);
   }

    public void Attack(){

    }

    public IEnumerator MoveCoroutine(){
        

        float distance = 0f;

        while(dest != default){
            moveDir = dest - champRigid.transform.position;
            Debug.Log("Moving.. " + moveDir);
            lookTarget = Quaternion.LookRotation(moveDir);

            champRigid.transform.position += moveDir.normalized * champion.Stats.MoveSpeed * Time.deltaTime;
            distance = Vector3.Distance(champRigid.transform.position, dest);
            Debug.Log("Distance: " + distance);
            if(distance < 1){
                Debug.Log("Stop");
                break;
            }
            yield return null;
        }

        isMoveCoroutineDoing = false;
        dest = default;
    }


}
