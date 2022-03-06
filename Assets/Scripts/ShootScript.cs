using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    [SerializeField]private float animationTime = 0.3f;
    [SerializeField]private GameObject _bullet;
    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<PlayerController>().animator;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            StartCoroutine(Shoot(animationTime));
        }
    }

    IEnumerator Shoot(float time){
        Instantiate(_bullet, transform.position, transform.rotation);
        _animator.SetBool("shooting",true);
        yield return new WaitForSeconds(time);
        _animator.SetBool("shooting",false);
        yield return null;
    }
}
