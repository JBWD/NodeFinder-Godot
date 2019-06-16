using Godot;
using Godot.Collections;
using System;

public class NodeFinder 
{

    ///<Summary>
    ///Retrieves a child that is a direct leaf of the search node with the designated type.
    ///</Summary>
    public static T GetDirectNodeInChildren<T>(Node nodeToSearch)where T:Node
    {
        Array<Node> children = new Array<Node>(nodeToSearch.GetChildren());
        Node foundNode = null;

        foreach(Node n in children)
        {
            if(n.GetType() == typeof(T))
            {
                foundNode = n;
            }
            if(foundNode != null)
            {
                break;
            }
        }

        if(foundNode != null)
        {
            return (T) Convert.ChangeType(foundNode,typeof(T));
        }
        else{
            return null;
        }
    }


    ///<Summary>
    ///Retrieves a child that is a direct leaf of the search node with the child name and type.
    ///</Summary>
     public static T GetDirectNodeInChildren<T>(Node nodeToSearch,string childName)where T:Node
    {
        Array<Node> children = new Array<Node>(nodeToSearch.GetChildren());
        Node foundNode = null;

        foreach(Node n in children)
        {
            if(n.GetType() == typeof(T))
            {
                foundNode = n;
            }
            if(foundNode != null)
            {
                break;
            }
        }

        if(foundNode != null)
        {
            return (T) Convert.ChangeType(foundNode,typeof(T));
        }
        else{
            return null;
        }
    }


    ///<Summary>
    ///Retrieves a child node of the sent type within ALL child nodes.
    ///</Summary>
    public static T GetNodeInChildren<T>(Node nodeToSearch) where T:Node
    {
         Array<Node> children = new Array<Node>(nodeToSearch.GetChildren());
        int incorrectTypeFound = 0;
        Node foundNode = null;

        foreach(Node n in children)
        {
            if(n.GetType() == typeof(T))
            {
                
                foundNode = n;
            }
            else
            {
                incorrectTypeFound ++;
            }
            
            if(foundNode != null)
                break;
            else
            {
                foundNode = GetNodeInChildren<T>(n);
            }
        }

        if(foundNode != null)
        {
            return (T) Convert.ChangeType(foundNode,typeof(T));
        }
        return null;
    }

    ///<Summary>
    ///Returns a child node of a specific type and name within ALL child nodes.
    ///</Summary>
    public static T GetNodeInChildren<T>(Node nodeToSearch, string ChildName) where T: Node
    {

        Array<Node> children = new Array<Node>(nodeToSearch.GetChildren());
        int incorrectTypeFound = 0;
        Node foundNode = null;

        foreach(Node n in children)
        {

            if(n.Name == ChildName )
            {
                if(n.GetType() == typeof(T))
                {
                    GD.Print("Found : Returning " + n.Name);
                    
                    foundNode = n;
                }
                else
                {
                    incorrectTypeFound ++;
                }
            }
            
            
            if(foundNode != null)
                break;
            else{
                foundNode = GetNodeInChildren<T>(n,ChildName);
            }
        }

        if(foundNode != null)
        {
            return (T) Convert.ChangeType(foundNode,typeof(T));
        }
        return null;
    }

    ///<Summary>
    ///Retrieves all nodes of the sent type within the sent node to search.null
    ///</Summary>
    public static Array<T> GetNodesInChildren<T>(Node nodeToSearch) where T : Node
    {
        
        Array<Node> children = new Array<Node>(nodeToSearch.GetChildren());

        Array<T> foundChildren = new Array<T>();
        
        foreach(Node n in children)
        {
            if(n.GetType() == typeof(T))
            {
                foundChildren.Add((T)Convert.ChangeType(n,typeof(T)));
            }
        }
        return foundChildren;
    }


    
}
