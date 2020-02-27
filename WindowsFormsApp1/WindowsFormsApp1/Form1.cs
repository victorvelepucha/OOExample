using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Abstraction;
using WindowsFormsApp1.Interface;


namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		const int NUM = 100;
		const double TWOPI = (2 * 3.14159);

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Square s = new Square(6);
			Console.WriteLine("Area  = " + s.AreaCalculated());
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Derived d = new Derived();

			Console.WriteLine("Addition : {0}\nMultiplication :{1}",
											  d.AddTwoNumbers(4, 6),
										d.MultiplyTwoNumbers(6, 4));
		}

		private void button3_Click(object sender, EventArgs e)
		{
			absDerived d = new absDerived();
			d.numbers = 5;
			Console.WriteLine(d.numbers);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			// Creating object 
			MyClass obj1 = new MyClass();

			// calling method 
			obj1.show();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			int cxClient = this.Width/2;
			int cyClient = this.Height;
			int cxClientAux=0, cyClientAux=0;
			for (int i = 0; i < NUM; i++)
			{
				cxClientAux = i * cxClient / NUM;
				cyClientAux = (int)(cyClient / 2 * (1 - Math.Sin(TWOPI * i / NUM)));
				// Create the starting point.
				Point startPoint = new Point(cxClientAux, cyClientAux);

				// Use the addition operator to get the end point.
				Point endPoint = startPoint + new Size(1, 1);

				// Draw a line between the points.
				e.Graphics.DrawLine(SystemPens.Highlight, startPoint, endPoint);
				//System.Threading.Thread.Sleep(100);
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			int resultX;
			int resultY;

			Point parentPoint = this.Location;
			MessageBox.Show(this.Width + "\n" + this.Height);


		}

		private void button6_Click(object sender, EventArgs e)
		{
			// creating object of derived class 
			Interface2a g = new Interface2a();

			// calling the method of base class  
			// using the derived class object 
			g.readers("Kirti", "C#");

		}

		private void button7_Click(object sender, EventArgs e)
		{
			ClassInterface3 obj = new ClassInterface3();

			// calling the method  
			// using object 'obj' 
			obj.mymethod1();
			obj.mymethod2();
			obj.mymethod3();
		}
	}
}
