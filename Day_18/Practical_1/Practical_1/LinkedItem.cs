using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Practical_1
{
    public class LinkedItem<T> : ILinkedItem<T>
    {

        public T this[int n]
        {
            get
            {
                Node<T> node = Root;
                for (int i = 0; i < n; i++)
                {
                    node = node.next;
                    if (node == null)
                        throw new NotAvailableElementException("Not available requested element");
                }
                return node.data;
            }
            set
            {
                AddItem(value);
            }

        }


        public class Node<T>
        {
            // შემდეგი წვეროს მისამართი
            public Node<T> next = null;
            // მონაცემი
            public T data;
        }

        private Node<T> root = null;

        public Node<T> Root
        {
            get
            {
                return root;
            }
        }

        public bool Exists()
        {
            return root != null;
        }

        public void AddItem(T value)
        {
            Node<T> n = new Node<T> { data = value };
            if (root == null)
            {
                root = n;
            }
            else
            {
                Node<T> curr = root;
                while (curr.next != null)
                {
                    curr = curr.next;
                }
                curr.next = n;
            }
        }

        public void RemoveItem(T data)
        {
            if (root != null && Object.Equals(root.data, data))
            {
                var node = root;
                root = node.next;
                node.next = null;
            }
            else
            {
                Node<T> curr = root;
                while (curr.next != null)
                {
                    if (Object.Equals(curr.next.data, data))
                    {
                        var node = curr.next;
                        curr.next = node.next;
                        node.next = null;
                        break;
                    }

                    curr = curr.next;
                }
            }
        }

        public void PrintItems()
        {
            Node<T> curr = root;
            while (curr != null)
            {
                Console.WriteLine($"data : {curr.data.ToString()}");
                curr = curr.next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> curr = root;
            while (curr != null)
            {
                yield return curr.data;
                curr = curr.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}