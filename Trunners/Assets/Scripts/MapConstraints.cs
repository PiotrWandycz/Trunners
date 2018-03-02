using UnityEngine;

namespace Trunners
{
	public class MapConstraints : MonoBehaviour
	{
	    [HideInInspector] public float UpperBound;
	    [HideInInspector] public float BottomBound = 0.0f;

        void Start ()
		{
		    SetUpperBound();
		}

	    private void SetUpperBound()
	    {
	        UpperBound = (Constants.PLAYER_NUMBER + 1) * Constants.TOP_DOWN_DISTANCE;
	    }

	    void Update () 
		{
			
		}
	}
}