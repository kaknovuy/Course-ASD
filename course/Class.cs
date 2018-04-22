using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    public class Class
    {
        /// <summary>
        /// Класс описывающий элемент узла красно-черного дерева
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TData"></typeparam>
        public class RBTreeNode<TKey, TData> where TKey : IComparable
        {
            private bool _IsRed;
            private int _Count;
            private TData _Data;
            private TKey _Key;

            private RBTreeNode<TKey, TData> _Left;
            private RBTreeNode<TKey, TData> _Right;
            private RBTreeNode<TKey, TData> _Parent;

            public RBTreeNode(TKey NewKey, TData NewData)
            {
                _IsRed = false;
                _Count = 1;
                _Data = NewData;
                _Key = NewKey;
                _Left = null;
                _Right = null;
                _Parent = null;
            }

            public bool IsRed { get { return _IsRed; } set { _IsRed = value; } }
            public bool IsBlack { get { return !_IsRed; } set { _IsRed = !value; } }
            public int Count { get { return _Count; } set { _Count = value; } }
            public TKey Key { get { return _Key; } set { _Key = value; } }
            public TData Data { get { return _Data; } set { _Data = value; } }
            public RBTreeNode<TKey, TData> Left { get { return _Left; } set { _Left = value; } }
            public RBTreeNode<TKey, TData> Right { get { return _Right; } set { _Right = value; } }
            public RBTreeNode<TKey, TData> Parent { get { return _Parent; } set { _Parent = value; } }

            //Метод получения корня дерева
            public RBTreeNode<TKey, TData> Root
            {
                get
                {
                    RBTreeNode<TKey, TData> Node;

                    Node = this;
                    while (Node._Parent != null) Node = Node._Parent;
                    return Node;
                }
            }

        }


        /// <summary>
        /// Класс описывающий красно-черное дерево
        /// </summary>
        /// <typeparam name="TNode"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TData"></typeparam>
        public class RBTree<TNode, TKey, TData>
            where TNode : RBTreeNode<TKey, TData>
            where TKey : IComparable
        {
            private TNode _Root;

            public RBTree()
            {
                _Root = null;
            }

            //Поворот влево
            protected void RotateLeft(TNode Node)
            {
                RBTreeNode<TKey, TData> P, N;

                if ((Node == null) || (Node.Right == null)) return;

                P = Node.Parent;
                N = Node.Right;

                if (P != null)
                    if (P.Left == Node) P.Left = N; else P.Right = N;
                Node.Right = N.Left;
                if (Node.Right != null) Node.Right.Parent = Node;
                N.Parent = P;
                Node.Parent = N;
                N.Left = Node;

                //корректировка count 
                Node.Count = 1;
                if (Node.Left != null) Node.Count += Node.Left.Count;
                if (Node.Right != null) Node.Count += Node.Right.Count;
                N.Count = 1;
                if (N.Left != null) N.Count += N.Left.Count;
                if (N.Right != null) N.Count += N.Right.Count;
            }

            //Поворот вправо
            protected void RotateRight(TNode Node)
            {
                RBTreeNode<TKey, TData> P, N;

                if ((Node == null) || (Node.Left == null)) return;

                P = Node.Parent;
                N = Node.Left;

                if (P != null)
                    if (P.Right == Node) P.Right = N; else P.Left = N;
                Node.Left = N.Right;
                if (Node.Left != null) Node.Left.Parent = Node;
                N.Parent = P;
                Node.Parent = N;
                N.Right = Node;

                //корректировка count
                Node.Count = 1;
                if (Node.Left != null) Node.Count += Node.Left.Count;
                if (Node.Right != null) Node.Count += Node.Right.Count;
                N.Count = 1;
                if (N.Left != null) N.Count += N.Left.Count;
                if (N.Right != null) N.Count += N.Right.Count;
            }

            public TNode Root
            {
                get { return _Root; }
                set { if (value == null) _Root = null; }
            }

            public int Count
            {
                get
                {
                    if (_Root == null) return 0;
                    else return _Root.Count;
                }
            }

            //Вспомогательный метод для поиска узла
            public TNode Find(TKey Key, out int Result)
            {
                int i;
                RBTreeNode<TKey, TData> N;

                if (_Root == null)
                {
                    Result = 1;
                    return null;
                }
                N = _Root;

                while (true)
                {
                    i = Key.CompareTo(N.Key);

                    if (i > 0)
                    {
                        if (N.Right == null)
                        {
                            Result = 1;
                            return (TNode)N;
                        }
                        N = N.Right;
                    }
                    else if (i < 0)
                    {
                        if (N.Left == null)
                        {
                            Result = -1;
                            return (TNode)N;
                        }
                        N = N.Left;
                    }
                    else
                    {
                        Result = 0;
                        return (TNode)N;
                    }
                }
            }

            //Поиск узла в дереве
            public TNode Find(TKey Key)
            {
                int i;
                RBTreeNode<TKey, TData> N;

                N = Find(Key, out i);
                if (i != 0) N = null;
                return (TNode)N;
            }

            //Вставка узла в дерево
            public void InsertNode(TNode Node)
            {
                int i;
                /*
                 * M - удаляемы узел
                 * Р - новый предок
                 * С - потомок М
                */
                RBTreeNode<TKey, TData> M, P, C;

                if ((Node == null) || (Node.Left != null) || (Node.Right != null) || (Node.Parent != null)) return;

                if (_Root == null)
                {
                    _Root = Node;
                    return;
                }

                M = Find(Node.Key, out i);

                if (i == 0) // заменяем узел
                {
                    Node.Left = M.Left;
                    if (Node.Left != null) Node.Left.Parent = Node;
                    Node.Right = M.Right;
                    if (Node.Right != null) Node.Right.Parent = Node;
                    Node.Parent = M.Parent;
                    Node.IsRed = M.IsRed;
                    Node.Count = M.Count;
                    if (M.Parent != null)
                        if (M.Parent.Left == M) M.Parent.Left = Node; else M.Parent.Right = Node;
                    if (_Root == M) _Root = Node;
                    M.Left = null;
                    M.Right = null;
                    M.Parent = null;
                    return;
                }

                //Перерасчитываем кол-во узлов Count
                C = M;
                do
                {
                    C.Count++;
                    C = C.Parent;
                } while (C != null);

                C = M;
                Node.Parent = M;
                Node.IsRed = true;
                if (i > 0) M.Right = Node; else M.Left = Node;

                //перекраска RBTree после вставки
                while ((Node.Parent != null) && (Node.Parent.IsRed))
                {
                    P = Node.Parent.Parent;

                    if (Node.Parent == P.Left)
                    {
                        M = P.Right;
                        if ((M != null) && (M.IsRed))
                        {
                            Node.Parent.IsBlack = true;
                            M.IsBlack = true;
                            P.IsRed = true;
                            Node = (TNode)P;
                        }
                        else
                        {
                            if (Node == Node.Parent.Right)
                            {
                                Node = (TNode)Node.Parent;
                                RotateLeft(Node);
                            }
                            Node.Parent.IsBlack = true;
                            P.IsRed = true;
                            RotateRight((TNode)P);
                        }
                    }
                    else
                    {
                        M = P.Left;
                        if ((M != null) && (M.IsRed))
                        {
                            Node.Parent.IsBlack = true;
                            M.IsBlack = true;
                            P.IsRed = true;
                            Node = (TNode)P;
                        }
                        else
                        {
                            if (Node == Node.Parent.Left)
                            {
                                Node = (TNode)Node.Parent;
                                RotateRight(Node);
                            }
                            Node.Parent.IsBlack = true;
                            P.IsRed = true;
                            RotateLeft((TNode)P);
                        }
                    }
                }

                C = C.Root;
                C.IsBlack = true;
                _Root = (TNode)C;
            }

            //Удаление узла из дерева                                     
            public void DeleteNode(TNode Node)
            {
                int i;
                RBTreeNode<TKey, TData> M, P, C, T;
                /*
                             * M - удаляемы узел           
                             * Т - новый предок
                             * Р - дополнительная ссылка на предок
                             * С - потомок М
                */
                if (Node.Root != _Root) return;

                M = Node;

                if (M.Left == null) C = M.Right;
                else if (M.Right == null) C = M.Left;
                else
                {
                    M = M.Right;
                    while (M.Left != null) M = M.Left;
                    C = M.Right;
                }

                if (M != Node)
                {
                    //Корректировка Count
                    M.Count = Node.Count - 1;
                    T = M.Parent;
                    while (T != null)
                    {
                        T.Count--;
                        T = T.Parent;
                    }

                    Node.Left.Parent = M;
                    M.Left = Node.Left;
                    if (M != Node.Right)
                    {
                        P = M.Parent;
                        if (C != null) C.Parent = P;
                        P.Left = C;
                        M.Right = Node.Right;
                        Node.Right.Parent = M;
                    }
                    else P = M;

                    if (Node.Parent != null)
                        if (Node.Parent.Left == Node) Node.Parent.Left = M; else Node.Parent.Right = M;
                    M.Parent = Node.Parent;
                    i = (M.IsRed ? 1 : 0);
                    M.IsRed = Node.IsRed;
                    Node.IsRed = (i != 0);
                }
                else
                {
                    //Корректировка Count
                    T = Node.Parent;
                    while (T != null)
                    {
                        T.Count--;
                        T = T.Parent;
                    }

                    P = M.Parent;
                    if (C != null) C.Parent = P;
                    if (Node.Parent != null)
                        if (Node.Parent.Left == Node) Node.Parent.Left = C; else Node.Parent.Right = C;
                    i = (M.IsRed ? 1 : 0);
                }

                if ((M == Node) && (M.Left == null) && (M.Right == null) && (M.Parent == null))
                {
                    _Root = null;
                    return;
                }

                Node.Left = null;
                Node.Right = null;
                Node.Parent = null;
                if (P == null) Node = (TNode)C; else Node = (TNode)P;

                //перекраска RBTree после удаления
                if (i == 0) //черный
                {
                    while ((P != null) && ((C == null) || (C.IsBlack)))
                    {
                        if (C == P.Left)
                        {
                            M = P.Right;
                            if (M.IsRed)
                            {
                                M.IsBlack = true;
                                P.IsRed = true;
                                RotateLeft((TNode)P);
                                M = P.Right;
                            }
                            if (((M.Left == null) || (M.Left.IsBlack)) && ((M.Right == null) || (M.Right.IsBlack)))
                            {
                                M.IsRed = true;
                                C = P;
                                P = P.Parent;
                            }
                            else
                            {
                                if ((M.Right == null) || (M.Right.IsBlack))
                                {
                                    M.Left.IsBlack = true;
                                    M.IsRed = true;
                                    RotateRight((TNode)M);
                                    M = P.Right;
                                }
                                M.IsRed = P.IsRed;
                                P.IsBlack = true;
                                if (M.Right != null) M.Right.IsBlack = true;
                                RotateLeft((TNode)P);
                                break;
                            }
                        }
                        else //если C=P.Right
                        {
                            M = P.Left;
                            if (M.IsRed)
                            {
                                M.IsBlack = true;
                                P.IsRed = true;
                                RotateLeft((TNode)P);
                                M = P.Left;
                            }
                            if (((M.Right == null) || (M.Right.IsBlack)) && ((M.Left == null) || (M.Left.IsBlack)))
                            {
                                M.IsRed = true;
                                C = P;
                                P = P.Parent;
                            }
                            else
                            {
                                if ((M.Left == null) || (M.Left.IsBlack))
                                {
                                    M.Right.IsBlack = true;
                                    M.IsRed = true;
                                    RotateLeft((TNode)M);
                                    M = P.Left;
                                }
                                M.IsRed = P.IsRed;
                                P.IsBlack = true;
                                if (M.Left != null) M.Left.IsBlack = true;
                                RotateRight((TNode)P);
                                break;
                            }
                        }
                    }

                    if (C != null) C.IsBlack = true;//черный
                }

                _Root = (TNode)Node.Root;
            }

        }

    }
}




