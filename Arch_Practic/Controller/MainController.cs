using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arch_Practic.Model;

namespace Arch_Practic.Controller
{
	class MainController
	{
        public void AddButtonClick(string p1, string p2, string weight, ListView table) {
            char chP1 = p1.ToCharArray()[0];
            char chP2 = p2.ToCharArray()[0];

            int numWeight = Convert.ToInt32(weight);

            Edge edge = new Edge(chP1, chP2, numWeight);
            Graph.GetInstance().AddEdge(edge);

            string[] row = { p1, p2, weight };
            ListViewItem item = new ListViewItem(row);
            table.Items.Add(item);
        }

        public void DeleteItemClick(ListView table) {
            if (table.SelectedItems.Count == 0) {
                return;
            }
            char chP1 = table.SelectedItems[0].SubItems[0].Text[0];
            char chP2 = table.SelectedItems[0].SubItems[1].Text[0];

            Graph.GetInstance().RemoveEdge(chP1, chP2);

            table.SelectedItems[0].Remove();
        }
	}
}
