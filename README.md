MinMaxRouteFinder
=================

MinMaxRouteFinder

The MiniMax algorithm is especially known and applicable for calculating the best move (optimal move) in two player games where all the information is available. 
Here, we will try to show how MiniMax can be used to solve a route finding problem, by making one (the customer / passenger / fare)  route selector to select the minimum distance route and the other one (the driver of the taxi) to select the maximum distance route from the goal or 
destination place, alternatively (max, min). 
The data input to the system is file-based. The following data is stored in a file called “ourRoutes.txt”.

The First thing a user should do when using this Route Finding Program using Min-Max algorithm is to prepare the map, the format of the map should be similar to the above format. 
1. _*_ separator, separates the child nodes (path) from their parent nodes 
2. Each number (i.e. 1 or 0) that appears after ~ separator, tells us at which player’s turn it is now to select a path.  (1 for maximizer and 0 for minimizer)
3. If a node name is separated by _*_ from a number then the number indicates the distance or the cost of the path through the mentioned nodes. 
E.g. Stadium_*_9: this means Stadium is the last path to destination and its distance is 9 KM to Saris through Stadium path. 

When the user runs the program, the route finding program “form” will be displayed. First, select the path of the file that contains the state space and enter the destination place in the text box.
The steps are:
	Click on “…” to select the file location, then
	Enter the destination place, in the text box provided.
	Click on “Go” button or press Enter/ Return key to run the program. 
The system automatically performs the following task:
	It checks the existence of the file containing the state space in the folder specified and if the file is available/exists, read the content of the file and store in “content” and then tokenize the path with path name.

After tokenize the content will be stored in data structure as node, successor, MiniMax level and distance respectively. The file content will be stored as list of structure.
