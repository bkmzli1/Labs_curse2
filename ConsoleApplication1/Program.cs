using System;

namespace ConsoleApplication1
{
   	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите желаемое количество повторений эксперимента: ");
			int Nk = Convert.ToInt32(Console.ReadLine());

			Random rnd = new Random();
			double Iavg = 0;
			int N = 59, t;

			for (int n = 0; n < Nk; n++) // n - кол-во повторений эксперимента
			{
				Console.WriteLine("Эксперимент № " + (n + 1));
				double[] px = new double[N];
				double[,] pxy = new double[N, N];
				double b = 1, Ix = 0, prob = 0, bi = 1;

				for (int k = 0; k < N; k++)
				{
					px[k] = b * rnd.NextDouble(); // заполнение элементов массива случайными числами
					b -= px[k]; // уменьшение верхнего предела с каждой итерацией
					Ix += (-1) * px[k] * Math.Log(px[k], 2); // вычисление количества информации совокупности дискретных случайных сообщений
					prob += px[k]; // проверка общей вероятности (должна ровняться 1)
					Console.WriteLine("px[" + k + "]  =   " + px[k]);
				}

				Console.WriteLine();
				Console.WriteLine("Матрица вероятности перехода со входа на выход P(X|Y)");
				Console.WriteLine();
				for (int i = 0; i < N; i++)
				{
					t = i;
					bi = 1;
					pxy[i, t] = 0.7 + 0.3 * rnd.NextDouble();
					bi -= pxy[i, t];
					string a = "";
					for (int j = 0; j < N; j++)
					{
						if (i == j)
						{
							a += "P(X" + (i + 1) + "|" + "Y" + (j + 1) + ") = " + pxy[i, j] + ";   ";
							continue;
						}
						else
						{
							pxy[i, j] = bi * rnd.NextDouble();
							bi -= pxy[i, j];
							a += "P(X" + (i + 1) + "|" + "Y" + (j + 1) + ") = " + pxy[i, j] + ";   ";
						}
						
					}
					Console.Write(a);
					Console.WriteLine();
				}

				Console.WriteLine();
				Console.WriteLine("Вероятности появления совокупности дискретных сообщений на выходе информационного устройства (P(Y))");
				double[] yj = new double[N];
				for (int i = 0; i < N; i++) // Вероятность появления совокупности дискретных сообщений на выходе информационного устройства P(y(j))
				{
					string l = "";
					double Pyj = 0;
					for (int j = 1; j < N; j++)
					{
						Pyj += px[j] * pxy[i, j];
					}
					yj[i] = Pyj;
					l += "py" + (i + 1) + " = " + Pyj + "; ";
					Console.WriteLine(l);
				}

				Console.WriteLine();
				Console.WriteLine("Матрица вероятности  совместных событий P(X,Y)");
				Console.WriteLine();
				double[,] pxyi = new double[N, N]; // P (X , Y)
				for (int i = 0; i < N; i++)
				{
					string s = "";
					for (int j = 0; j < N; j++)
					{
						pxyi[i, j] = yj[j] * pxy[i, j];
						s += "P(X" + (i + 1) + "," + "Y" + (j + 1) + ") = " + pxyi[i, j] + ";   ";
					}
					Console.WriteLine(s);
					Console.WriteLine();
				}

				double Hx = 0;
				for (int i = 0; i < N; i++)  // H(x)
				{
					Hx += (-1) * px[i] * Math.Log(px[i], 2);
				}

				double Hxy = 0; // H(x/y)
				for (int i = 0; i < N; i++)
				{
					for (int j = 0; j < N; j++)
					{
						Hxy += (-1) * pxyi[i, j] * Math.Log(pxy[i, j], 2);
					}
				}

				double Ixy = Hx - Hxy;

				Console.WriteLine();
				Console.WriteLine("Энтропия на входе информационного устройства: Н(х) = " + Hx);
				Console.WriteLine("Условная энтропия выходного сообщения относительно входного: Н(х/у) = " + Hxy);
				Console.WriteLine("Количество информации при неполной достоверности сообзений: I(x,y) = " + Ixy);
				Console.WriteLine("===================================================");

				Iavg += Ixy / 10; // Iср
			}

			Console.WriteLine("Среднее количество информации при неполной достоверности сообщений: Iср = " + Iavg);
			Console.ReadKey(true);
		}
	}

}
