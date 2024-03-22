def calculate_tree_stats(node):
    if node is None:
        return 0, 0, 0

    left_sum, left_depth, left_nodes = calculate_tree_stats(node.get('left'))
    right_sum, right_depth, right_nodes = calculate_tree_stats(node.get('right'))

    # Sum of the current node and its children
    total_sum = node['value'] + left_sum + right_sum

    # Deepest level of the current node and its children
    current_depth = 1 + max(left_depth, right_depth)

    # Number of nodes in the current tree
    total_nodes = 1 + left_nodes + right_nodes

    return total_sum, current_depth, total_nodes

# Example tree structure
tree = {
    'value': 67,
    'left': {'value': 765, 'left': None, 'right': None},
    'right': {
        'value': 167,
        'left': {
            'value': 564,
            'left': None,
            'right': {'value': 379, 'left': None, 'right': None}
        },
        'right': None
    }
}

# Calculate tree statistics
sum_tree, deepest_level, total_nodes = calculate_tree_stats(tree)

# Output the results
print("Sum =", sum_tree)
print("Deepest level =", deepest_level)
print("Nodes =", total_nodes)
