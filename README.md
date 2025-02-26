# Artificial-Intelligence - Probabilistic enumeration in Bayesian networks

The project aims to implement a software application that facilitates the understanding and use of Bayesian networks. The application will allow users to visualize and query complex Bayesian networks. As for the construction of the networks, it is done by developers and encoded in JSON files, a standard format for storing structured data. By loading a description of the network in a standard format, users can observe the relationships between variables and the associated probabilities. An intuitive graphical interface will enable clear visualization of the network structure. Furthermore, users can simulate different scenarios by setting values for certain variables and then calculate the probabilities for other variables using the enumeration inference algorithm. This application has the potential to be used in various fields, from medical diagnostics to recommendation systems, providing a powerful tool for modeling uncertainty and making decisions based on probabilities.

## Theoretical Aspects of the Algorithm

The algorithm is used to compute the conditional probability distribution for a query variable (X), given a set of observed values (e) for the evidence variables (E), in a Bayesian network (bn).

The ENUMERATION-ASK function

- This is the starting point for calculating probabilities.
- Input:
  - X: the query variable.
  - e: the observed values for the evidence variables E.
  - bn: the Bayesian network (which contains the variables and their dependencies).
- Output:
  - A probability distribution for the possible values of X.
- Process:
  - Create a distribution Q(X), where each value xi of the variable X receives a probability calculated by the ENUMERATE-ALL function.
  - Normalize the result so that the sum of the probabilities equals 1.
  
The ENUMERATE-ALL function

- This calculates the probability by processing all variables in the network.
- Input:
  - vars: the remaining variables to process.
  - e: the observed values.
- Output:
  - A real probability.
- Process:
  - If no variables remain, return 1 (base case for recursion).
  - If the current variable V has an observed value in e, calculate the probability using V’s parents and continue with the remaining variables.
  - If V is not an evidence variable, calculate the weighted sum of the probabilities for all possible values of V, recursively extending e.

### Theoretical Aspects

- Probabilistic Model: 
  - The algorithm uses the chain rule from probability theory.
- Enumeration Inference: 
  - The algorithm calculates the exact conditional probability, but it may become inefficient for large networks, as it enumerates all possible combinations of variables.
- Normalization: 
  - After calculating the raw probabilities for all values of X, the result is normalized so that it represents a valid probability distribution.
- Evidence and Hidden Variables:
  - Evidence variables E: variables with known (observed) values.
- Hidden variables: 
  - All other variables in the network, for which marginal summation must be performed.
- Recursion: 
  - The algorithm is recursive: ENUMERATE-ALL processes the variables one by one, propagating probabilities from parent variables to descendant variables.
 
## Solution Method

The implementation method is intended for managing and processing data from the graph, displaying information about nodes, and recursively calculating probabilities.

Thus, the calculation of probabilities is based on the following conditions:
- Depending on the number of parents:
  - No parents: probabilities remain unchanged.
  - One parent: the probabilities of the node are calculated based on the parent's values.  
  - Two parents: the probabilities are calculated using combinations of the probabilities of the two parents.

The CalculateNodeProbability method ensures the recursive calculation of probabilities for the node and all of its ancestors.
- If a node has an observed value (T or F), the probabilities are set directly: 100% for the observed value and 0% for the other value.
- To calculate the probabilities in the correct order, the nodes are topologically sorted (TopologicalSort). This ensures that the nodes are processed only after their parents have been calculated.
- The CalculateProbability method determines the probabilities for a target node (nodeQuery), starting from the initial probabilities and propagating the effects throughout the graph.

## Results Obtained

The first stage of this project involved implementing the functionality to load the Bayesian network from a JSON file into the user interface, providing an attractive and intuitive graphical design that allows the user to visualize the structure of nodes and connections. Additionally, the option to view the probability table was also implemented, which can be accessed by clicking on each node.

<p align ="center">
    <img src="https://github.com/user-attachments/assets/2784169d-7b9a-409e-90a4-b0d3b9923e61" alt="bayesian network">
</p>

The project continued with the development of the option to make observations for each individual node, as well as the implementation of an option to reset the changes made by the user.

<p align ="center">
    <img src="https://github.com/user-attachments/assets/0653b5a7-bd5f-48b9-a1b7-5a1864a71881" alt="bayesian observer">
</p>

The project was completed with the introduction of the final feature, which is also the core functionality, allowing us to calculate the desired probabilities based on the set nodes.

In the images below, you can observe the functionality described above implemented.

<p align ="center">
    <img src="https://github.com/user-attachments/assets/bcb09fab-4cd2-489f-92d0-10f658f7267b" alt="bayesian probabilistic">
</p>

The probability result was verified using the Belief and Decision Network Tool.

<p align ="center">
    <img src="https://github.com/user-attachments/assets/2029f4d8-095f-453c-9831-5fd646fa3c12" alt="bayesian result">
</p>
