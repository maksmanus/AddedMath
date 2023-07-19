using System;

namespace AddedMath.CoordinateSystem
{
	public class Vector3{
		double X;
		double Y; 
		double Z;
		
		public Vector3(double x, double y, double z){
			this.X = x;
			this.Y = y; 
			this.Z = z;
		}
		
		public Vector3 SetCoords(double x, double y, double z){
			this.X = x;
			this.Y = y;
			this.Z = z;
			return this;
		}
				
		public double GetXCoord(){
			return this.X;
		}
		
		public double GetYCoord(){
			return this.Y;
		}
		
		public double GetZCoord(){
			return this.Z;
		}
		
		public Vector3 SetXCoord(double x){
			this.X = x;
			return this;
		}
		
		public Vector3 SetYCoord(double y){
			this.Y = y;
			return this;
		}
		
		public Vector3 SetZCoord(double z){
			this.Z = z;
			return this;
		}
	}
	
}


