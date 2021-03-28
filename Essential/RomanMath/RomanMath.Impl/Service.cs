using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanMath.Impl
{
	public static class Service
	{
		private static Dictionary<char, short> romToArab = new Dictionary<char, short>
     			{{'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}};
		public static readonly string[] SIGNS = {"+", "-", "*"};
		
		/// <summary>
		/// See TODO.txt file for task details.
		/// Do not change contracts: input and output arguments, method name and access modifiers
		/// </summary>
		/// <param name="expression"></param>
		/// <returns>decimal format</returns>
		
		///<summary>Evaluates expression represented by a string.</summary>>
		public static int Evaluate(string expression)
		{
			int result;
			
			if (expression.Length == 0) throw new ArgumentException("Ivalid math expression");
			
			List < Dictionary<string, string> > lexems = Lex(expression); //parse lexems

			result = EvaluateLexemes(lexems); //evaluate expression represented by lexems

			return result;
		}

		/// <summary>
		/// Convert from Roman to Arabic format
		/// </summary>
		/// <param name="expression"></param>
		/// <returns>Arabic format</returns>
		private static int RomanToArab(string expression)
		{
			short result = 0;

			for (short i = 0; i < expression.Length - 1; ++i)
			{
				if (romToArab[expression[i]] < romToArab[expression[i + 1]]) result -= romToArab[expression[i]];
				else result += romToArab[expression[i]];
			}

			return result + romToArab[expression[expression.Length - 1]];
		}
		
		/// <summary>
		/// Forms lexems of a string expression.
		/// Type can be either "number" or "operator"
		/// 1st element of array is a dummy for convenience of iteration which checks previous lexem on each step:
		///lexemes = [{"value": "", "type": "dummy"}]
		/// </summary>
		/// <param name="expression"></param>
		/// <returns>List of lexems</returns>
		/// <exception cref="ArgumentException"></exception>
		private static List<Dictionary<string, string>> Lex(string expression)
		{
			char[] romanLeters = {'I', 'V', 'X', 'L', 'C', 'D', 'M'};
			
			//List of lexems
			List<Dictionary<string, string>> lexems = new List<Dictionary<string, string>>();
			lexems.Add(new Dictionary<string, string> {{"type", "dummy"}, {"value", ""}});
			
			//Forms lexems of a string expression.
			foreach (var symbol in expression)
			{
				if (romanLeters.Contains(symbol))
				{
					if (lexems[lexems.Count - 1]["type"] == "number")
					{
						lexems[lexems.Count - 1]["value"] += symbol;
					}
					else
					{
						lexems.Add(new Dictionary<string, string> {{"type", "number"}, {"value", symbol.ToString()}});
					}
				}
				else if (Array.IndexOf(SIGNS, symbol.ToString()) != -1)
				{
					lexems.Add(new Dictionary<string, string> {{"type", "operator"}, {"value", symbol.ToString()}});
				}
				else if (symbol == ' ')
				{
					continue;
				}
				else throw new ArgumentException("Ivalid math expression");
			}

			lexems.RemoveRange(0,1); // Remove 1st element
			
			return lexems;
		}
		
		/// <summary>
		/// Simply turns sign in string form to operator form
		/// </summary>
		/// <param name="operation"></param>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		private static int PerformOperation(string operation, int left, int right)
		{
			switch (operation)
			{
				case "+":
					return left + right;
				case "-":
					return left - right;
				case "*":
					return left * right;
				default:
					throw new ArgumentException("Ivalid operation");
			}
		}
		
		/// <summary>
		/// Evaluates the value of expression represented by lexems
		/// </summary>
		/// <param name="lexems"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		private static int EvaluateLexemes(List<Dictionary<string, string>> lexems)
		{
			int resolt;
			
			//initialize with first value
			if (lexems.Count > 0 && lexems[0]["type"] == "number") resolt = RomanToArab(lexems[0]["value"]);
			else throw new ArgumentException("Ivalid math expression");
			
			if (lexems.Count % 2 == 0) throw new ArgumentException("An operand is missing");

				for (int i = 0; i < lexems.Count / 2; ++i) //take next two lexems in one step
			{
				var next= lexems[2 * i + 1];
				var nextAfterNext = lexems[2 * i + 2];
				
				if (next["type"] == "operator" && nextAfterNext["type"] == "number")
				{
					var nextAfterNextRoman = RomanToArab(nextAfterNext["value"]);
					resolt = PerformOperation(next["value"], resolt,nextAfterNextRoman );
				}
			} 
			return resolt;
		}
	}
}
