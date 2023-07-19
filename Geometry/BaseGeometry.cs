using System;

namespace AddedMath.Geometry
{
	public static class BaseGeometry{
		public static int SquareQuad(int a){
			return a * a;
		}
		
		public static double SquareQuad(double a){
			return a * a;
		}
		
		public static float SquareQuad(float a){
			return a * a;
		}
		
		public static long SquareQuad(long a){
			return a * a;
		}
		
		public static decimal SquareQuad(decimal a){
			return a * a;
		}
		
		public static int RectangleSquare(int a, int b){
			return a * b;
		}
		
		public static double RectangleSquare(double a, double b){
			return a * b;
		}
		
		public static float RectangleSquare(float a, float b){
			return a * b;
		}
		
		public static long RectangleSquare(long a, long b){
			return a * b;
		}
		
		public static decimal RectangleSquare(decimal a, decimal b){
			return a * b;
		}
		
		public static int QuadVolume(int a){
			return a^3;
		}
		
		public static double QuadVolume(double a){
			return a * a * a;
		}
		
		
		
		public static int SquareCircleRadius(int Radius){
			return (int)Constants.PI * (Radius^2);
		}
		
		public static double SquareCircleRadius(double Radius){
			return Constants.PI * (Radius * Radius);
		}
		
		public static float SquareCircleRadius(float Radius){
			return (float)Constants.PI * (Radius * Radius);
		}
		
		public static long SquareCircleRadius(long Radius){
			return (long)Constants.PI * (Radius * Radius);
		}
		
		public static decimal SquareCircleRadius(decimal Radius){
			return (decimal)Constants.PI * (Radius * Radius);
		}
		
		public static int SquareCircleDiametr(int Diametr){
			return (int)Constants.PI * Diametr;
		}
		
		public static double SquareCircleDiametr(double Diametr){
			return Constants.PI * Diametr;
		}
		
		public static float SquareCircleDiametr(float Diametr){
			return (float)Constants.PI * Diametr;
		}
		
		public static long SquareCircleDiametr(long Diametr){
			return (long)Constants.PI * Diametr;
		}
		
		public static decimal SquareCircleDiametr(decimal Diametr){
			return (decimal)Constants.PI * Diametr;
		}
	
	}
}
