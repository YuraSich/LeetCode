public class Solution {
    public double MaxProbability(int n, int[][] edges, double[] succProb, int start_node, int end_node) {
        List<(int,double)>[] g=new List<(int,double)>[n];
        for(int i=0;i<n;++i)
            g[i]=new List<(int,double)>();
        for(int i=0;i<edges.Length;++i)
        {
            int u=edges[i][0];
            int v=edges[i][1];
            g[u].Add((v,succProb[i]));
            g[v].Add((u,succProb[i]));
        }
        return Dijkstra(start_node,end_node,g);
    }

    private double Dijkstra(int start,int end,List<(int,double)>[] g)
    {
        PriorityQueue<int,double> pq=new PriorityQueue<int,double>();
        pq.Enqueue(start,-1);
        double[] costs=new double[g.Length];
        for(int i=0;i<costs.Length;++i)
            costs[i]=-2;
        while(pq.Count>0)
        {
            pq.TryDequeue(out int node,out double cost);
            if(costs[node]!=-2)
                continue;
            costs[node]=cost;
            double tomul=cost*-1;
            foreach(var child in g[node])
            {
                if(costs[child.Item1]==-2)
                    pq.Enqueue(child.Item1,(child.Item2*tomul)*-1);
            }
        }

        if(costs[end]==-2)
            return 0;
        return costs[end]*-1;
    }
}