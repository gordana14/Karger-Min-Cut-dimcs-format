using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalSession3
{
    public partial class frmMainWindow : Form
    {
        public frmMainWindow()
        {
            InitializeComponent();
        }
        int iNumbVertex = 0;
        int iNumbEdge = 0;
        List<Edge> lsEdges = new List<Edge>();
        string line;
        string res = "";

        public List<string> readInstances()
        {

            //
            // Read in a file line-by-line, and store it all in a List.
            //
            List<string> list = new List<string>();
            using (System.IO.StreamReader reader = new System.IO.StreamReader("C:\\PROJECTS\\Approx. Algorithms\\Practical session3\\input.txt"))
            {
                string line = reader.ReadLine();
                do
                {
                    if (line.StartsWith("p"))
                    {
                        string[] lsElementLine = line.Split(' ');
                        iNumbVertex = Int32.Parse(lsElementLine[2]);
                        iNumbEdge = Int32.Parse(lsElementLine[3]);

                    }
                    if (line.StartsWith("e"))
                    {
                        string[] lsElementLine = line.Split(' ');
                        int iFirstEdge = Int32.Parse(lsElementLine[1]);
                        int iSecondEdge = Int32.Parse(lsElementLine[2]);
                        lsEdges.Add(new Edge(iFirstEdge, iSecondEdge));

                    }

                } while ((line = reader.ReadLine()) != null);
            }

            return list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  generateInstances();

  
            List<string> list = readInstances();
            MessageBox.Show("Run Karger Algorithm!");
        }

        public int KargerMinCut()
        {

            while (iNumbVertex > 2)
            {
                Random randomLine = new Random();
                int selectLine = randomLine.Next(0, lsEdges.Count - 1);
                Edge selEdge = lsEdges[selectLine];
                lsEdges.RemoveAt(selectLine);

                //   iNumbEdge -= 1;
                iNumbVertex -= 1;

                // List<Edge> lsEdgeForUpdate = lsEdges.Where(g => g.src.All(item => EqualsAll(g.src, selEdge.src) || EqualsAll(g.src, selEdge.dest))).ToList();
                // UpdateListWithNewVertex(selEdge, lsEdgeForUpdate);

                List<Edge>.Enumerator e = lsEdges.GetEnumerator();
                UpdateListWithNewVertex(selEdge, e);
                lsEdges = lsEdges.Where(t => !(Equals(t.src, t.dest))).ToList();


            }
            return lsEdges.Count;

        }


        private IEnumerator<Edge> UpdateListWithNewVertex(Edge selDeleted, IEnumerator<Edge> lsForUpdate)
        {
            List<int> lsNewVertex = selDeleted.src.Concat(selDeleted.dest).ToList();
            lsNewVertex.Sort();
            while (lsForUpdate.MoveNext())
            {
                if (lsForUpdate.Current.src.SequenceEqual(selDeleted.dest) || lsForUpdate.Current.src.SequenceEqual(selDeleted.src))
                    lsForUpdate.Current.src = lsNewVertex;


                if (lsForUpdate.Current.dest.SequenceEqual(selDeleted.dest) || lsForUpdate.Current.dest.SequenceEqual(selDeleted.src))
                    lsForUpdate.Current.dest = lsNewVertex;


                

            }
            return lsForUpdate;
        }

        private bool EqualsAll(List<int> a, List<int> b)
        {

            if (a == null || b == null)
                return (a == null && b == null);

            if (a.Count != b.Count)
                return false;

            return a.SequenceEqual(b);
        }

        private void btnKarger_Click(object sender, EventArgs e)
        {
            int best = KargerMinCut();
            List<int> resAll = new List<int>();
            List<int> resBest = new List<int>();
            for (int x = 0; x < 6; x++)
            {
                readInstances();
                int z = KargerMinCut();
                if (z < best) best = z;
                if (best == 1) { 
                    resAll.Add(z);
                    resBest.Add(best);
                    tbResult.Text += "Result is " + z.ToString() + "best is " + best.ToString() + Environment.NewLine;
                    break;
                }
                else
                {
                    resAll.Add(z);
                    resBest.Add(best);
                    tbResult.Text += "Res is " + z.ToString() + " best is " + best.ToString() + Environment.NewLine;
                }
            }
            List<int> lsXaxisValues = new List<int>();
            for (int i = 0; i < resAll.Count; i++) { lsXaxisValues.Add(i); }
  
            chartBest.Series[0].Points.DataBindXY(lsXaxisValues, resBest);

            chartAll.Series[0].Points.DataBindXY(lsXaxisValues, resAll);






        }

        /*foreach (Edge el in lsEdges)
          {
              foreach (int i in el.src)
              {
                  tbResult.Text += "Src is " + i.ToString() + Environment.NewLine;
              }
              foreach (int j in el.dest)
              {
                  tbResult.Text += "Dest is " + j.ToString() + Environment.NewLine;
              }
          }*/





        internal class Edge
        {
            public List<int> src, dest;
            public Edge(int sr, int des)
            {
                src = new List<int> { sr };
                dest = new List<int> { des };
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            lsEdges = new List<Edge>();
        }
    }
}
