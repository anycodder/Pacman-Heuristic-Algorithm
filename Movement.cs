/*
 * Ayşe Nuriye Yılmaz	20191701025
 * Sude Özer			20191701023
 */
/***************************************
DFS() 
Time Complexity: The time complexity of DFS is generally O(b^m); where b is the branching factor in the tree
and m is the depth of the search tree. This is because, in the worst-case scenario, DFS can visit all nodes of the tree. 
In the code, the while loop loops until it visits the nodes. The for loop in the while loop also helps branching, 
so it is included in the time complexity calculation. So time complexity -> O(b^m) is.
 
Space Complexity: In the worst case scenario, the space complexity of the DFS() function is O(bm); 
where b is the branching factor and m is the maximum depth. This is because since we are using the stack to store 
the nodes to be expanded,the maximum number of nodes on the stack at any given time is (b-1).m+1, 
So space complexity -> O(b-1)·m+1 -> O(bm) is.
**************************************
 
DFScycle() 
Time Complexity: The time complexity of DFS is generally O(b^m); where b is the branching factor in the graph 
because it is a cycle and m is the depth of the search tree. DFS cycle can visit all nodes of the tree. 
In the code, the while loop loops until it visits the nodes. The for loop in the while loop also helps branching, 
so it is included in the time complexity calculation. So time complexity -> O(b^m) is.
In the worst-case scenario, the DFS cycle has finite branching and depth, infinite complexity can be caused by circular loops.

Space Complexity: The space complexity of the DFScycle() function is O(bm); where b is the branching factor and 
m is the maximum depth. This is because since we are using the stack to store the nodes to be expanded, 
the maximum number of nodes on the stack at any given time is (b-1).m+1, So space complexity -> O(b-1)·m+1 -> O(bm) is. 
In the worst-case scenario, the DFS cycle has finite branching and depth, infinite complexity can be caused by circular loops.
**************************************
 
BFS() 
Time Complexity: BFS may probably find its target at the shallowest point. Therefore, the time complexity 
will be O(b^1 +b^2 +…+b^d) -> O(b^d) where b is the branching factor and d is the shallowest depth. But it may also find its target in the 
deepest depths. So the worst case time complexity is O(b^m) where b is the branching factor and m is the maximum depth.
So in the worst case scenario, time complexity -> O(b^1 +b^2 +…+b^m) -> O(b^m) is.

Space Complexity: BFS may probably find their target in the shallowest point. Therefore the space complexity will be O(b^d); 
where b is the branching factor and d is the shallowest depth. This is because we use queue to store the nodes to be expanded. 
Fringes will always be all nodes of the latest depth. However, it can also find its target at the deepest depths. 
So the in worst case scenario, space complexity is O(b^m); where b is the branching factor and m is the maximum depth.
**************************************
 
BFScycle() 
Time Complexity: BFS may probably find its target at the shallowest point. Therefore, the time complexity 
will be O(b^1 +b^2 +…+b^d) -> O(b^d) where b is the branching factor and d is the shallowest depth. But it may also find 
its target in the deepest depths. So the worst case time complexity is O(b^m) where b is the branching factor 
and m is the maximum depth. So in the worst case scenario, time complexity -> O(b^1 +b^2 +…+b^m) -> O(b^m) is. 
In the worst-case scenario, the BFS cycle has finite branching and depth, infinite complexity can be caused by 
circular loops.

Space Complexity: BFS may probably find their target in the shallowest point. Therefore the space complexity will be 
O(b^d); where b is the branching factor and d is the shallowest depth. This is because we use queue to store the nodes 
to be expanded. Fringes will always be all nodes of the latest depth. However, it can also find its target at the 
deepest depths. So in the worst case scenario space complexity is O(b^m); where b is the branching factor and m is the 
maximum depth. In the worst-case scenario, the BFS cycle has finite branching and depth, infinite complexity can be 
caused by circular loops.
**************************************

IDS()
Time Complexity: IDS may probably find its target at the shallowest point. Therefore, the time complexity 
will be O((d+1)b^0 + d b^1 + (d-1)b^2 + … + (d-(d-1))b^d) -> O(b^d) where b is the branching factor and d is the 
shallowest depth. But it may also find its target in the deepest depths. So the worst case time complexity is O(b^m) 
where b is the branching factor and m is the maximum depth. In worst case, time complexity 
-> O((m) b^1 + (m-1)b^2 + … + (m-(m-1))b^m) -> O(b^m) is.

Space Complexity: The space complexity of the IDS() function is O(bm); where b is the branching factor and 
m is the maximum depth. This is because since we are using the stack to store the nodes to be expanded, the maximum 
number of nodes on the stack at any given time is (bd). In worst case, space complexity -> O(bm) is. 
**************************************
 
UCS()
Time Complexity: UCS focuses on the target by comparing cost calculations. Let's assume it finds the target at depth d.
The node it visits is calculated by the series sum of 1 + b + b2 + ... + b^d = O(b^(d+1)-1)/(b-1). The dominant term 
here is b^d. But the exact solution cannot be calculated with b and d. Let's assume C* is the optimal cost and the 
lowest cost ε is reached on the path to cost C*. By dividing the optimal cost by the lowest cost (C* / ε), 
the worst-case depth is found. The result is O(b^d) -> 0(b^(C* / ε)). And this can be much larger than b^d.

**************************************

Bidirectional BFS()

Time Complexity: In Biderectinal BFS, both searches from start and goal will meet in the middle of the tree and 
run the same time, It may probably find their target in the shallowest point so the time complexity is O(b^(d)) 
where b is the branching factor and d is the depth. 
In worst case scenario, time complexity -> O(b^(b/2) + b^(b/2)) -> O(2b^(b/2)) ->O(b^(b))
 
Space Complexity: In Biderectinal BFS both searches from start and goal will meet in the middle of the tree and 
may probably find their target in the shallowest point. Therefore the space complexity will be O(b^d); where b is 
the branching factor and d is the shallowest depth. This is because we use queue to store the nodes to be expanded. 
Fringes will always be all nodes of the latest depth. 
In worst case scenario, space complexity -> O(b^(d/2) + b^(d/2)) -> O(2b^(d/2)) ->O(b^(d))
**************************************
Greedy()

Time Complexity: Greedy focuses on the target by comparing hcost calculations using Manhattan distances. The number of 
all nodes visited in the worst case with the priority queue can be calculated by the series sum of 1 + b + b2 + ... + b^m 
-> O(b^(m+1)-1)/(b-1) with maximum depth d and branching factor m. However we cannot say O(b^m) is the exact solution 
as it depends on heuristics. Greedy does not need to explore all nodes to maximum depth, nor can it express time 
complexity in terms of a geometric series. So in the worst-case scenario time complexity is O(b^m). 

Space Complexity: Greedy uses a priority queue to find the path using hcost and keeps the hcost from the starting node to 
the current node. In the worst case scenario, since the priority queue tree must keep the nodes at each level, the space 
complexity is 0(b^d) where b is the branching factor and d is the depth. However, Greedy does not need to explore all 
nodes to maximum depth, nor can it express time complexity in terms of a geometric series.
*/




using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    private new Rigidbody2D rigidbody;
    private Vector3 start;
    public LayerMask obstacleLayer;
    private LineRenderer lineRenderer;
    //public PowerPellet powerPellet;
	
    public Vector3 goal = new Vector3(-14.5f, 8.5f, -5);
	private const int MaxDepth = 100;
    private HashSet<Vector3> All_Visited;
    private List<Vector3> answer;

    public Button Button1;
    public Button Button2;
    public Button Button3;
    public Button Button4;
    public Button Button5;
    public Button Button6;
    public Button Button7;
    public Button Button8;
    public Button Button9;
	
	public class Path
	{
		public string path { get; set; } // path with all the cities reached so far
		public int cost { get; set; } // current overall cost of this path g(n)
		public int hcost { get; set; } // current overall cost of this path h(n)
	}

	public class TreeNode
	{
		public Path Path { get; set; } // path with all the cities reached so far
		public int Depth { get; set; } // depth of the node in the tree (only for iterative deepening)
		public Vector3 Position { get; set; }

		public TreeNode node { get; set; }

		public TreeNode(Vector3 position, Path path, int depth)
		{
			Position = position;
			Path = path;
			Depth = depth;
	
		}
	}

	public class PriorityQueue<NodeType, CostType> where CostType : IComparable<CostType>
	{
    	List<Tuple<NodeType, CostType>> priorityQueue = new List<Tuple<NodeType, CostType>>();

		public int Count
        {
            get { return priorityQueue.Count; }
        }

    	public void Dequeue()
		{	
			var LowestCost=priorityQueue[0].Item2;
			int index=0;
			for (int i = 1; i < priorityQueue.Count; i++)
			{	
				var x = priorityQueue[i].Item2;
				if (x.CompareTo(LowestCost) < 0){
					LowestCost=x;
					index=i;
				}	
			}
        	priorityQueue.RemoveAt(index);	
    	}

    	public void Enqueue(NodeType item, CostType priority)
		{
    		priorityQueue.Add(Tuple.Create(item, priority));
		}

		public NodeType Peek()
    	{
			var LowestCost=priorityQueue[0].Item2;
			int index=0;
			for (int i = 1; i < priorityQueue.Count; i++)
			{	
				var x = priorityQueue[i].Item2;
				if (x.CompareTo(LowestCost) < 0){
					LowestCost=x;
					index=i;
				}	
			}
            return priorityQueue[index].Item1;
   		}
	}

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        start = transform.position;
        lineRenderer = GetComponent<LineRenderer>();
        answer = new List<Vector3>();
        All_Visited = new HashSet<Vector3>();
    }

    private void Start()
    {
        //FindFood();	
        Button1.onClick.AddListener(() => FindFood(Button1)); 
        Button2.onClick.AddListener(() => FindFood(Button2));
        Button3.onClick.AddListener(() => FindFood(Button3));
        Button4.onClick.AddListener(() => FindFood(Button4));
        Button5.onClick.AddListener(() => FindFood(Button5)); 
        Button6.onClick.AddListener(() => FindFood(Button6));
        Button7.onClick.AddListener(() => FindFood(Button7));
        Button8.onClick.AddListener(() => FindFood(Button8));
        Button9.onClick.AddListener(() => FindFood(Button9));
    }

    private void FindFood(Button button)
    {
        /*All_Visited.Clear();
        //bool foundFood = DFS(); //GÜNCELLENDİ
		bool foundFood = BFS(); //GÜNCELLENDİ
		//bool foundFood = DFScycle(); //GÜNCELLENDİ
		//bool foundFood = BFScycle(); //GÜNCELLENDİ
		//bool foundFood = IDS(); //GÜNCELLENDİ
		//bool foundFood = UCS(); //GÜNCELLENDİ
		//bool foundFood = BidirectionalBFS(); //GÜNCELLENDİ
		//bool foundFood = Greedy();
		//bool foundFood = Astar();

        if (foundFood)
        {
            DrawAllVisitedPaths();
            EatPellet();
            Debug.Log("Yem bulundu.");
        }
        else
        {
            Debug.Log("Yem bulunamadı.");
        }*/
        
        All_Visited.Clear();
        bool foundFood = false;

        switch (button.name)
        {
	        case "Button1":
		        
		        foundFood = DFS();
		        break;

	        case "Button2":
		        
		        foundFood = BFS();
		        break;

	        case "Button3":
		        
		        foundFood = DFScycle();
		        //DrawAllVisitedPaths();
		        break;
	        case "Button4":
		        
		        foundFood = BFScycle();
		        break;

	        case "Button5":
		        //çalışmıor
		        foundFood = BidirectionalBFS();
		        break;

	        case "Button6":
		        
		        foundFood = IDS();
		        break;
	        case "Button7":
		       
		        foundFood = UCS();
		        break;

	        case "Button8":
		        
		        foundFood = Greedy();
		        break;

	        case "Button9":
		        
		        foundFood = Astar();
		        break;

	        default:
		        break;
        }
        
        if (foundFood)
        {
	        DrawAllVisitedPaths();
	        EatPellet();
	        Debug.Log("Yem bulundu.");
        }
        else
        {
	        Debug.Log("Yem bulunamadı.");
        }

    }

    private void EatPellet()
    {
        StartCoroutine(EatPelletCoroutine());
    }

    private IEnumerator EatPelletCoroutine()
	{
        Vector3 pNode = start; // Başlangıç pozisyonu
        foreach (Vector3 node in answer)
        {
	        // Hedef düğüm ile mevcut düğüm arasındaki farkları hesapla
	        float deltaX = node.x - pNode.x;
	        float deltaY = node.y - pNode.y;

	        // Yönü belirle ve karakteri o yöne çevir Mathf.Abs(deltaX)
	        if (deltaX != 0)
	        {
		        // Yatay yönde hareket
		        if (deltaX > 0)
			        transform.rotation = Quaternion.Euler(0, 0, 0); // Sağa bak
		        else
			        transform.rotation = Quaternion.Euler(0, 180, 0); // Sola bak
	        }
	        else
	        {
		        // Dikey yönde hareket
		        if (deltaY > 0)
			        transform.rotation = Quaternion.Euler(0, 0, 90); // Yukarı bak
		        else
			        transform.rotation = Quaternion.Euler(0, 0, -90); // Aşağı bak
	        }
	        // Karakteri hareket ettir
	        rigidbody.MovePosition(node);

	        // Önceki düğümü güncelle
	        pNode = node;

	        yield return new WaitForSeconds(0.1f);
        }
	}
	
    private bool Astar()
	{
		int expandedNodes = 0;
		HashSet<Vector3> visited = new HashSet<Vector3>();
		TreeNode root = new TreeNode(start, new Path(), 0);
	
		PriorityQueue<TreeNode, int> fringe = new PriorityQueue<TreeNode, int>();
		
	    root.Path.cost = 0;
		root.Path.hcost = 0;
		fringe.Enqueue(root, 0);

		while (fringe.Count > 0)
		{ 
			TreeNode stateToExpand = fringe.Peek();
			fringe.Dequeue();

			if (!visited.Contains(stateToExpand.Position))
			{
				visited.Add(stateToExpand.Position);
				All_Visited.Add(stateToExpand.Position);

				expandedNodes++;

				if (stateToExpand.Position == goal)
				{
					answer = AnswerPath(stateToExpand);
					Debug.Log("Total Cost: " + stateToExpand.Path.cost);
					Debug.Log("Expanded Nodes: " + expandedNodes);
					Debug.Log("Path: " + stateToExpand.Path.path);
					return true;
				}

				Vector3[] directions = FindDirections(stateToExpand.Position);

				foreach (Vector3 direction in directions)
				{
					if (CheckWalls(direction) && !visited.Contains(direction))
					{
						TreeNode nextState = new TreeNode(direction, new Path(), stateToExpand.Depth + 1);
						nextState.node = stateToExpand;
						nextState.Path.cost= FindCost(stateToExpand.Position, nextState.Position);
					    nextState.Path.cost += stateToExpand.Path.cost;
						nextState.Path.hcost = Mathf.Abs((int)(direction.x - goal.x)) + Mathf.Abs((int)(direction.y - goal.y));
						string way= WhichWay(stateToExpand.Position, nextState.Position);
						nextState.Path.path = stateToExpand.Path.path+ " " + way;
						fringe.Enqueue(nextState, nextState.Path.hcost+nextState.Path.cost);
					}
				}
			}
		}
		return false;
	}
    
    private bool Greedy()
	{
		int expandedNodes = 0;
		HashSet<Vector3> visited = new HashSet<Vector3>();
		TreeNode root = new TreeNode(start, new Path(), 0);
		PriorityQueue<TreeNode, int> fringe = new PriorityQueue<TreeNode, int>();
	    root.Path.cost = 0;
		root.Path.hcost = 0;
		fringe.Enqueue(root, 0);

		while (fringe.Count > 0)
		{ 
			TreeNode stateToExpand = fringe.Peek();
			fringe.Dequeue();

			if (!visited.Contains(stateToExpand.Position))
			{
				visited.Add(stateToExpand.Position);
				All_Visited.Add(stateToExpand.Position);
				expandedNodes++;

				if (stateToExpand.Position == goal)
				{
					answer = AnswerPath(stateToExpand);
					Debug.Log("Total Cost: " + stateToExpand.Path.cost);
					Debug.Log("Expanded Nodes: " + expandedNodes);
					Debug.Log("Path: " + stateToExpand.Path.path);
					return true;
				}

				Vector3[] directions = FindDirections(stateToExpand.Position);

				foreach (Vector3 direction in directions)
				{
					if (CheckWalls(direction) && !visited.Contains(direction))
					{
						TreeNode nextState = new TreeNode(direction, new Path(), stateToExpand.Depth + 1);
						nextState.node = stateToExpand;
						nextState.Path.cost= FindCost(stateToExpand.Position, nextState.Position);
					    nextState.Path.cost += stateToExpand.Path.cost;
						nextState.Path.hcost = Mathf.Abs((int)(direction.x - goal.x)) + Mathf.Abs((int)(direction.y - goal.y)); 
						string way= WhichWay(stateToExpand.Position, nextState.Position);
						nextState.Path.path = stateToExpand.Path.path+ " " + way;
						fringe.Enqueue(nextState, nextState.Path.hcost);
					}
				}
			}
		}
		return false;
	}

    private bool BidirectionalBFS()
    {
		List<Vector3> pathReverse = new List<Vector3>();
        int expandedNodes = 0;

        HashSet<Vector3> forward_visited = new HashSet<Vector3>();
		HashSet<Vector3> back_visited = new HashSet<Vector3>();

		TreeNode forward_root = new TreeNode(start, new Path(), 0);
		TreeNode back_root = new TreeNode(goal, new Path(), 0);

        Queue<TreeNode> forward_fringe = new Queue<TreeNode>();	
		Queue<TreeNode> back_fringe = new Queue<TreeNode>();

        forward_fringe.Enqueue(forward_root);
		back_fringe.Enqueue(back_root);
		
		forward_root.Path.cost = 0;
		back_root.Path.cost = 0;

        while (forward_fringe.Count > 0 && back_fringe.Count > 0)
        {
            TreeNode f_stateToExpand = forward_fringe.Peek();
            forward_fringe.Dequeue();
			TreeNode b_stateToExpand = back_fringe.Peek();
            back_fringe.Dequeue();

            if (!back_visited.Contains(f_stateToExpand.Position) && !forward_visited.Contains(b_stateToExpand.Position))  
            {
                forward_visited.Add(f_stateToExpand.Position);
				back_visited.Add(b_stateToExpand.Position);
				All_Visited.Add(f_stateToExpand.Position);
                All_Visited.Add(b_stateToExpand.Position);
                expandedNodes += 2;

				if (Vector3.Distance(f_stateToExpand.Position, b_stateToExpand.Position) <= 2.0f)
				{
					answer = AnswerPath(f_stateToExpand);
					pathReverse = AnswerPath(b_stateToExpand);
					pathReverse.Reverse();
					answer.AddRange(pathReverse);
					b_stateToExpand.Path.path.Reverse();
					string s= f_stateToExpand.Path.path + b_stateToExpand.Path.path;
					int total_cost = b_stateToExpand.Path.cost + f_stateToExpand.Path.cost;
					Debug.Log("Total Cost: " + total_cost);
                    Debug.Log("Expanded Nodes: " + expandedNodes);
					Debug.Log("Path: " + s);
                    return true;
                }

				Vector3[] forward_directions = FindDirections(f_stateToExpand.Position);

                foreach (Vector3 forward_direction in forward_directions)
                {
                    if (CheckWalls(forward_direction) && !forward_visited.Contains(forward_direction))
                    {
	                    TreeNode f_nextState = new TreeNode(forward_direction, new Path(), f_stateToExpand.Depth + 1);
                        f_nextState.node = f_stateToExpand;
						f_nextState.Path.cost= 1;
                        f_nextState.Path.cost += f_stateToExpand.Path.cost;
						string way= WhichWay(f_stateToExpand.Position, f_nextState.Position);
						f_nextState.Path.path = f_stateToExpand.Path.path+ " " + way;
                        forward_fringe.Enqueue(f_nextState);
                    }
                }
                
				Vector3[] back_directions = FindDirections(b_stateToExpand.Position);

				foreach (Vector3 back_direction in back_directions)
                {
                    if (CheckWalls(back_direction) && !back_visited.Contains(back_direction))
                    {
	                    TreeNode b_nextState = new TreeNode(back_direction, new Path(), b_stateToExpand.Depth + 1);
	                    b_nextState.node = b_stateToExpand;
						b_nextState.Path.cost = 1;
	                    b_nextState.Path.cost += b_stateToExpand.Path.cost;
						string way= WhichWay(b_stateToExpand.Position, b_nextState.Position);
						b_nextState.Path.path = b_stateToExpand.Path.path+ " " + way;
	                    back_fringe.Enqueue(b_nextState);
                    }
                }
            }
        }
        return false;
    }

    private bool UCS()
    {
	    int expandedNodes = 0;
	    HashSet<Vector3> visited = new HashSet<Vector3>();
	    TreeNode root = new TreeNode(start, new Path(), 0);
	    PriorityQueue<TreeNode, int> fringe = new PriorityQueue<TreeNode, int>();
		root.Path.cost = 0;
	    fringe.Enqueue(root, 0);
	    
	    while (fringe.Count > 0)
	    {
		    TreeNode stateToExpand = fringe.Peek();
		    fringe.Dequeue();

		    if (!visited.Contains(stateToExpand.Position))  
		    {
			    visited.Add(stateToExpand.Position);
			    All_Visited.Add(stateToExpand.Position);
			    expandedNodes++;

			    if (stateToExpand.Position == goal)
			    {
				    answer = AnswerPath(stateToExpand);
				    Debug.Log("Total Cost: " + stateToExpand.Path.cost);
				    Debug.Log("Expanded Nodes: " + expandedNodes);
					Debug.Log("Path: " + stateToExpand.Path.path);
				    return true;
			    }

			    Vector3[] directions = FindDirections(stateToExpand.Position);

			    foreach (Vector3 direction in directions)
			    {
				    if (CheckWalls(direction) && !visited.Contains(direction))
				    {
					    TreeNode nextState = new TreeNode(direction, new Path(), stateToExpand.Depth + 1);
					    nextState.node = stateToExpand;
					    nextState.Path.cost = FindCost(stateToExpand.Position, nextState.Position);
					    nextState.Path.cost += stateToExpand.Path.cost;
						string way= WhichWay(stateToExpand.Position, nextState.Position);
						nextState.Path.path = stateToExpand.Path.path+ " "  + way;
					    fringe.Enqueue(nextState,nextState.Path.cost);
				    }
			    }
		    }
	    }
	    return false;
    }

    private bool IDS()
    {
	    int expandedNodes = 0;
	    for (int depthLimit = 0; depthLimit < 70; depthLimit++)
	    {
		    HashSet<Vector3> visited = new HashSet<Vector3>();
		    TreeNode root = new TreeNode(start, new Path(), 0);
		    Stack<TreeNode> fringe = new Stack<TreeNode>();	   
		    root.Path.cost = 0;

			fringe.Push(root);

		    while (fringe.Count > 0)
		    {
			    TreeNode stateToExpand =  fringe.Peek();
			    fringe.Pop();
	
			    if (!visited.Contains(stateToExpand.Position) && stateToExpand.Depth <= depthLimit)
			    {
				    visited.Add(stateToExpand.Position);
				    All_Visited.Add(stateToExpand.Position);
				    expandedNodes++;

				    if (stateToExpand.Position==goal)
				    {
					    answer = AnswerPath(stateToExpand);
						Debug.Log("Total Cost: " + stateToExpand.Path.cost);
					    Debug.Log("Expanded Nodes: " + expandedNodes);
						Debug.Log("Path: " + stateToExpand.Path.path);
					    return true;
				    }

				    Vector3[] directions = FindDirections(stateToExpand.Position);
					foreach (Vector3 direction in directions)
					{
						if (CheckWalls(direction) && !visited.Contains(direction))
						{	
							TreeNode nextState = new TreeNode(direction, new Path(), stateToExpand.Depth + 1);
							nextState.node = stateToExpand;
							nextState.Path.cost = 1;
							nextState.Path.cost += stateToExpand.Path.cost;
							string way= WhichWay(stateToExpand.Position, nextState.Position);
							nextState.Path.path = stateToExpand.Path.path+ " " + way;
						    fringe.Push(nextState);
					    }	
				    }
			    }
		    }
	    }
	    return false;
    }

    private bool BFScycle()
    {
	    int expandedNodes = 0, stop = 25;
	    TreeNode root = new TreeNode(start, new Path(), 0);
	    Queue<TreeNode> fringe = new Queue<TreeNode>();
		root.Path.cost = 0;
	    fringe.Enqueue(root);
	   
	    while (fringe.Count > 0)
	    {
		    TreeNode stateToExpand = fringe.Peek();
		    fringe.Dequeue();
			expandedNodes++;
			All_Visited.Add(stateToExpand.Position);
			
		    if (stateToExpand.Position==goal)
		    { 
			    answer = AnswerPath(stateToExpand); 
				Debug.Log("Total Cost: " + stateToExpand.Path.cost);
			    Debug.Log("Expanded Nodes: " + expandedNodes);
				Debug.Log("Path: " + stateToExpand.Path.path);
			    return true;
		    }

		    if (stateToExpand.Depth >= stop)
		    {
			    continue;
		    }
		    
			Vector3[] directions = FindDirections(stateToExpand.Position);
			foreach (Vector3 direction in directions)
			{
				if (CheckWalls(direction) )
				{
					TreeNode nextState = new TreeNode(direction, new Path(), stateToExpand.Depth + 1);
					nextState.node = stateToExpand; 
					nextState.Path.cost = 1;
					nextState.Path.cost += stateToExpand.Path.cost;
					string way= WhichWay(stateToExpand.Position, nextState.Position);
					nextState.Path.path = stateToExpand.Path.path+ " " + way;
					fringe.Enqueue(nextState);
				}
		    }
	    }
	    return false;
    }

    private bool BFS()
    {
	    int expandedNodes = 0;
	    HashSet<Vector3> visited = new HashSet<Vector3>();
	    TreeNode root = new TreeNode(start, new Path(), 0);
	    Queue<TreeNode> fringe = new Queue<TreeNode>();
		root.Path.cost = 0;
	    fringe.Enqueue(root);
	    
	    while (fringe.Count > 0)
	    {
		    TreeNode stateToExpand = fringe.Peek();
		    fringe.Dequeue();

		    if (!visited.Contains(stateToExpand.Position))  
		    {
			    visited.Add(stateToExpand.Position);
			    All_Visited.Add(stateToExpand.Position);

			    expandedNodes++;

			    if (stateToExpand.Position==goal)
			    {
				    answer = AnswerPath(stateToExpand);
					Debug.Log("Total Cost: " + stateToExpand.Path.cost);
				    Debug.Log("Expanded Nodes: " + expandedNodes);	
					Debug.Log("Path: " + stateToExpand.Path.path);
				    return true;
			    }

			    Vector3[] directions = FindDirections(stateToExpand.Position);
			    foreach (Vector3 direction in directions)
			    {
				    if (CheckWalls(direction) && !visited.Contains(direction))
				    {
					    TreeNode nextState = new TreeNode(direction, new Path(), stateToExpand.Depth + 1);
					    nextState.node = stateToExpand;
						nextState.Path.cost = 1;
					    nextState.Path.cost += stateToExpand.Path.cost;
						string way= WhichWay(stateToExpand.Position, nextState.Position);
						nextState.Path.path = stateToExpand.Path.path+ " "  + way;
					    fringe.Enqueue(nextState);
				    }
			    }
		    }
	    }
	    return false;
    }

    private bool DFScycle()
    {
	    int expandedNodes = 0, stop = 105;
	    TreeNode root = new TreeNode(start, new Path(), 0);
        root.Path.cost = 0;
	    Stack<TreeNode> fringe = new Stack<TreeNode>();
	    fringe.Push(root);
	   
	    while (fringe.Count > 0)
	    {
		    TreeNode stateToExpand = fringe.Peek();
		    fringe.Pop();
		    expandedNodes++;
		    All_Visited.Add(stateToExpand.Position);
		    
		    if (stateToExpand.Position==goal)
		    {
			    answer = AnswerPath(stateToExpand); 
				Debug.Log("Total Cost: " + stateToExpand.Path.cost);
			    Debug.Log("Expanded Nodes: " + expandedNodes);
				Debug.Log("Path: " + stateToExpand.Path.path);
			    return true;
		    }

		    if (stateToExpand.Depth >= stop)
		    {
			    break;
		    }
		    
		    Vector3[] directions = FindDirections(stateToExpand.Position);

		    foreach (Vector3 direction in directions)
		    {
			    if (CheckWalls(direction))
			    { 
				    TreeNode nextState = new TreeNode(direction, new Path(), stateToExpand.Depth + 1); 
				    nextState.node = stateToExpand;
				    nextState.Path.cost = 1;
					nextState.Path.cost += stateToExpand.Path.cost;
					string way= WhichWay(stateToExpand.Position, nextState.Position);
					nextState.Path.path = stateToExpand.Path.path+ " " + way;
				    fringe.Push(nextState);
			    }
		    }
	    }
	    return false;
    }

    private bool DFS()
    {
        int expandedNodes = 0;
        HashSet<Vector3> visited = new HashSet<Vector3>();
        TreeNode root = new TreeNode(start, new Path(), 0);
        root.Path.cost = 0;
		root.Path.path = "";
		Stack<TreeNode> fringe = new Stack<TreeNode>();
        fringe.Push(root);
        
        while (fringe.Count > 0)
        {
            TreeNode stateToExpand = fringe.Peek();
            fringe.Pop();

            if (!visited.Contains(stateToExpand.Position))  
            {
                visited.Add(stateToExpand.Position);
                All_Visited.Add(stateToExpand.Position);
                expandedNodes++;

                if (stateToExpand.Position==goal)
                {
                    answer = AnswerPath(stateToExpand);
					Debug.Log("Total Cost: " + stateToExpand.Path.cost);
                    Debug.Log("Expanded Nodes: " + expandedNodes);
					Debug.Log("Path: " + stateToExpand.Path.path);
                    return true;
                }

                Vector3[] directions = FindDirections(stateToExpand.Position);

                foreach (Vector3 direction in directions)
                {
	                if (CheckWalls(direction) && !visited.Contains(direction))
	                {
		                TreeNode nextState = new TreeNode(direction, new Path(), stateToExpand.Depth + 1);
		                nextState.node = stateToExpand;
		                nextState.Path.cost = 1;
					    nextState.Path.cost += stateToExpand.Path.cost;
						string way= WhichWay(stateToExpand.Position, nextState.Position);
						nextState.Path.path = stateToExpand.Path.path+ " " + way;
		                fringe.Push(nextState);
	                }
                }
            }
        }
        return false;
    }

    private bool CheckWalls(Vector3 posToCheck)
    {
        Collider2D hitCollider = Physics2D.OverlapPoint(posToCheck, obstacleLayer);
        return hitCollider == null;
    }
    
    private List<Vector3> AnswerPath(TreeNode stateToExpand)
    {
        List<Vector3> ans = new List<Vector3>(); 
		TreeNode LeafNode=stateToExpand;

        while (LeafNode != null)
        {
            if (!ans.Contains(LeafNode.Position))
            {
                ans.Insert(0, LeafNode.Position);
            }
            LeafNode = LeafNode.node;
        }
        return ans;
    }

	private void DrawAllVisitedPaths()
	{
    	if (All_Visited.Count == 0 || All_Visited == null )
    	{
        	lineRenderer.positionCount = 0;
    	}
    	else
    	{
        	lineRenderer.positionCount = All_Visited.Count;
        	lineRenderer.SetPositions(All_Visited.ToArray());
    	}
	}

	private string WhichWay(Vector3 stateToExpand, Vector3 nextState)
	{
    	Vector3 diff = nextState - stateToExpand;

    	if (diff.x > 0)
    	{
        	return "east";
    	}
    	else if (diff.x < 0)
    	{
        	return "west";
    	}
    	else if (diff.y > 0)
    	{
        	return "north";
    	}	
    	else if (diff.y < 0)
    	{
        	return "south";
    	}
    	return "none";
	}

	private int FindCost(Vector3 stateToExpand, Vector3 nextState)
	{
    	Vector3 diff = nextState - stateToExpand;

    	if (diff.x > 0) {
        	return 20;
		}
    	else if (diff.x < 0) {
        	return 20;
		}
    	else if (diff.y > 0) {
        	return 20;
		}
    	else if (diff.y < 0) {
        	return 20;
		}
    	return 0;
	}

	private Vector3[] FindDirections(Vector3 axis)
	{
    	Vector3[] Axiss = {
        	new Vector3(axis.x + 1f, axis.y, 	  axis.z),
        	new Vector3(axis.x - 1f, axis.y, 	  axis.z),
        	new Vector3(axis.x, 	 axis.y + 1f, axis.z),
        	new Vector3(axis.x, 	 axis.y - 1f, axis.z)
    	};
    	return Axiss;
	}
}

