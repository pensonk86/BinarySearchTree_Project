using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        public Node RootNode;

        public BinarySearchTree()
        {


        }

        public void CreatNewNode(Node addNode)
        {

            if (RootNode == null)
            {
                RootNode = addNode;
            }
            else
            {
                Node currentNode = RootNode;
                while (true)
                {

                    if (currentNode.NewNode == null)
                    {
                        currentNode.NewNode = addNode;
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.NewNode;

                    }



                }
                

            }
            




        }


    }
}
