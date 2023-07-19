using System;

namespace AddedMath.CoordinateSystem
{
	public class Vector2{
		double X; 
		double Y;
		
		public Vector2(double x, double y){
			this.X = x;
			this.Y = y;
		}
		
		public Vector2 SetCoords(double x, double y){
			this.X = x;
			this.Y = y;
			return this;
		}
				
		public double GetXCoord(){
			return this.X;
		}
		
		public double GetYCoord(){
			return this.Y;
		}
		
		public Vector2 SetXCoord( double x){
			this.X = x;
			return this;
		}
		
		public Vector2 SetYCoord(double y){
			this.Y = y;
			return this;
		}
	}
}
