# NodeFinder-Godot
Static class built in c# to help find nodes that are linked to the current Object.

If coming from a Unity Background the use of GetComponent<>() is very familiar. 
Godot does not have this option and does not allow the dragging of node references within the inspector.

This script eliminates the need of knowing the paths and allows for simple searching of children or direct nodes within the parent.

Example: Finding a child of type "RigidBody"
```
//We use 'this' because we are searching the current node's children
RigidBody _rb = NodeFinder.GetNodeInChildren<RigidBody>(this); 
```


Example: Finding a child of type "RigidBody" in the nodes Parents
```
//We use 'this' because we getting the parent of the current node
RigidBody _rb = NodeFinder.GetNodeInChildren<RigidBody>(this.GetParent()); 
```


Example: Names can also be used to directly find a specific node
```
RigidBody _rb = NodeFinder.GetNodeInChildren<RigidBody>(this, "ArmBody");
```

Names can also be specified within the inspector by using Export
```
[Export]
string name
```
