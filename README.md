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
