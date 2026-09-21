# Pathfinding

## 1. Water types and cost

Type and Cost

Open water = 1
Rocks = 7
Island = -1
Favorable = 0.5
Adverse current = 2 / 3


## 3. Pseudo code
    function GetCellCost(position):
    hits = check what is at position

    if nothing hit:
        return 1                    // open water

    cost = 1
    for each hit:
        if hit is island or edge:
            return -1
        if hit is water zone:
            cost = highest of (cost, zone cost)

    return cost

    function BuildGrid():
    for each cell in grid:
        cell.cost = GetCellCost(cell center position) // not sure if this is the correct way to do this? Made this code based on tutorials which explained
        // pseudo codes
