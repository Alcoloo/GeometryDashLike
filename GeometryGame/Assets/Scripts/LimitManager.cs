using UnityEngine;

namespace Assets.Scripts
{

    /// <summary>
    /// 
    /// </summary>
    public class LimitManager : MonoBehaviour
    {
        private int limitPos = -450;

        protected void Start()
        {

        }

        protected void Update()
        {
            if(transform.TransformPoint(transform.position).x <= limitPos)
            {
                Destroy(gameObject);
            }
        }
    }
}