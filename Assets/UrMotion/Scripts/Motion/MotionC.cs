﻿using UnityEngine;

namespace UrMotion
{
	public class MotionA : MotionVec1C<MotionA>
	{
		override protected float value {
			get {
				return col.a;
			}
			set {
				var c = col;
				c.a = value;
				col = c;
			}
		}
	}

	public class MotionC : MotionVec3C<MotionC>
	{
		override protected Vector3 value {
			get {
				return new Vector3(col.r, col.g, col.b);
			}
			set {
				var c = col;
				c.r = value.x;
				c.g = value.y;
				c.b = value.z;
				col = c;
			}
		}
	}

	public class MotionCA : MotionVec4C<MotionCA>
	{
		override protected Vector4 value {
			get {
				return (Vector4)col;
			}
			set {
				col = (Color)value;
			}
		}
	}
}