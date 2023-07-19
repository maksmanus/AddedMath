using System;

namespace AddedMath
{
	public static class BaseMath{
		
		static double DoubleResult;
		
		static int IntResult;
		
		static float FloatResult;
		
		static long LongResult;
		
		static decimal DecimalResult;
		
		public static int Summ(params int[] Numbers){
			foreach(int Result in Numbers){
				IntResult += Result;
			}
			return IntResult;
		}
		
		public static double Summ(params double[] numbers){
			foreach(double Result in numbers){
				DoubleResult += Result;
			}
			return DoubleResult;
		}
		
		public static float Summ(params float[] numbers){
			foreach(float Result in numbers){
				FloatResult += Result;
			}
			return FloatResult;
		}
		
		public static long Summ(params long[] numbers){
			foreach(long Result in numbers){
				LongResult += Result;
			}
			return LongResult;
		}
		
		public static decimal Summ(params decimal[] numbers){
			foreach(decimal Result in numbers){
				DecimalResult += Result;
			}
			return DecimalResult;
		}
	
		public static int Subtract(params int[] numbers){
			foreach(int Result in numbers){
				IntResult -= Result;
			}
			return IntResult;
		}
		
		public static double Subtract(params double[] numbers){
			foreach(double Result in numbers){
				DoubleResult -= Result;
			}
			return DoubleResult;
		}
		
		public static float Subtract(params float[] numbers){
			foreach(float Result in numbers){
				FloatResult -= Result;
			}
			return FloatResult;
		}
		
		public static long Subtract(params long[] numbers){
			foreach(long Result in numbers){
				LongResult -= Result;
			}
			return LongResult;
		}
		
		public static decimal Subtract(params decimal[] numbers){
			foreach(decimal Result in numbers){
				DecimalResult -= Result;
			}
			return DecimalResult;
		}
		
		public static int Multyply(params int[] numbers){
			foreach(int Result in numbers){
				IntResult *= Result;
			}
			return IntResult;
		}
		
		public static double Multyply(params double[] numbers){
			foreach(double Result in numbers){
				DoubleResult *= Result;
			}
			return DoubleResult;
		}
		
		public static float Multyply(params float[] numbers){
			foreach(float Result in numbers){
				FloatResult *= Result;
			}
			return FloatResult;
		}
		
		public static long Multyply(params long[] numbers){
			foreach(long Result in numbers){
				LongResult *= Result;
			}
			return LongResult;
		}
		
		public static decimal Multyply(params decimal[] numbers){
			foreach(decimal Result in numbers){
				DecimalResult *= Result;
			}
			return DecimalResult;
		}
		
		public static int Separate(int a, int b){
			try{
				IntResult = a / b;
			}
			catch(Exception e){
			  Errorer.StopGoing();
			}
			return IntResult;
		}
		
		public static double Separate(double a, double b){
			try{
				DoubleResult = a / b;
			}
			catch(Exception e){
			  Errorer.StopGoing();
			}
			return DoubleResult;
		}
		
		public static float Separate(float a, float b){
			try{
				FloatResult = a / b;
			}
			catch(Exception e){
			  Errorer.StopGoing();
			}
			return FloatResult;
		}
		
		public static long Separate(long a, long b){
			try{
				LongResult = a / b;
			}
			catch(Exception e){
			  Errorer.StopGoing();
			}
			return LongResult;
		}
		
		public static decimal Separate(decimal a, decimal b){
			try{
				DecimalResult = a / b;
			}
			catch(Exception e){
			  Errorer.StopGoing();
			}
			return DecimalResult;
		}
		
		public static int CalcArithmeticMean(params int[] Numbers){
			foreach(int Result in Numbers){
				IntResult += Result;
			}
			return IntResult / Numbers.Length;	
		}
		
		public static double CalcArithmeticMean(params double[] Numbers){
			foreach(double Result in Numbers){
				DoubleResult += Result;
			}
			return DoubleResult / Numbers.Length;	
		}
		
		public static float CalcArithmeticMean(params float[] Numbers){
			foreach(float Result in Numbers){
				FloatResult += Result;
			}
			return FloatResult / Numbers.Length;	
		}
		
		public static long CalcArithmeticMean(params long[] Numbers){
			foreach(long Result in Numbers){
				LongResult += Result;
			}
			return LongResult / Numbers.Length;	
		}
		
		public static decimal CalcArithmeticMean(params decimal[] Numbers){
			foreach(decimal Result in Numbers){
				DecimalResult += Result;
			}
			return DecimalResult / Numbers.Length;	
		}
		
		public static int CalcRoot(int Number, int b){
			return Number^1/b;
		}
		
		public static double CalcRoot(double Number, double b){
			return Math.Pow(Number, 1/b);
		}
		
		public static float CalcRoot(float Number, float b){
			DoubleResult = Convert.ToDouble(Math.Pow(Number,b));
			FloatResult = (float)DoubleResult;
			return FloatResult;
		}
		
		public static long CalcRoot(long Number, long b){
			return Number^1/b;
		}
		
		public static int CalcModule(int Number){
			if(Number == 0){
				return -Number;
			}
			return Number;
		}
		public static double CalcModule(double Number){
			if(Number == 0){
				return -Number;
			}
			return Number;
		}
		
		public static float CalcModule(float Number){
			if(Number == 0){
				return -Number;
			}
			return Number;
		}
		
		public static long CalcModule(long Number){
			if(Number == 0){
				return -Number;
			}
			return Number;
		}
		
		public static decimal CalcModule(decimal Number){
			if(Number == 0){
				return -Number;
			}
			return Number;
		}
		
	}
}