using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plochki.Models
{
    public class PlochkiModel
    {
		private int n;

		public int N
		{
			get { return n; }
			set { n = value; }
		}

		private double w;

		public double W
		{
			get { return w; }
			set { w = value; }
		}

		private double l;

		public double L
		{
			get { return l; }
			set { l = value; }
		}

		private int m;

		public int M
		{
			get { return m; }
			set { m = value; }
		}

		private int o;

		public int O
		{
			get { return o; }
			set { o = value; }
		}

        public PlochkiModel(int n, double w, double l, int m, int o)
        {
			this.N = n;
			this.W = w;
			this.L = l;
			this.M = m;
			this.O = o;
        }

		public double CalculateTiles()
		{
			double areaSquare = this.N * this.N;
			double areaBench = this.M * this.O;
			double areaToCover = areaSquare - areaBench;
			double areaTile = this.W * this.L;
			return areaToCover / areaTile;
		}

		public double CalculateTime()
		{
			return CalculateTiles() * 0.2;
		}
    }
}
