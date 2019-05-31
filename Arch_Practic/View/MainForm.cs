using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arch_Practic.Controller;

namespace Arch_Practic
{
	public partial class MainForm : Form
	{
        MainController controller;

		public MainForm()
		{
			InitializeComponent();
            controller = new MainController();
		}

        private void BtnAddEdge_Click(object sender, EventArgs e) {
            string p1 = textPoint1.Text;
            string p2 = textPoint2.Text;
            string weight = textWeight.Text;

            textPoint1.Clear();
            textPoint2.Clear();
            textWeight.Clear();

            controller.AddButtonClick(p1.ToUpper(), p2.ToUpper(), weight, tableEdges);            
        }

        private void BntDeleteEdge_Click(object sender, EventArgs e) {
            controller.DeleteItemClick(tableEdges);
        }

		private void btnDeleteAll_Click(object sender, EventArgs e)
		{
			controller.DeleteAllItems(tableEdges);
		}

		private void btnFindSolution_Click(object sender, EventArgs e)
		{
			controller.FindSolutionClick(minWeightValueLabel, textMinWay);
		}
	}
}
