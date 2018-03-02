using UnityEngine;

namespace Trunners
{
	public class PlayerMovement : MonoBehaviour
	{
	    [SerializeField] private string _upControl;
	    [SerializeField] private string _downControl;

        private float _topDownMovement = Constants.TOP_DOWN_DISTANCE;
	    private MapConstraints _mapConstraints;

        void Start ()
        {
            _mapConstraints = FindObjectOfType<MapConstraints>();
		}
		
		void Update ()
		{
		    HandleUpDown();
		}

	    private void HandleUpDown()
	    {
	        if (Input.GetButtonDown(_upControl))
	        {
                if(transform.position.y + 0.1f < _mapConstraints.UpperBound)
	                transform.position += new Vector3(0.0f, _topDownMovement, 0.0f);
	        }

	        if (Input.GetButtonDown(_downControl))
	        {
	            if (transform.position.y - 0.1f > _mapConstraints.BottomBound)
	                transform.position -= new Vector3(0.0f, _topDownMovement, 0.0f);
	        }
        }
	}
}