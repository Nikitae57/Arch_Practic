using System.Collections.Generic;

namespace Arch_Practic.Model {
    public struct Edge {
        public char point1, point2;
        public int cost;

        public Edge(char p1, char p2, int c) {
            point1 = char.ToUpper(p1);
            point2 = char.ToUpper(p2);
            cost = c;
        }
    }

    public class Graph {
        private static Graph instance;

        public int VertexNum { get { return vertexList.Count; } }

        private List<char> vertexList;

        public List<Edge> MassiveEdges { get; private set; }

        public void ClearGraph() {
            vertexList = new List<char>();
            MassiveEdges = new List<Edge>();
        }

        public bool AddEdge(Edge edge) {
            if (!MassiveEdges.Exists(x =>
            (x.point1 == edge.point1 || x.point1 == edge.point2) &&
            (x.point2 == edge.point1 || x.point2 == edge.point2))) {
                MassiveEdges.Add(edge);
				UpdateVertexList();
				return true;
            }

            UpdateVertexList();
			return false;
        }

        public void RemoveEdge(char p1, char p2) {
            p1 = char.ToUpper(p1);
            p2 = char.ToUpper(p2);

            MassiveEdges.RemoveAll(x => (x.point1 == p1 || x.point1 == p2) &&
                    (x.point2 == p1 || x.point2 == p2));
        }

        public bool ExistEdge(char p1, char p2) {
            p1 = char.ToUpper(p1);
            p2 = char.ToUpper(p2);

            return MassiveEdges.Exists(x => (x.point1 == p1 || x.point1 == p2) &&
                    (x.point2 == p1 || x.point2 == p2));
        }


        public List<List<int>> GetMatrix() {
            vertexList.Sort();

            List<List<int>> result = new List<List<int>>(VertexNum);

            for (int i = 0; i < VertexNum; i++) {
				result.Add(new List<int>(VertexNum));
                for (int j = 0; j < VertexNum; j++)
				{
					result[i].Add(-1);
				}
            }

            foreach (Edge edge in MassiveEdges) {
                int index1 = vertexList.FindIndex(x => x == edge.point1);
                int index2 = vertexList.FindIndex(x => x == edge.point2);

                result[index1][index2] = edge.cost;
                result[index2][index1] = edge.cost;
            }

            for (int i = 0; i < VertexNum; i++) {
                for (int j = 0; j < VertexNum; j++) {
                    if (result[i][j] == -1) {
                        result[i][j] = int.MaxValue;
                    }
                }
            }

            return result;
        }

        public List<char> IntToChar(List<int> vertexs) {
            vertexList.Sort();

            List<char> result = new List<char>(vertexList.Count);

            for (int i = 0; i < vertexList.Count; i++) {
                result.Add(vertexList[vertexs[i]]);
            }

            return result;
        }

        private void UpdateVertexList() {
            vertexList = new List<char>();

            foreach (Edge edge in MassiveEdges) {
                if (!vertexList.Exists(x => x == edge.point1)) {
                    vertexList.Add(edge.point1);
                }

                if (!vertexList.Exists(x => x == edge.point2)) {
                    vertexList.Add(edge.point2);
                }
            }
        }

        private Graph() {
            vertexList = new List<char>();
            MassiveEdges = new List<Edge>();
        }



        public static Graph GetInstance() {
            if (instance == null)
                instance = new Graph();
            return instance;
        }
    }
}
