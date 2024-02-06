#include <iostream>
#include "legosim.h"

int graph[100][100][100];
int main() {
    LegoBrick* b1x1 = new LegoBrick(3, 1, 1);
    addBrick(b1x1, 0, 0, 0);
    return 0;
}

void addBrick(LegoBrick* brick, int x, int y, int z){
    brick->setLocation(x, y, z);
    std::vector<std::vector<std::vector<int>>> dimensions = brick->getDimensions();
    for (int i = 0; i < brick->getHeight()+2; ++i) {
        for (int j = 0; j < brick->getLength(); ++j) {
            for (int k = 0; k < brick->getWidth(); ++k) {
                graph[i + z][j + y][k + x] = dimensions[i][j][k];
            }
        }
    }
}