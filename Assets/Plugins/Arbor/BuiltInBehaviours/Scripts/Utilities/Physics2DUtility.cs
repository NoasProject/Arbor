//-----------------------------------------------------
//            Arbor 3: FSM & BT Graph Editor
//		  Copyright(c) 2014-2021 caitsithware
//-----------------------------------------------------
#if !UNITY_6000_0_11_OR_NEWER && UNITY_6000_0_OR_NEWER && !(UNITY_6000_0_0 || UNITY_6000_0_1 || UNITY_6000_0_2 || UNITY_6000_0_3 || UNITY_6000_0_4 || UNITY_6000_0_5 || UNITY_6000_0_6 || UNITY_6000_0_7 || UNITY_6000_0_8 || UNITY_6000_0_9 || UNITY_6000_0_10)
#define UNITY_6000_0_11_OR_NEWER
#endif
using UnityEngine;

namespace Arbor.Utilities
{
	public static class Physics2DUtility
	{
		public static void CheckReuseCollision2D(OutputSlotCollision2D slot)
		{
			if (Physics2D.reuseCollisionCallbacks && slot != null && slot.branchCount > 0)
			{
				Debug.LogWarning("Collision2D is set to be reused.\nPlease disable the \"Reuse Collision Callbacks\" of Physics2D Settings.");
			}
		}

		public static Vector2 GetLinearVelocity(Rigidbody2D rigidbody2d)
		{
#if UNITY_6000_0_11_OR_NEWER
			return rigidbody2d.linearVelocity;
#else
			return rigidbody2d.velocity;
#endif
		}

		public static void SetLinearVelocity(Rigidbody2D rigidbody2d, Vector2 velocity)
		{
#if UNITY_6000_0_11_OR_NEWER
			rigidbody2d.linearVelocity = velocity;
#else
			rigidbody2d.velocity = velocity;
#endif
		}

		public static void AddLinearVelocity(Rigidbody2D rigidbody2d, Vector2 velocity)
		{
#if UNITY_6000_0_11_OR_NEWER
			rigidbody2d.linearVelocity += velocity;
#else
			rigidbody2d.velocity += velocity;
#endif
		}

		public static float GetAngularDamping(Rigidbody2D rigidbody2d)
		{
#if UNITY_6000_0_11_OR_NEWER
			return rigidbody2d.angularDamping;
#else
			return rigidbody2d.angularDrag;
#endif
		}

		public static float GetLinearDamping(Rigidbody2D rigidbody2d)
		{
#if UNITY_6000_0_11_OR_NEWER
			return rigidbody2d.linearDamping;
#else
			return rigidbody2d.drag;
#endif
		}
	}
}