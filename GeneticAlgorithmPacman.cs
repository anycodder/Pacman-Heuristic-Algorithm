/*using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

public class GeneticAlgorithmPacman : MonoBehaviour
{
    public Transform pacmanTransform;
    private HashSet<Vector3> All_Visited;
    private new Rigidbody2D rigidbody;
    private List<Vector3> answer;
    private Vector3 starts;
    public Vector3 targetPosition = new Vector3(-12.5f, 5.5f, -5f);
    private LineRenderer lineRenderer;
    public LayerMask obstacleLayer;
    

    public class TreeNode
    {
        public int Score { get; set; }
        public int Depths { get; set; }
        public Vector3 Positions { get; set; }
        public TreeNode nodes { get; set; }

        public TreeNode(Vector3 positions, int score, int depths)
        {
            Positions = positions;
            Score = score;
            Depths = depths;
        }
    }

    public List<TreeNode> answers;

    private void Start()
    {
        starts = transform.position;
        answer = new List<Vector3>();
        All_Visited = new HashSet<Vector3>();
        rigidbody = GetComponent<Rigidbody2D>();
        lineRenderer = GetComponent<LineRenderer>();
        answers = new List<TreeNode>(); // answers listesini başlat

        if (pacmanTransform == null || lineRenderer == null)
        {
            Debug.LogError("Pacman'ın Transform veya LineRenderer bileşeni atanmamış.");
            return;
        }

        int maxScore = CalculateMaxScoreDFS(pacmanTransform.position, 0);
        if (answers != null && answers.Count > 0)
        {
            // Cevapları sırala (en yüksek puandan en düşük puana)
            answers.Sort((a, b) => b.Score.CompareTo(a.Score));
            Debug.Log(answers.Count);
            // En yüksek puana sahip cevabı seç
            TreeNode selectedAnswer = answers[0];

            // Debug.Log ile selectedAnswer'ın değerlerini göster

            StartCoroutine(EatPelletCoroutine(selectedAnswer));
        }

        DrawAllVisitedPaths();
        
        
        Debug.Log("Pacman'ın maksimum skoru: " + maxScore);
    }

    private int CalculateMaxScoreDFS(Vector3 currentPosition, int currentScore)
    {
        TreeNode root = new TreeNode(currentPosition, currentScore, 0);
        return RecursiveDFS(root);
    }

    
    private int RecursiveDFS(TreeNode stateToExpand)
    {
        if (!All_Visited.Contains(stateToExpand.Positions))
        {
            All_Visited.Add(stateToExpand.Positions);

            int maxScore = int.MinValue;
            Vector3[] directions = FindDirections(stateToExpand.Positions);

            foreach (Vector3 direction in directions)
            {
                if (CheckWalls(direction) && !All_Visited.Contains(direction))
                {
                    TreeNode nextState = new TreeNode(direction, stateToExpand.Score - 1, stateToExpand.Depths + 1);
                    nextState.nodes = stateToExpand;

                    if (nextState.Positions == targetPosition)
                    {
                        nextState.Score += 200;
                        answers.Add(nextState);
                        return nextState.Score;
                    }

                    int score = RecursiveDFS(nextState);
                    maxScore = Mathf.Max(maxScore, score);
                }
            }
            stateToExpand.Score = maxScore;
        }

        return stateToExpand.Score;
    }
    


    private IEnumerator EatPelletCoroutine(TreeNode pathNode)
    {
        List<Vector3> path = AnswerPath(pathNode);
        Vector3 stateToExpand = starts;

        foreach (Vector3 nextState in path)
        {
            float axisX = nextState.x - stateToExpand.x;
            float axisY = nextState.y - stateToExpand.y;

            if (axisX > 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else if (axisX < 0)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            else if (axisY > 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 90);
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 0, -90);
            }

            rigidbody.MovePosition(nextState);

            // Pause the coroutine for 1 second
            yield return new WaitForSeconds(0.1f);
        }
    }
    

    private bool CheckWalls(Vector3 posToCheck)
    {
        Collider2D hitCollider = Physics2D.OverlapPoint(new Vector2(posToCheck.x, posToCheck.y), obstacleLayer);
        return hitCollider == null;
    }

    private List<Vector3> AnswerPath(TreeNode stateToExpand)
    {
        List<Vector3> ans = new List<Vector3>();
        TreeNode leafNode = stateToExpand;

        while (leafNode != null)
        {
            ans.Insert(0, leafNode.Positions);
            leafNode = leafNode.nodes;
        }

        return ans;
    }

    private Vector3[] FindDirections(Vector3 axis)
    {
        Vector3[] Axiss = {
            new Vector3(axis.x + 1f, axis.y, axis.z),
            new Vector3(axis.x - 1f, axis.y, axis.z),
            new Vector3(axis.x, axis.y + 1f, axis.z),
            new Vector3(axis.x, axis.y - 1f, axis.z)
        };
        return Axiss;
    }

    private void DrawAllVisitedPaths()
    {
        if (All_Visited.Count == 0 || All_Visited == null)
        {
            lineRenderer.positionCount = 0;
        }
        else
        {
            lineRenderer.positionCount = All_Visited.Count;
            lineRenderer.SetPositions(All_Visited.ToArray());
        }
    }
}
*/

