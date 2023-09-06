using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ListAndDictionaries;
using ExDelegate;
using Xunit;
using System.Collections;
using GraphAlg;
using Streams;

namespace WhutYielsReturn
{
    // Реализация методов Linq
    //public static class IEnumerableExtensions
    //{
    //    public static IEnumerable<T> Where<T>(this IEnumerable<T> enumerable, Func<T,bool> predict)
    //    {
    //        foreach (var item in enumerable)
    //        {
    //            if(predict(item)) yield return item;
    //        }
    //    }

    //    public static IEnumerable<Tout> Select<Tint, Tout>(this IEnumerable<Tint> enumerable, Func<Tint, Tout> selector)
    //    {
    //        foreach(var item in enumerable) yield return selector(item);
    //    }
    //    public static List<T> ToList<T>(this IEnumerable<T> enumerable)
    //    {
    //        var list = new List<T>();
    //        foreach (var item in enumerable) list.Add(item);
    //        return list;
    //    }
    //}

    //enum State
    //{
    //    Empty,
    //    Wall,
    //    Visited
    //}

    public class Program
    {
    //    static Random rnd = new Random();

        
      // static void Main(string[] args)
      //  {
            #region
            //        //Queue<int> queue = new Queue<int>();
            //        //queue.Enqueue(1);
            //        //queue.Enqueue(2);
            //        //queue.Enqueue(3);



            //        //foreach (int value in queue)
            //        //{
            //        //    Console.WriteLine(value);

            //        //}

            //        //foreach (var e in Sequences.Fibonacci)
            //        //{
            //        //    Console.WriteLine(e);
            //        //    Thread.Sleep(100);
            //        //    if (Console.KeyAvailable) break;
            //        //}

            //        //List<int> ints = new List<int>();
            //        //ints.Add(1);
            //        //ints.Add(2);
            //        //ints.Add(3);

            //        //Console.WriteLine(ints[1]);

            //        //MyList<int> list = new MyList<int>();
            //        //list.Add(1);
            //        //list.Add(2);
            //        //list.Add(3);

            //        //for (int i = 0; i < list.Count; i++)
            //        //{
            //        //    Console.WriteLine(list[i]);
            //        //}

            //        //Point point1 = new Point() { X = 1, Y = 2 };
            //        //Point point2 = new Point() {  X = 1, Y = 2 };
            //        //Console.WriteLine(point1.Equals(point1));
            //        //Console.WriteLine(point1 == point2);
            //        //Console.WriteLine(point1.ToString());
            //        //Console.WriteLine($"Это {point1.ToString()}");  

            //        //FindASubstringInString.IndexOf("abcd", "abc");

            //        //Point point1 = new Point() { X = 1 , Y = 1 };
            //        //Point point2 = new Point() { X = 1 , Y = 1 };    
            //        //Dictionary<Point, string> dict = new Dictionary<Point, string>();

            //        //dict[point1] = "Text";
            //        //Console.WriteLine(dict[point1]);
            //        //Console.WriteLine(dict[point2]);

            //        //string[] strings = { "A", "B", "CCC", "AAA", };
            //        //StringCompare stringCompare = new StringCompare(DelegatesWithSortArray.CompareStringLength);
            //        //DelegatesWithSortArray.SortStrings(strings, DelegatesWithSortArray.CompareStringLength);
            //        //DelegatesWithSortArray.SortStrings(strings, delegate(string x , string y)
            //        //{
            //        //    return x.Length.CompareTo(y.Length);
            //        //});
            //        //DelegatesWithSortArray.SortStrings(strings, (x,y) => x.Length.CompareTo(y.Length));



            //        //AlphabeticComparer comparer = new AlphabeticComparer() {Descending = true };
            //        //DelegatesWithSortArray.SortStrings<string>(strings, comparer.Compare);


            //        //Func<int, int> f = x => x + 1;

            //        //Console.WriteLine(f(1));

            //        //Func<int> generator = () => rnd.Next();

            //        //Console.WriteLine(generator());

            //        //Func<double, double, double> h = (a, b) =>
            //        //{
            //        //    b = a % b;
            //        //    return b;
            //        //};

            //        //Action<int> print = x => Console.WriteLine(x);

            //        //print(generator());

            //        //Action printRandom = () => Console.WriteLine(generator());

            //        //Func<double, double> f = x => x * x;
            //        //var g = Derivative(f); 
            //        //List<Action<Robot>> list = new List<Action<Robot>>();

            //        //list.Add(robot =>
            //        //{
            //        //    robot.Move(1);
            //        //    Assert.Equal(1, robot.X);
            //        //    Assert.Equal(1, robot.Y);
            //        //    Assert.Equal(0, robot.Angel);
            //        //});
            //        //list.Add(robot =>
            //        //{
            //        //    robot.Rotate(Math.PI / 2);
            //        //    robot.Move(1);
            //        //    Assert.Equal(0, robot.X);
            //        //    Assert.Equal(1, robot.Y);
            //        //    Assert.Equal(Math.PI / 2, robot.Angel);
            //        //});

            //        //foreach(var test in list) 
            //        //{
            //        //    Robot.PerformTest(test);
            //        //}


            //        List<Student> students = new List<Student>
            //        {
            //            new Student{ LastName = "Jones", GroupName = "ITI = 22"},
            //            new Student{ LastName = "Jopes", GroupName = "ITI = 22"},
            //            new Student{ LastName = "Jone", GroupName = "ITP = 12"},
            //            new Student{ LastName = "Jonesi", GroupName = "ITP = 22"},
            //        };

            //        List<string> names = new List<string>();

            //        //LINQ
            //        names = students.Where(z =>z.GroupName == "ITI = 22").Select(z => z.LastName).ToList();


            //var map = new State[labyrinth[0].Length, labyrinth.Length];

            //for (int x = 0; x < map.GetLength(0); x++)
            //    for (int y = 0; y < map.GetLength(1); y++)
            //        map[x, y] = labyrinth[y][x] == ' ' ? State.Empty : State.Wall;
            // через рекурсию лабиринт
            //Visit(map, 0, 0);

            // через стек
            //var stack = new Stack<Point>();
            //stack.Push(new Point(0, 0));
            //while (stack.Count != 0)
            //{
            //    var point = stack.Pop();
            //    if (x < 0 || x >= map.GetLength(0) || y < 0 || y >= map.GetLength(1)) return;
            //    if (map[x, y] != State.Empty) return;
            //    map[x, y] = State.Visited;
            //    Print(map);

            //    for (int dx = -1; dx <= 1; dx++)
            //    {
            //        for (int dy = -1; dy <= 1; dy++)
            //        {
            //            if (Math.Abs(dx) + Math.Abs(dy) != 1) continue;
            //            else stack.Push(new Point(point.X + dx, point.Y + dy));
            //        }
            //    }
            //}
            // очередь также только вместо Stack надо Queue (это обход в ширину) а стек и рекурс это обход в глубину 
            //Print(map);

            //Графы
            //var graph = new Graph(2);
            //var v1 = new Node(0);
            //var v2 = new Node(1);
            //graph[0].Connect(graph[1], graph);
            //graph.Nodes.Add(v1);
            //graph.Nodes.Add(v2);
            //graph.Connect(0, 1);

            //Dictionary<Node, bool> flags = new Dictionary<Node, bool>();

            //flags[graph[0]] = true;
            //flags[graph[1]] = false;

            //Dictionary<Edge, double> weight = new Dictionary<Edge, double>();

            //weight[graph[0].IncidentEdges.First()] = 10;


            //Обход граффа

            //var graph = Graph.MakeGraph(
            //    0, 1,
            //    0, 2,
            //    1, 3,
            //    1, 4,
            //    2, 3,
            //    2, 4
            //    );

            //foreach ( var item in DepthSearch(graph[0])) 
            //{
            //    Console.WriteLine(item.Number);
            //}
            #endregion

            //var graph = Graph.MakeGraph(
            //    0, 1,
            //    0, 2,
            //    0, 3,
            //    1, 3,
            //    2, 3
            //    );

            //var weights = new Dictionary<Edge, double>();
            //weights[graph[0, 1]] = 1;
            //weights[graph[0, 2]] = 2;
            //weights[graph[0, 3]] = 6;
            //weights[graph[1, 3]] = 4;
            //weights[graph[2, 3]] = 2;

            // пример потока 

            //var thread = new Thread(new ThreadStart(() => Stream.MakeWork(1)));
            //thread.Start();
            //thread = new Thread(new ThreadStart(() => Stream.MakeWork(2)));
            //thread.Start();
            //Thread.Sleep(Timeout.Infinite); 

            //асинхроный вызов через BeginInvoke
            //var func = new Func<int, double>(Stream.MakeWork);
            //var result = func.BeginInvoke(1, null, null);
            //while (!result.IsCompleted)
            //{
            //    Console.Write(".");
            //}
            //var returnedValue = func.EndInvoke(result);

            //Асинхроный вызов через Parallel

           // Parallel.For(0, 10, Stream.MakeWork);


      //  }

        //static string[] labyrinth = new string[]
        //{
        //" X  X     ",
        //" X XXXXX X",
        //"      X   ",
        //"XXXX XXX X",
        //"         X",
        //" XXX XXXXX",
        //" X        ",
        //};

        //static void Print(State[,] map)
        //{

        //    Console.CursorLeft = 0;
        //    Console.CursorTop = 0;
        //    for (int x = 0; x < map.GetLength(0) + 2; x++)
        //        Console.Write("X");
        //    Console.WriteLine();
        //    for (int y = 0; y < map.GetLength(1); y++)
        //    {
        //        Console.Write("X");
        //        for (int x = 0; x < map.GetLength(0); x++)
        //            switch (map[x, y])
        //            {
        //                case State.Wall: Console.Write("X"); break;
        //                case State.Empty: Console.Write(" "); break;
        //                case State.Visited: Console.Write("."); break;
        //            }
        //        Console.WriteLine("X");
        //    }
        //    for (int x = 0; x < map.GetLength(0) + 2; x++)
        //        Console.Write("X");
        //    Console.ReadKey();
        //}

        // Рекурсия графы
        //static void Visit(State[,] map, int x, int y)
        //{
        //    if (x < 0 || x >= map.GetLength(0) || y < 0 || y >= map.GetLength(1)) return;
        //    if (map[x, y] != State.Empty) return;
        //    map[x, y] = State.Visited;
        //    Print(map);

        //    for (int dx = -1; dx <= 1; dx++)
        //    {
        //        for (int dy = -1; dy <= 1; dy++)
        //        {
        //            if (Math.Abs(dx) + Math.Abs(dy) != 1) continue;
        //            else Visit(map, x + dx, y + dy);
        //        }
        //    }
        //}


        // не часть рекурсии 
        //static Func<double, double> Derivative (Func<double, double> f)
        //{
        //    var eps = 0.00001;
        //    return x => (f(x + eps) - f(x)) / eps;
        //}

        //в ширину
        //static List<Node> BreadthSearch(Node startNode)
        //{
        //    var result = new List<Node>();
        //    var queue = new Queue<Node>();
        //    queue.Enqueue(startNode);
        //    var visited = new HashSet<Node>();
        //    while ( queue.Count != 0 )
        //    {
        //        var node = queue.Dequeue();
        //        if ( visited.Contains(node) ) { continue; }
        //        visited.Add(node);
        //        result.Add(node);
        //        foreach(var nextNode in node.IncidentNodes) 
        //        {
        //            queue.Enqueue(nextNode);
        //        }
        //    }
        //    return result;

        //}

        ////в глубину
        //static List<Node> DepthSearch(Node startNode)
        //{
        //    var result = new List<Node>();
        //    var stack = new Stack<Node>();
        //    stack.Push(startNode);
        //    var visited = new HashSet<Node>();
        //    while (stack.Count != 0)
        //    {
        //        var node = stack.Pop();
        //        if (visited.Contains(node)) { continue; }
        //        visited.Add(node);
        //        result.Add(node);
        //        foreach (var nextNode in node.IncidentNodes)
        //        {
        //            stack.Push(nextNode);
        //        }
        //    }
        //    return result;

        //}



    }
}
