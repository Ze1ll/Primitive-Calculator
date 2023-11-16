class Program
{
	static void Calculator(string a)
	{
		int output;
		string num11 = "";
		string num21 = "";
		int tyt=0;
		for(int i = 0; i < a.Length; i++)
		{
			
			if (a[i] == '-' || a[i] == '+' || a[i] == '/' || a[i] == '*')
			{
				tyt = i;
				for (int j = tyt+1; j < a.Length; j++)
				{
					num21 += a[j];
				}
				for(int k=0; k < tyt; k++)
				{
					if (k < tyt)
					{
						num11 += a[k];

					}
				}
			}
		}
		int num1 = Convert.ToInt32(num11);
		int num2 = Convert.ToInt32(num21);
		
		if (a[tyt] == '-' || a[tyt] == '+' || a[tyt] == '/' || a[tyt] == '*')
		{
			switch (a[tyt])
			{
				case '-':
					{
						output = num1 - num2;
						Console.WriteLine(output);
						break;
					}
				case '+':
					{
						output = num1 + num2;
						Console.WriteLine(output);
						break;
					}
				case '/':
					{
						output = num1 / num2;
						Console.WriteLine(output);
						break;
					}
				case '*':
					{
						output = num1 * num2;
						Console.WriteLine(output);
						break;
					}
				default:
					{
						Console.WriteLine("Exception: id10t");
						break;
					}
			}
		}
	}




	static void Main()
	{
		Console.WriteLine("Введите выражение типа: a+b");
		string vvod = Console.ReadLine();
		Calculator(vvod);
	}

}
