using UnityEngine;


    [RequireComponent(typeof(SphereCollider))]
    public class RoomDuplicateDetector : MonoBehaviour
    {
            [SerializeField] private bool isSomethingAtThisLocation = false;
            [SerializeField] private LayerMask whatArePieces;
            [SerializeField] private SphereCollider sphereColliderCreate;
            [SerializeField] private GameObject roomVisualsAndColliders;

            private void Awake()
            {
                sphereColliderCreate = GetComponent<SphereCollider>();
            }

            void OnEnable()
            {
                bool isAnotherRoomOverlapping = Physics.CheckSphere(transform.position, sphereColliderCreate.radius, whatArePieces);

                if (isAnotherRoomOverlapping)
                {
                    RemoveMe();
                }
                else
                {
                    SetMyRoomHere();
                }
            }

            private void SetMyRoomHere()
            {
                Debug.Log("Nobody here!");
                roomVisualsAndColliders.SetActive(true);
                gameObject.SetActive(false);
            }

            private void RemoveMe()
            {
                Debug.Log("Something is already here!");
                Destroy(transform.parent.gameObject);
            }
        }

